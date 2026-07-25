// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GL.GLRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.GL;

[RaterInformation(99, "General Liability")]
[QuoteOptionTagParser]
public class GLRater : RaterWithUIBase, IQuoteOptionTagParser
{
  private List<GLRater.GLPremiumInfo> _premiumInfo;

  public GLRater() => this._premiumInfo = new List<GLRater.GLPremiumInfo>();

  public override string GetOptionDescription(Guid quoteOptionGuid) => (string) null;

  protected override Form CreateUI() => ObjectFactory.Instance.CreateFormEX(typeof (frmGLRater));

  private int ZeroPremiumCount
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblGLExposures INNER JOIN tblQuoteOptions ON tblGLExposures.QuoteOptionID = tblQuoteOptions.QuoteOptionID WHERE (tblQuoteOptions.Bound = 1) AND (tblQuoteOptions.QuoteGUID=@QG) AND (tblGLExposures.TotalPremium = 0)", new object[2]
      {
        (object) "@QG",
        (object) this.QuoteGuid
      });
    }
  }

  public override bool IsReadyForBind
  {
    get
    {
      bool isReadyForBind;
      if (!this.Quote.IsEndorsement)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetBoundQuoteOptionID", new object[4]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid,
          (object) "@LineGuid",
          (object) this.LineGuid
        }));
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        {
          isReadyForBind = true;
          goto label_8;
        }
        int quoteOptionID = (int) objectValue;
        if (!Conversions.ToBoolean(DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TerrorismDeclined, TerrPremium FROM tblQuoteOptionGL WHERE QuoteOptionID=@QOID", new object[2]
        {
          (object) "@QOID",
          (object) quoteOptionID
        }).Rows[0][0]))
        {
          bool flag = MessageBox.Show("Terrorism coverage has been offered on this risk.\n\nHas the insured elected to take this coverage?", "Terrorism Coverage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
          if (flag)
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteOptionGL SET TerrorismDeclined=@TD WHERE QuoteOptionID=@QOID", new object[4]
            {
              (object) "@TD",
              (object) flag,
              (object) "@QOID",
              (object) quoteOptionID
            });
          this.RefreshPremiums(new QuoteOption(quoteOptionID));
        }
      }
      isReadyForBind = this.ZeroPremiumCount <= 0 || MessageBox.Show($"There are {this.ZeroPremiumCount.ToString()} class codes with a $0 premium.\n\nDo you still want to bind this policy?", "0 Premium Class Codes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No;
label_8:
      return isReadyForBind;
    }
  }

  public override List<string> NotReadyToBindReason
  {
    get
    {
      List<string> readyToBindReason;
      if (this.ZeroPremiumCount > 0)
        readyToBindReason = new List<string>()
        {
          $"There are {this.ZeroPremiumCount.ToString()} class codes with a $0 premium.\n\nPlease enter a premium amount for each class code on the policy."
        };
      else
        readyToBindReason = (List<string>) null;
      return readyToBindReason;
    }
  }

  public override bool SupportsUnderwritingLocations => true;

  private void RefreshBinderPremiums(QuoteOption quoteOption)
  {
    Quote quote = new Quote(this.QuoteGuid);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT (PremPremium + ProdPremium), TerrPremium, TerrorismDeclined FROM tblQuoteOptionGL WHERE QuoteOptionID=@QOID", new object[2]
    {
      (object) "@QOID",
      (object) quoteOption.QuoteOptionID
    });
    Decimal num1 = Conversions.ToDecimal(dataTable.Rows[0][0]);
    bool boolean = Conversions.ToBoolean(dataTable.Rows[0][2]);
    Decimal num2 = Conversions.ToDecimal(dataTable.Rows[0][1]);
    int officeId = quote.QuotingLocation.OfficeID;
    this.UpdatePremium(quoteOption.QuoteOptionGuid, num1, num1, officeId, RatingFunctions.GetPremiumChargeCode(quote.StateID, "PREM"));
    if (!boolean)
      this.UpdatePremium(quoteOption.QuoteOptionGuid, num2, num2, officeId, RatingFunctions.GetPremiumChargeCode(quote.StateID, "TERR"));
    else
      this.DeletePremium(quoteOption.QuoteOptionGuid, RatingFunctions.GetPremiumChargeCode(quote.StateID, "TERR"), officeId);
  }

  private static bool ZeroPremiumsOnLocations(QuoteOption quoteOption)
  {
    bool flag;
    if (quoteOption.Quote.IsEndorsement)
      flag = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblGLExposures WHERE QuoteOptionID=@QOID AND ModificationCode <> @U", new object[4]
      {
        (object) "@QOID",
        (object) quoteOption.QuoteOptionID,
        (object) "@U",
        (object) "U"
      }) == 0;
    else
      flag = Decimal.Compare(DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT ISNULL(SUM(TotalPremium),0) FROM tblGLExposures WHERE QuoteOptionID=@QOID", new object[2]
      {
        (object) "@QOID",
        (object) quoteOption.QuoteOptionID
      }), 0M) == 0;
    return flag;
  }

  internal void RefreshPremiums(QuoteOption quoteOption)
  {
    if (GLRater.ZeroPremiumsOnLocations(quoteOption))
    {
      this.RefreshBinderPremiums(quoteOption);
    }
    else
    {
      bool flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT TerrorismDeclined FROM tblQuoteOptionGL WHERE QuoteOptionID=@QOID", new object[2]
      {
        (object) "@QOID",
        (object) quoteOption.QuoteOptionID
      });
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT U.State, G.OfficeID, G.PremPremium, G.ProdPremium, G.TerrPremium, G.OriginalExposureID, Factor, G.ModificationCode FROM tblGLExposures G INNER JOIN tblUnderwritingLocations U ON G.LocationID = U.LocationID WHERE G.QuoteOptionID=@QID", new object[2]
        {
          (object) "@QID",
          (object) quoteOption.QuoteOptionID
        }).Rows)
        {
          MDIControls.Instance.StatusBarText = $"Calculating {row[0].ToString()} premiums...";
          GLRater.GLPremiumInfo glPremiumInfo = this.GetGLPremiumInfo(Conversions.ToInteger(row[1]), row[0].ToString());
          Decimal d1 = Conversions.ToDecimal(row[3]);
          Decimal d2_1 = Conversions.ToDecimal(row[2]);
          Decimal d2_2 = 1M;
          if (!row.IsNull("Factor"))
            d2_2 = row.Field<Decimal>("Factor");
          string Left = string.Empty;
          if (!row.IsNull("ModificationCode"))
            Left = row.Field<string>("ModificationCode");
          if (this.Quote.IsEndorsement && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) != 0)
          {
            MDIControls.Instance.StatusBarText = $"Comparing {row[0].ToString()} premiums against the prior amounts...";
            DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PremPremium + ProdPremium AS Premium, TerrPremium FROM tblGLExposures WHERE ExposureID=@EID", new object[2]
            {
              (object) "@EID",
              (object) (int) row["OriginalExposureID"]
            });
            Decimal d2_3 = (Decimal) dataTable.Rows[0]["Premium"];
            Decimal d2_4 = (Decimal) dataTable.Rows[0]["TerrPremium"];
            // ISSUE: variable of a reference type
            Decimal& local1;
            // ISSUE: explicit reference operation
            Decimal num1 = Decimal.Add(^(local1 = ref glPremiumInfo.Premium), Decimal.Multiply(Decimal.Subtract(Decimal.Add(d1, d2_1), d2_3), d2_2));
            local1 = num1;
            // ISSUE: variable of a reference type
            Decimal& local2;
            // ISSUE: explicit reference operation
            Decimal num2 = Decimal.Add(^(local2 = ref glPremiumInfo.TerrorismPremium), Decimal.Multiply(Decimal.Subtract(Conversions.ToDecimal(row[4]), d2_4), d2_2));
            local2 = num2;
          }
          else
          {
            // ISSUE: variable of a reference type
            Decimal& local3;
            // ISSUE: explicit reference operation
            Decimal num3 = Decimal.Add(^(local3 = ref glPremiumInfo.Premium), Decimal.Multiply(Decimal.Add(d1, d2_1), d2_2));
            local3 = num3;
            // ISSUE: variable of a reference type
            Decimal& local4;
            // ISSUE: explicit reference operation
            Decimal num4 = Decimal.Add(^(local4 = ref glPremiumInfo.TerrorismPremium), Decimal.Multiply(Conversions.ToDecimal(row[4]), d2_2));
            local4 = num4;
          }
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
        try
        {
          foreach (GLRater.GLPremiumInfo glPremiumInfo in this._premiumInfo)
          {
            MDIControls.Instance.StatusBarText = $"Saving {glPremiumInfo.StateID} premium...";
            this.UpdatePremium(quoteOption.QuoteOptionGuid, glPremiumInfo.Premium, glPremiumInfo.Premium, glPremiumInfo.OfficeID, RatingFunctions.GetPremiumChargeCode(glPremiumInfo.StateID, "PREM"));
            MDIControls.Instance.StatusBarText = $"Saving {glPremiumInfo.StateID} terrorism premium...";
            if (!flag)
              this.UpdatePremium(quoteOption.QuoteOptionGuid, glPremiumInfo.TerrorismPremium, glPremiumInfo.TerrorismPremium, glPremiumInfo.OfficeID, RatingFunctions.GetPremiumChargeCode(glPremiumInfo.StateID, "TERR"));
            else
              this.DeletePremium(quoteOption.QuoteOptionGuid, RatingFunctions.GetPremiumChargeCode(glPremiumInfo.StateID, "TERR"), glPremiumInfo.OfficeID);
          }
        }
        finally
        {
          List<GLRater.GLPremiumInfo>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        MDIControls.Instance.StatusBarText = string.Empty;
      }
      this._premiumInfo.Clear();
    }
    RaterBase.RefreshMiscPremiums(quoteOption.QuoteOptionID);
  }

  private GLRater.GLPremiumInfo GetGLPremiumInfo(int officeID, string stateID)
  {
    GLRater.GLPremiumInfo glPremiumInfo1;
    try
    {
      foreach (GLRater.GLPremiumInfo glPremiumInfo2 in this._premiumInfo)
      {
        if (glPremiumInfo2.OfficeID == officeID && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(glPremiumInfo2.StateID, stateID, false) == 0)
        {
          glPremiumInfo1 = glPremiumInfo2;
          goto label_6;
        }
      }
    }
    finally
    {
      List<GLRater.GLPremiumInfo>.Enumerator enumerator;
      enumerator.Dispose();
    }
    GLRater.GLPremiumInfo glPremiumInfo3 = new GLRater.GLPremiumInfo();
    glPremiumInfo3.StateID = stateID;
    glPremiumInfo3.OfficeID = officeID;
    this._premiumInfo.Add(glPremiumInfo3);
    glPremiumInfo1 = glPremiumInfo3;
label_6:
    return glPremiumInfo1;
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GLRater._Closure\u0024__17\u002D0 closure170 = new GLRater._Closure\u0024__17\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure170.\u0024VB\u0024Local_e = e;
    if (cmd.Transaction != null)
    {
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) cmd.Transaction, new ExecuteHandler((object) closure170, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DefaultDatabase.ExecuteNonQuery("dbo.CopyGLInfo", new object[4]
      {
        (object) "@newQuoteGuid",
        (object) closure170.\u0024VB\u0024Local_e.NewQuoteGuid,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      });
    }
  }

  public bool ApplicableToThisOption(Guid quoteOptionGuid)
  {
    int num;
    return new QuoteOption(quoteOptionGuid).RaterID.HasValue && num == 99;
  }

  public List<DocTag> ProcessTags(Guid quoteOptionGuid, List<DocTag> tags)
  {
    int quoteOptionId = new QuoteOption(quoteOptionGuid).QuoteOptionID;
    try
    {
      foreach (DocTag tag in tags)
      {
        string lower = tag.InnerTagName.ToLower();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_occ", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_terr", false) == 0)
          {
            tag.TagValue = string.Empty;
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN TerrorismDeclined = 0 THEN TerrPremium ELSE 0 END FROM tblQuoteOptionGL WHERE QuoteOptionID = @QOID", new object[2]
            {
              (object) "@QOID",
              (object) quoteOptionId
            }));
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
              tag.TagValue = objectValue.ToString();
          }
        }
        else
        {
          tag.TagValue = string.Empty;
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT tblGLLimits.LimitDisplay FROM tblQuoteOptionGL INNER JOIN tblGLLimits ON tblQuoteOptionGL.OCC_ID = tblGLLimits.ID WHERE tblQuoteOptionGL.QuoteOptionID = @QOID", new object[2]
          {
            (object) "@QOID",
            (object) quoteOptionId
          }));
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
            tag.TagValue = objectValue.ToString();
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

  public void AddAvailableTags(dsTemplateDocs.TagsDataTable dt)
  {
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("gl_occ", "GL - Occurrence Limit");
    tagsDataTable.AddTagsRow("gl_terr", "GL - Terrorism Premium");
  }

  private sealed class GLPremiumInfo
  {
    public int OfficeID;
    public string StateID;
    public Decimal Premium;
    public Decimal TerrorismPremium;
  }
}

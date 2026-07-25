// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Crime.CrimeRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.Crime;

[RaterInformation(97, "Crime")]
public class CrimeRater : RaterWithUIBase
{
  public override string GetOptionDescription(Guid quoteOptionGuid) => (string) null;

  protected override Form CreateUI() => ObjectFactory.Instance.CreateFormEX(typeof (frmCrimeRater));

  internal void RefreshPremiums(QuoteOption qo)
  {
    Decimal num = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT TotalPremium FROM tblQuoteOptionCrime WHERE QuoteOptionID=@QuoteOptionID", new object[2]
    {
      (object) "@QuoteOptionID",
      (object) qo.QuoteOptionID
    });
    this.UpdatePremium(qo.QuoteOptionGuid, new Decimal(Convert.ToInt32(num)));
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction((DbTransaction) cmd.Transaction, new ExecuteHandler((object) new CrimeRater._Closure\u0024__4\u002D0()
    {
      \u0024VB\u0024Local_e = e
    }, __methodptr(_Lambda\u0024__0)));
  }
}

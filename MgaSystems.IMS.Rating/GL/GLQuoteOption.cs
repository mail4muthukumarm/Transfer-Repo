// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GL.GLQuoteOption
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.Common.Enums;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.GL;

public class GLQuoteOption : IQuoteOption
{
  private readonly int _quoteOptionID;

  public GLQuoteOption(int quoteOptionID) => this._quoteOptionID = quoteOptionID;

  public Decimal CalculateFactor(EndorsementCalcTypes calcType, DateTime effectiveDate)
  {
    Decimal factor;
    if (Quote.FromQuoteOptionID(this._quoteOptionID).QuoteStatus == QuoteStatus.PendingReinstatement)
      factor = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT tblGLExposures_1.Factor FROM tblGLExposures INNER JOIN tblGLExposures tblGLExposures_1 ON tblGLExposures.OriginalExposureID = tblGLExposures_1.ExposureID WHERE tblGLExposures.QuoteOptionID=@quoteOptionID", new object[2]
      {
        (object) "@quoteOptionID",
        (object) this._quoteOptionID
      });
    else
      factor = new QuoteOption(this._quoteOptionID).CalculateFactor(calcType, effectiveDate);
    return factor;
  }
}

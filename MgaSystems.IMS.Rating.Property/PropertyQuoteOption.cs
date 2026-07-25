// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.PropertyQuoteOption
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

using MGASystems.BusinessObjects;
using MGASystems.Common.Enums;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Rating.Property;

public class PropertyQuoteOption : IQuoteOption
{
  private int _quoteOptionID;

  public PropertyQuoteOption(int quoteOptionID) => this._quoteOptionID = quoteOptionID;

  public Decimal CalculateFactor(EndorsementCalcTypes calcType, DateTime effectiveDate)
  {
    Decimal factor;
    if (Quote.FromQuoteOptionID(this._quoteOptionID).QuoteStatus == QuoteStatus.PendingReinstatement)
      factor = (Decimal) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT tblPropertyExposure_1.Factor FROM tblPropertyExposure INNER JOIN tblPropertyExposure tblPropertyExposure_1 ON tblPropertyExposure.OriginalExposureID = tblPropertyExposure_1.ExposureID WHERE tblPropertyExposure.QuoteOptionID=@quoteOptionID", new object[2]
      {
        (object) "@quoteOptionID",
        (object) this._quoteOptionID
      });
    else
      factor = new QuoteOption(this._quoteOptionID).CalculateFactor(calcType, effectiveDate);
    return factor;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.ExcelQuoteCollection
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Data;

public class ExcelQuoteCollection : BulkObservableCollection<ExcelQuote>
{
  public Guid DestinationQuoteGuid { get; }

  public ExcelQuoteCollection(Guid sourceQuote, bool autoFill = true)
  {
    this.DestinationQuoteGuid = sourceQuote;
    this.AddRange((IEnumerable<ExcelQuote>) DefaultDatabase.ExecuteDataTable(autoFill ? "ExcelRating_SelectCopyInformation" : "ExcelRating_SelectCopyInformationExtended", new object[2]
    {
      (object) "@quoteGuid",
      (object) sourceQuote
    }).AsEnumerable().Select<DataRow, ExcelQuote>((System.Func<DataRow, ExcelQuote>) (row => new ExcelQuote((int) row["ControlNo"], (Guid) row["QuoteGuid"], Utility.IsNull<Guid>(row["FactorSetGuid"], Guid.Empty), Utility.IsNull<string>(row["StateId"], ""), Utility.IsNull<string>(row["LineName"], ""), (DateTime) row["DateCreated"], (Decimal) row["Premium"], Utility.IsNull<string>(row["InsuredPolicyName"], ""), this))));
  }
}

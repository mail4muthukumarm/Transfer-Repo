// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.QuoteStatusModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

[TableMapping("lstQuoteStatus")]
public class QuoteStatusModel
{
  [TableFieldMapping("QuoteStatusId")]
  public int QuoteStatusId { get; set; }

  [TableFieldMapping("Description")]
  public string QuoteStatus { get; set; }

  [TableFieldMapping("Bound")]
  public bool IsBound { get; set; }

  public QuoteStatusModel(int quoteStatusId, string quoteStatus, bool isBound)
  {
    this.QuoteStatusId = quoteStatusId;
    this.QuoteStatus = quoteStatus;
    this.IsBound = isBound;
  }

  public static QuoteStatusModel Create(DataRow dr)
  {
    return new QuoteStatusModel(ExtensionsMethods.FieldAs<int>(dr, "QuoteStatusID", DataRowVersion.Current), dr.Field<string>("Description"), dr.Field<bool>("Bound"));
  }
}

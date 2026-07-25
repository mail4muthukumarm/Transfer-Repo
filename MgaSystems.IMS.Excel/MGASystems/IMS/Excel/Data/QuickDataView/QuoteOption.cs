// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.QuickDataView.QuoteOption
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Excel.Data.QuickDataView;

[Description("Quote Option")]
[TableMapping("tblQuoteOptions")]
public abstract class QuoteOption : BindingObject
{
  [DataKey]
  [TableFieldMapping]
  public int QuoteOptionID { get; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool Quote { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool Bound { get; set; }

  public string LineName { get; }

  public static QuoteOption Create(DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<QuoteOption>(new object[1]
    {
      (object) row
    });
  }

  public QuoteOption(DataRow row)
  {
    this.Quote = row.Field<bool>(nameof (Quote));
    this.Bound = row.Field<bool>(nameof (Bound));
    this.QuoteOptionID = row.Field<int>(nameof (QuoteOptionID));
    this.LineName = row.Field<string>(nameof (LineName));
  }
}

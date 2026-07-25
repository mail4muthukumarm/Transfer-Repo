// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.PremiumAdmin.OptionPremium
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Excel.Data.PremiumAdmin;

[Description("Option Premium")]
[TableMapping("tblQuoteOptionPremiums")]
public abstract class OptionPremium : BindingObject
{
  [DataKey]
  [TableFieldMapping]
  public int PremiumID { get; }

  public Guid QuoteOptionGuid { get; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual Decimal Premium { get; set; }

  public int OfficeID { get; }

  public int ChargeCode { get; }

  public string LineName { get; }

  public string ChargeName { get; }

  public static OptionPremium Create(DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<OptionPremium>(new object[1]
    {
      (object) row
    });
  }

  public OptionPremium(DataRow row)
  {
    this.PremiumID = row.Field<int>(nameof (PremiumID));
    this.QuoteOptionGuid = row.Field<Guid>(nameof (QuoteOptionGuid));
    this.Premium = row.Field<Decimal>(nameof (Premium));
    this.OfficeID = row.Field<int>(nameof (OfficeID));
    this.ChargeCode = row.Field<int>(nameof (ChargeCode));
    this.LineName = row.Field<string>(nameof (LineName));
    this.ChargeName = row.Field<string>(nameof (ChargeName));
  }
}

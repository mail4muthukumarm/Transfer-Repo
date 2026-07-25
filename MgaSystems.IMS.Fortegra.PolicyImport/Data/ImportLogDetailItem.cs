// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Data.ImportLogDetailItem
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Data;

public abstract class ImportLogDetailItem : ValidatingBindingObject
{
  public PolicyImportDataManager Parent { get; }

  [NotificationProperty]
  public virtual int ImportLogID { get; set; }

  [NotificationProperty]
  public virtual string PolicyNumber { get; set; }

  [NotificationProperty]
  public virtual string IMSControlNo { get; set; }

  [NotificationProperty]
  public virtual string IMSQuoteID { get; set; }

  [NotificationProperty]
  public virtual string TransactionType { get; set; }

  [NotificationProperty]
  public virtual string PolicyEffectiveDate { get; set; }

  [NotificationProperty]
  public virtual string PolicyExpirationDate { get; set; }

  [NotificationProperty]
  public virtual string TransactionEffectiveDate { get; set; }

  [NotificationProperty]
  public virtual Decimal PreparedPremium { get; set; }

  [NotificationProperty]
  public virtual Decimal BilledPremium { get; set; }

  [NotificationProperty]
  public virtual Decimal PremiumDifference { get; set; }

  [NotificationProperty]
  public virtual string DateProcessed { get; set; }

  [NotificationProperty]
  public virtual string ErrorMessage { get; set; }

  [NotificationProperty]
  public virtual Guid DnlTrId { get; set; }

  internal static ImportLogDetailItem Create(PolicyImportDataManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ImportLogDetailItem>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ImportLogDetailItem(PolicyImportDataManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ImportLogID = row.Field<int>(nameof (ImportLogID));
    this.PolicyNumber = row.Field<string>(nameof (PolicyNumber));
    this.IMSControlNo = row.Field<string>(nameof (IMSControlNo));
    this.IMSQuoteID = row.Field<string>(nameof (IMSQuoteID));
    this.TransactionType = row.Field<string>(nameof (TransactionType));
    this.PolicyEffectiveDate = row.Field<string>(nameof (PolicyEffectiveDate));
    this.PolicyExpirationDate = row.Field<string>(nameof (PolicyExpirationDate));
    this.TransactionEffectiveDate = row.Field<string>(nameof (TransactionEffectiveDate));
    this.PreparedPremium = row.Field<Decimal>(nameof (PreparedPremium));
    this.BilledPremium = row.Field<Decimal>(nameof (BilledPremium));
    this.PremiumDifference = row.Field<Decimal>(nameof (PremiumDifference));
    this.DateProcessed = row.Field<string>(nameof (DateProcessed));
    this.ErrorMessage = row.Field<string>(nameof (ErrorMessage));
    this.DnlTrId = row.Field<Guid>(nameof (DnlTrId));
  }
}

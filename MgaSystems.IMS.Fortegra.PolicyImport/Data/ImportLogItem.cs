// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Data.ImportLogItem
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Data;

public abstract class ImportLogItem : ValidatingBindingObject
{
  public PolicyImportDataManager Parent { get; }

  [NotificationProperty]
  public virtual int ID { get; set; }

  [NotificationProperty]
  public virtual string ImportDate { get; set; }

  [NotificationProperty]
  public virtual int TransactionCount { get; set; }

  [NotificationProperty]
  public virtual int TransactionsPendingCount { get; set; }

  [NotificationProperty]
  public virtual int TransactionsProcessedCount { get; set; }

  [NotificationProperty]
  public virtual int TransactionsErroredCount { get; set; }

  [NotificationProperty]
  public virtual string HasImportErrorXML { get; set; }

  internal static ImportLogItem Create(PolicyImportDataManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ImportLogItem>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  internal static ImportLogItem Create(PolicyImportDataManager parent, int ID, string ImportDate)
  {
    return NotifyProxyTypeManager.Allocate<ImportLogItem>(new object[3]
    {
      (object) parent,
      (object) ID,
      (object) ImportDate
    });
  }

  public ImportLogItem(PolicyImportDataManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ID = row.Field<int>(nameof (ID));
    this.ImportDate = row.Field<string>(nameof (ImportDate));
    this.TransactionCount = row.Field<int>(nameof (TransactionCount));
    this.TransactionsPendingCount = row.Field<int>(nameof (TransactionsPendingCount));
    this.TransactionsProcessedCount = row.Field<int>(nameof (TransactionsProcessedCount));
    this.TransactionsErroredCount = row.Field<int>(nameof (TransactionsErroredCount));
    this.HasImportErrorXML = row.Field<string>(nameof (HasImportErrorXML));
  }

  public ImportLogItem(PolicyImportDataManager parent, int NewImportLogID, string NewImportDate)
  {
    this.Parent = parent;
    this.ID = NewImportLogID;
    this.ImportDate = NewImportDate;
    this.TransactionCount = 0;
    this.TransactionsPendingCount = 0;
    this.TransactionsProcessedCount = 0;
    this.TransactionsErroredCount = 0;
    this.HasImportErrorXML = string.Empty;
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Data.ImportPreprocessErrorItem
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Data;

public abstract class ImportPreprocessErrorItem : ValidatingBindingObject
{
  public PolicyImportDataManager Parent { get; }

  [NotificationProperty]
  public virtual int ImportLogID { get; set; }

  [NotificationProperty]
  public virtual string PolicyNumber { get; set; }

  [NotificationProperty]
  public virtual string ExistingPolicyControlNumber { get; set; }

  [NotificationProperty]
  public virtual string ErrorMessage { get; set; }

  internal static ImportPreprocessErrorItem Create(PolicyImportDataManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ImportPreprocessErrorItem>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ImportPreprocessErrorItem(PolicyImportDataManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ImportLogID = row.Field<int>(nameof (ImportLogID));
    this.PolicyNumber = row.Field<string>(nameof (PolicyNumber));
    this.ExistingPolicyControlNumber = row.Field<string>(nameof (ExistingPolicyControlNumber));
    this.ErrorMessage = row.Field<string>(nameof (ErrorMessage));
  }
}

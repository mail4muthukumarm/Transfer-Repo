// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Data.ImportSourceProducerLocationItem
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Data;

public abstract class ImportSourceProducerLocationItem : BindingObject
{
  public PolicyImportDataManager Parent { get; }

  [NotificationProperty]
  public virtual int ID { get; set; }

  [NotificationProperty]
  public virtual int ImportSource { get; set; }

  [NotificationProperty]
  public virtual int ProducerLocationID { get; set; }

  [NotificationProperty]
  public virtual string ProducerLocationName { get; set; }

  internal static ImportSourceProducerLocationItem Create(
    PolicyImportDataManager parent,
    DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ImportSourceProducerLocationItem>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ImportSourceProducerLocationItem(PolicyImportDataManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ID = row.Field<int>(nameof (ID));
    this.ImportSource = row.Field<int>(nameof (ImportSource));
    this.ProducerLocationID = row.Field<int>(nameof (ProducerLocationID));
    this.ProducerLocationName = row.Field<string>(nameof (ProducerLocationName));
  }
}

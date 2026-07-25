// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Data.ImportSource
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System.ComponentModel.DataAnnotations;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Data;

[TableMapping("Fortegra_lstAL3ImportSources")]
public abstract class ImportSource : ValidatingBindingObject
{
  public PolicyImportDataManager Parent { get; }

  [DataKey]
  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual int ID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string SourceName { get; set; }

  internal static ImportSource Create(PolicyImportDataManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ImportSource>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ImportSource(PolicyImportDataManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ID = row.Field<int>(nameof (ID));
    this.SourceName = row.Field<string>(nameof (SourceName));
  }

  internal static ImportSource Create(PolicyImportDataManager parent)
  {
    return NotifyProxyTypeManager.Allocate<ImportSource>(new object[1]
    {
      (object) parent
    });
  }

  public ImportSource(PolicyImportDataManager parent)
  {
    this.Parent = parent;
    this.ID = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "Fortegra_GetNextImportSourceID");
  }
}

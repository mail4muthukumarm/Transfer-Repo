// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Data.ExcelToXMLVersion
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System.Data;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.Data;

public abstract class ExcelToXMLVersion : BindingObject
{
  public PolicyImportDataManager Parent { get; }

  [NotificationProperty]
  public virtual int ID { get; set; }

  [NotificationProperty]
  public virtual int ImportSource { get; set; }

  [NotificationProperty]
  public virtual int ExcelToXMLVersionID { get; set; }

  [NotificationProperty]
  public virtual string Note { get; set; }

  [NotificationProperty]
  public virtual string ExcelToXMLVersionName { get; set; }

  internal static ExcelToXMLVersion Create(PolicyImportDataManager parent, DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<ExcelToXMLVersion>(new object[2]
    {
      (object) parent,
      (object) row
    });
  }

  public ExcelToXMLVersion(PolicyImportDataManager parent, DataRow row)
  {
    this.Parent = parent;
    this.ID = row.Field<int>(nameof (ID));
    this.ImportSource = row.Field<int>(nameof (ImportSource));
    this.ExcelToXMLVersionID = row.Field<int>(nameof (ExcelToXMLVersion));
    this.ExcelToXMLVersionName = System.Enum.GetName(typeof (MgaSystems.Ims.Fortegra.PolicyImport.Enum.PolicyImportExcelToXmlVersions), (object) this.ExcelToXMLVersionID);
    this.Note = string.IsNullOrEmpty(row.Field<string>(nameof (Note))) ? this.ExcelToXMLVersionName : row.Field<string>(nameof (Note));
  }
}

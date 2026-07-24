// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.InsCipher.Administration.Data.LineImportCode
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MgaSystems.IMS.Policies.InsCipher.Administration.Data;

[Description("Import Code Mapping")]
[TableMapping("tblInsCipher_Lines")]
public abstract class LineImportCode : BindingObject, IDataErrorInfo
{
  public MappingDataManager Parent { get; private set; }

  [DataKey]
  [TableFieldMapping]
  public int? ID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  [Required]
  public virtual Guid LineGUID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  [Required]
  [StringLength(20)]
  public virtual string CoverageCode { get; set; }

  public string LineName
  {
    get
    {
      try
      {
        return this.LineGUID.Equals(Guid.Empty) ? "Not Selected..." : this.Parent.XmlInputData.Document.SelectSingleNode($"InsCipherData/Lines/Line[@LineGUID='{this.LineGUID}']/@LineName").Value;
      }
      catch
      {
        return "Not selected...";
      }
    }
  }

  public string CoverageName
  {
    get
    {
      try
      {
        return string.IsNullOrEmpty(this.CoverageCode) ? "Not Selected..." : $"{this.Parent.XmlInputData.Document.SelectSingleNode($"InsCipherData/Codes/Code[@ImportCode='{this.CoverageCode}']/@LineOfBusiness").Value} [{this.CoverageCode}]";
      }
      catch
      {
        return "Not selected...";
      }
    }
  }

  public LineImportCode(MappingDataManager parent) => this.Parent = parent;

  public static LineImportCode Create(MappingDataManager parent)
  {
    return NotifyProxyTypeManager.Allocate<LineImportCode>(new object[1]
    {
      (object) parent
    });
  }

  public static LineImportCode Create(MappingDataManager parent, Guid lineGuid)
  {
    LineImportCode lineImportCode = LineImportCode.Create(parent);
    lineImportCode.LineGUID = lineGuid;
    return lineImportCode;
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }
}

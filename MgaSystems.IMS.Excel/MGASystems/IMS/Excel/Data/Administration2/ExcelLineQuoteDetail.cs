// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.ExcelLineQuoteDetail
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

[System.ComponentModel.Description("Excel Quote Detail")]
[TableMapping("tblExcelRating_LineQuoteDetails")]
public abstract class ExcelLineQuoteDetail : BindingObject, IEditableObject, IDataErrorInfo
{
  [DataKey]
  [TableFieldMapping]
  public int? Id { get; set; }

  public ExcelRaterFactorSet Parent { get; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual Guid? LineGuid { get; set; }

  [Required]
  [StringLength(2000)]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Description { get; set; }

  [Required]
  [StringLength(2000)]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string TagName { get; set; }

  public ExcelLineQuoteDetail(
    ExcelRaterFactorSet parent,
    int? id,
    Guid? lineGuid,
    string description,
    string tagName)
  {
    this.Parent = parent;
    this.Id = id;
    this.Description = description;
    this.TagName = tagName;
    this.LineGuid = lineGuid;
  }

  public static ExcelLineQuoteDetail Create(
    ExcelRaterFactorSet parent,
    int? id,
    Guid? lineGuid,
    string description,
    string tagName)
  {
    return NotifyProxyTypeManager.Allocate<ExcelLineQuoteDetail>(new object[5]
    {
      (object) parent,
      (object) id,
      (object) lineGuid,
      (object) description,
      (object) tagName
    });
  }

  [TableFieldMapping]
  public Guid FactorSetGuid => this.Parent.FactorSetGuid.Value;

  void IEditableObject.BeginEdit()
  {
    this.Parent.Parent.Parent.ChangeManager.BeginEdit((IEditableObject) this);
  }

  void IEditableObject.CancelEdit()
  {
    this.Parent.Parent.Parent.ChangeManager.CancelEdit((IEditableObject) this);
  }

  void IEditableObject.EndEdit()
  {
    this.Parent.Parent.Parent.ChangeManager.EndEdit((IEditableObject) this);
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }
}

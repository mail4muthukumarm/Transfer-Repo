// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data.ChargeCodeGLAccountMappingDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data;

public class ChargeCodeGLAccountMappingDto : DtoBase<int>
{
  public override int UniqueIdentifier => this.Id;

  [TableFieldMapping("Id")]
  public int Id { get; set; }

  [TableFieldMapping("ChargeCode")]
  public int ChargeCode { get; set; }

  [TableFieldMapping("OfficeId")]
  public int OfficeId { get; set; }

  [TableFieldMapping("GlAcctId")]
  public int? GlAccountId { get; set; }

  [TableFieldMapping("IsEditable")]
  public bool IsEditable { get; set; }

  [TableFieldMapping("LastModifiedDate")]
  public DateTime LastModifiedDate { get; set; }

  [TableFieldMapping("LastModifiedUser")]
  public Guid LastModifiedUser { get; set; }

  [TableFieldMapping("Name_FirstLast")]
  public string LastModifiedUserName { get; set; }
}

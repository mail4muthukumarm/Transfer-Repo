// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.GLAccount.GLAccountDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.GLAccount;

public class GLAccountDto : DtoBase<int>
{
  public override int UniqueIdentifier => this.GlAccountId;

  [TableFieldMapping("GLAcctId")]
  public int GlAccountId { get; set; }

  [TableFieldMapping("GLCompanyClassID")]
  public int? GlCompanyClassId { get; set; }

  [TableFieldMapping("FullName")]
  public string FullName { get; set; }

  [TableFieldMapping("ShortName")]
  public string ShortName { get; set; }

  [TableFieldMapping("AcctNum")]
  public int AccountNumber { get; set; }

  [TableFieldMapping("RollUpTo")]
  public int? RollUpTo { get; set; }

  [TableFieldMapping("ControlAcct")]
  public bool ControlAccount { get; set; }

  [TableFieldMapping("DateCreated")]
  public DateTime DateCreated { get; set; }

  [TableFieldMapping("Closed")]
  public bool? IsClosed { get; set; }

  [TableFieldMapping("GlCompanyId")]
  public int? GLCompanyId { get; set; }

  [TableFieldMapping("AcctClassName")]
  public string AccountClassName { get; set; }
}

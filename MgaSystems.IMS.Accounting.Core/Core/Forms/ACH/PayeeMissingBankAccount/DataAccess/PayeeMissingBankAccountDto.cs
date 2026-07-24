// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess.PayeeMissingBankAccountDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess;

public class PayeeMissingBankAccountDto : 
  DtoBase<Guid>,
  INamedValue<Guid>,
  IUniqueObject<Guid>,
  IUniqueObject,
  INamedValue
{
  public override Guid UniqueIdentifier => throw new NotImplementedException();

  [TableFieldMapping("PayeeGuid")]
  public Guid EntityGuid { get; set; }

  [TableFieldMapping("Name")]
  public string Name { get; set; }

  [TableFieldMapping("ClaimNumber")]
  public string ClaimNumber { get; set; }

  [TableFieldMapping("EntityType")]
  public string EntityTypeName { get; set; }

  [TableFieldMapping("InsuredGuid")]
  public Guid? InsuredGuid { get; set; }

  [TableFieldMapping("InsuredName")]
  public string InsuredName { get; set; }
}

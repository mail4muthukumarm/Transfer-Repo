// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Utility.EntityTypes.AccountingEntityTypeProvider
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Utility.EntityTypes;

public class AccountingEntityTypeProvider
{
  public AccountingEntityType GetByCode(string code)
  {
    return ((IEnumerable<AccountingEntityType>) this.All).SingleOrDefault<AccountingEntityType>((Func<AccountingEntityType, bool>) (x => x.Code == code)) ?? throw new ArgumentOutOfRangeException(nameof (code));
  }

  protected virtual AccountingEntityType[] All { get; } = new AccountingEntityType[15]
  {
    AccountingEntityType.CompanyGroup,
    AccountingEntityType.Company,
    AccountingEntityType.CompanyLocation,
    AccountingEntityType.CompanyLine,
    AccountingEntityType.Producer,
    AccountingEntityType.ProducerLocation,
    AccountingEntityType.Insured,
    AccountingEntityType.User,
    AccountingEntityType.EntityGroup,
    AccountingEntityType.ExpExpensePayee,
    AccountingEntityType.ThirdExpensePayee,
    AccountingEntityType.FncExpensePayee,
    AccountingEntityType.InsExpensePayee,
    AccountingEntityType.Intermediary,
    AccountingEntityType.None
  };
}

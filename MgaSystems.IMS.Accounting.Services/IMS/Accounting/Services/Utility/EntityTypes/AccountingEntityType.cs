// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Utility.EntityTypes.AccountingEntityType
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Utility.EntityTypes;

public class AccountingEntityType : 
  INamedValue<string>,
  IUniqueObject<string>,
  IUniqueObject,
  INamedValue
{
  public string Code { get; }

  public string Name { get; }

  public string UniqueIdentifier => this.Code;

  object IUniqueObject.UniqueIdentifier => (object) this.UniqueIdentifier;

  public AccountingEntityType(string code, string name)
  {
    this.Code = code ?? throw new ArgumentNullException(nameof (code));
    this.Name = name ?? throw new ArgumentNullException(nameof (name));
  }

  public override bool Equals(object obj)
  {
    return obj is AccountingEntityType accountingEntityType && accountingEntityType.Code.Equals(this.Code);
  }

  public override string ToString() => this.Name;

  public static AccountingEntityType CompanyGroup { get; } = new AccountingEntityType("CG", "Company Group");

  public static AccountingEntityType Company { get; } = new AccountingEntityType("CO", nameof (Company));

  public static AccountingEntityType CompanyLocation { get; } = new AccountingEntityType("CL", "Company Location");

  public static AccountingEntityType CompanyLine { get; } = new AccountingEntityType("C", nameof (CompanyLine));

  public static AccountingEntityType Producer { get; } = new AccountingEntityType("P", nameof (Producer));

  public static AccountingEntityType ProducerLocation { get; } = new AccountingEntityType("B", "Producer Location");

  public static AccountingEntityType Insured { get; } = new AccountingEntityType("I", nameof (Insured));

  public static AccountingEntityType User { get; } = new AccountingEntityType("U", nameof (User));

  public static AccountingEntityType EntityGroup { get; } = new AccountingEntityType("G", "Entity Group");

  public static AccountingEntityType ExpExpensePayee { get; } = new AccountingEntityType("X", "EXP Expense Payee");

  public static AccountingEntityType ThirdExpensePayee { get; } = new AccountingEntityType("3", "3rd Expense Payee");

  public static AccountingEntityType FncExpensePayee { get; } = new AccountingEntityType("F", "FNC Expense Payee");

  public static AccountingEntityType InsExpensePayee { get; } = new AccountingEntityType("S", "INS Expense Payee");

  public static AccountingEntityType Intermediary { get; } = new AccountingEntityType("IN", nameof (Intermediary));

  public static AccountingEntityType None { get; } = new AccountingEntityType(string.Empty, string.Empty);
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.BankAccount.BankAccountKey
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.BankAccount;

public class BankAccountKey
{
  public BankAccountKey(char? bankAccountTypeId, string bankAccountNumber)
  {
    this.BankAccountTypeId = bankAccountTypeId;
    this.BankAccountNumber = bankAccountNumber;
  }

  public char? BankAccountTypeId { get; set; }

  public string BankAccountNumber { get; set; }

  public override bool Equals(object obj)
  {
    if (!(obj is BankAccountKey bankAccountKey))
      return false;
    char? bankAccountTypeId1 = bankAccountKey.BankAccountTypeId;
    int? nullable1 = bankAccountTypeId1.HasValue ? new int?((int) bankAccountTypeId1.GetValueOrDefault()) : new int?();
    char? bankAccountTypeId2 = this.BankAccountTypeId;
    int? nullable2 = bankAccountTypeId2.HasValue ? new int?((int) bankAccountTypeId2.GetValueOrDefault()) : new int?();
    if (!(nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue))
      return false;
    string bankAccountNumber = this.BankAccountNumber;
    return bankAccountNumber == null ? bankAccountKey.BankAccountNumber == null : bankAccountNumber.Equals(bankAccountKey.BankAccountNumber);
  }
}

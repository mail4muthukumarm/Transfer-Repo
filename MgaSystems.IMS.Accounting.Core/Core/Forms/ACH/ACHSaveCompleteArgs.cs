// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.ACHSaveCompleteArgs
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class ACHSaveCompleteArgs
{
  public Guid EntityGuid { get; set; }

  public string AccountName { get; set; }

  public string BankName { get; set; }

  public string AccountNumber { get; set; }

  public string RoutingNumber { get; set; }

  public string AccountType { get; set; }

  public ACHSaveCompleteArgs(
    Guid entityGuid,
    string accountName,
    string bankName,
    string accountNumber,
    string routingNumber,
    string accountType)
  {
    this.EntityGuid = entityGuid;
    this.AccountName = accountName;
    this.BankName = bankName;
    this.AccountNumber = this.AccountNumber;
    this.RoutingNumber = routingNumber;
    this.AccountType = accountType;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.CheckInformation
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class CheckInformation
{
  private Guid payeeGuid;
  private Utility.PaymentMethod payMethod;
  private char charPayMethod;
  private GLAccount bankGlAccount;
  private DateTime checkDate;
  private string comments;
  private string checkMemo;
  private string payeeName;
  private string payeeAddress1;
  private string payeeAddress2;
  private string payeeCity;
  private string payeeState;
  private string payeeZip;
  private string payeeZipPlus;
  private string checkName;

  public CheckInformation()
  {
  }

  public CheckInformation(
    Utility.PaymentMethod paymentMethod,
    Guid payeeGuid,
    DateTime checkDate,
    GLAccount bankGlAccount)
  {
    this.PayMethod = paymentMethod;
    this.PayeeGuid = payeeGuid;
    this.CheckDate = checkDate;
    this.BankGlAccount = bankGlAccount;
  }

  public CheckInformation(
    Utility.PaymentMethod paymentMethod,
    Guid payeeGuid,
    DateTime checkDate,
    GLAccount bankGlAccount,
    string payeeName,
    string payeeAddress1,
    string payeeAddress2,
    string payeeCity,
    string payeeState,
    string payeeZip,
    string payeeZipPlus,
    string checkName)
  {
    this.PayMethod = paymentMethod;
    this.PayeeGuid = payeeGuid;
    this.CheckDate = checkDate;
    this.BankGlAccount = bankGlAccount;
    this.PayeeName = payeeName;
    this.PayeeAddress1 = payeeAddress1;
    this.PayeeAddress2 = payeeAddress2;
    this.PayeeCity = payeeCity;
    this.PayeeState = payeeState;
    this.PayeeZip = payeeZip;
    this.PayeeZipPlus = payeeZipPlus;
    this.CheckName = checkName;
  }

  public CheckInformation(
    Utility.PaymentMethod paymentMethod,
    Guid payeeGuid,
    DateTime checkDate,
    GLAccount bankGlAccount,
    string payeeName,
    string payeeAddress1,
    string payeeAddress2,
    string payeeCity,
    string payeeState,
    string payeeZip,
    string payeeZipPlus,
    string checkName,
    string checkMemo)
  {
    this.PayMethod = paymentMethod;
    this.PayeeGuid = payeeGuid;
    this.CheckDate = checkDate;
    this.BankGlAccount = bankGlAccount;
    this.PayeeName = payeeName;
    this.PayeeAddress1 = payeeAddress1;
    this.PayeeAddress2 = payeeAddress2;
    this.PayeeCity = payeeCity;
    this.PayeeState = payeeState;
    this.PayeeZip = payeeZip;
    this.PayeeZipPlus = payeeZipPlus;
    this.CheckName = checkName;
    this.CheckMemo = checkMemo;
  }

  public CheckInformation(
    char payMethod,
    Guid payeeGuid,
    DateTime checkDate,
    GLAccount bankGlAccount,
    string payeeName,
    string payeeAddress1,
    string payeeAddress2,
    string payeeCity,
    string payeeState,
    string payeeZip,
    string payeeZipPlus,
    string checkName,
    string checkMemo)
  {
    this.CharPayMethod = payMethod;
    this.PayeeGuid = payeeGuid;
    this.CheckDate = checkDate;
    this.BankGlAccount = bankGlAccount;
    this.PayeeName = payeeName;
    this.PayeeAddress1 = payeeAddress1;
    this.PayeeAddress2 = payeeAddress2;
    this.PayeeCity = payeeCity;
    this.PayeeState = payeeState;
    this.PayeeZip = payeeZip;
    this.PayeeZipPlus = payeeZipPlus;
    this.CheckName = checkName;
    this.CheckMemo = checkMemo;
  }

  public Guid PayeeGuid
  {
    get => this.payeeGuid;
    set => this.payeeGuid = value;
  }

  public Utility.PaymentMethod PayMethod
  {
    get => this.payMethod;
    set => this.payMethod = value;
  }

  public char CharPayMethod
  {
    get => this.charPayMethod;
    set => this.charPayMethod = value;
  }

  public GLAccount BankGlAccount
  {
    get => this.bankGlAccount;
    set => this.bankGlAccount = value;
  }

  public DateTime CheckDate
  {
    get => this.checkDate;
    set => this.checkDate = value;
  }

  public string Comments
  {
    get => this.comments;
    set => this.comments = value;
  }

  public string CheckMemo
  {
    get => this.checkMemo;
    set => this.checkMemo = value;
  }

  public string PayeeName
  {
    get => this.payeeName;
    set => this.payeeName = value;
  }

  public string PayeeAddress1
  {
    get => this.payeeAddress1;
    set => this.payeeAddress1 = value;
  }

  public string PayeeAddress2
  {
    get => this.payeeAddress2;
    set => this.payeeAddress2 = value;
  }

  public string PayeeCity
  {
    get => this.payeeCity;
    set => this.payeeCity = value;
  }

  public string PayeeState
  {
    get => this.payeeState;
    set => this.payeeState = value;
  }

  public string PayeeZip
  {
    get => this.payeeZip;
    set => this.payeeZip = value;
  }

  public string PayeeZipPlus
  {
    get => this.payeeZipPlus;
    set => this.payeeZipPlus = value;
  }

  public string CheckName
  {
    get => this.checkName;
    set => this.checkName = value;
  }

  public int AchSettingsAccountID { get; set; }
}

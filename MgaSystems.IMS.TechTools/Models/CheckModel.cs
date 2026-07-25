// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.CheckModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MgaSystems.IMS.TechTools.Enums;
using System;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

public class CheckModel
{
  public int TransactNum { get; set; }

  public int CheckNum { get; set; }

  public DateTime CheckDate { get; set; }

  public string PayeeName { get; set; }

  public CheckType CheckType { get; set; }

  public int GLAcctID { get; set; }

  public DateTime? PrintDate { get; set; }

  public Decimal Amount { get; set; }

  public CheckModel(
    int transactNum,
    int checkNum,
    DateTime checkDate,
    string payeeName,
    CheckType checkType,
    int glAcctID,
    DateTime? printDate,
    Decimal amount)
  {
    this.TransactNum = transactNum;
    this.CheckNum = checkNum;
    this.CheckDate = checkDate;
    this.PayeeName = payeeName;
    this.CheckType = checkType;
    this.GLAcctID = glAcctID;
    this.PrintDate = printDate;
    this.Amount = amount;
  }
}

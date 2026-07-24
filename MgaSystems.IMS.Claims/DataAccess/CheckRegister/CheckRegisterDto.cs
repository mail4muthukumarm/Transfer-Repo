// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.CheckRegister.CheckRegisterDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.CheckRegister;

[Serializable]
public class CheckRegisterDto
{
  public string PaymentMethod { get; set; }

  public object CheckingAcountId { get; set; }

  public Guid PayeeGuid { get; set; }

  public DateTime CheckDate { get; set; }

  public string Comments { get; set; }

  public string CheckMemo { get; set; }

  public string PayeeName { get; set; }

  public string PayeeAddress1 { get; set; }

  public string PayeeAddress2 { get; set; }

  public string PayeeCity { get; set; }

  public string PayeeState { get; set; }

  public string PayeeZip { get; set; }

  public string PayeeZipPlus { get; set; }

  public string CheckName { get; set; }
}

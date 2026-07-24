// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod.PaymentMethodDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod;

public class PaymentMethodDto : 
  DtoBase<char>,
  INamedValue<char>,
  IUniqueObject<char>,
  IUniqueObject,
  INamedValue
{
  [TableFieldMapping("PayMethodID")]
  public char Code { get; set; }

  [TableFieldMapping("MethodName")]
  public string Name { get; set; }

  [TableFieldMapping("Active")]
  public bool IsActive { get; set; }

  [TableFieldMapping("IsAch")]
  public bool IsAch { get; set; }

  public override char UniqueIdentifier => this.Code;
}

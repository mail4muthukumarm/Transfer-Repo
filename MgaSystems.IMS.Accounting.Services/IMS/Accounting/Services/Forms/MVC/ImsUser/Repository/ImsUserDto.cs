// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository.ImsUserDto
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository;

public class ImsUserDto : DtoBase<Guid>
{
  public override Guid UniqueIdentifier => this.UserGuid;

  [TableFieldMapping("UserId")]
  public int UserId { get; set; }

  [TableFieldMapping("UserGuid")]
  public Guid UserGuid { get; set; }

  [TableFieldMapping("OfficeGuid")]
  public Guid OfficeGuid { get; set; }

  [TableFieldMapping("UserName")]
  public string UserName { get; set; }

  [TableFieldMapping("EmailAddress")]
  public string EmailAddress { get; set; }

  [TableFieldMapping("FirstName")]
  public string FirstName { get; set; }

  [TableFieldMapping("LastName")]
  public string LastName { get; set; }
}

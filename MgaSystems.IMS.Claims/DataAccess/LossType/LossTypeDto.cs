// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.LossType.LossTypeDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.LossType;

public class LossTypeDto : 
  DtoBase<int>,
  INamedValue<int>,
  IUniqueObject<int>,
  IUniqueObject,
  INamedValue
{
  [TableFieldMapping("LossType")]
  public string Name { get; set; }

  [TableFieldMapping("LossTypeId")]
  public int LossTypeId { get; set; }

  public virtual int UniqueIdentifier => throw new NotImplementedException();
}

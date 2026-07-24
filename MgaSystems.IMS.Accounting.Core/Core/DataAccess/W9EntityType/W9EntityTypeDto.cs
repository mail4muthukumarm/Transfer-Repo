// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType.W9EntityTypeDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.CommonInterface;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType;

public class W9EntityTypeDto : 
  DtoBase<int>,
  INamedValue<int>,
  IUniqueObject<int>,
  IUniqueObject,
  INamedValue
{
  public override int UniqueIdentifier => this.EntityTypeId;

  [TableFieldMapping("Entitytype")]
  public string Name { get; set; }

  [TableFieldMapping("EntityTypeId")]
  public int EntityTypeId { get; set; }
}

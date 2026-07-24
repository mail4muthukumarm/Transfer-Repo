// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry.SelectedEntity
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry;

public class SelectedEntity
{
  private string _entityType;

  public Guid EntityGuid { get; set; }

  public string EntityName { get; set; }

  public string EntityType
  {
    get
    {
      if (!string.IsNullOrEmpty(this._entityType))
        return this._entityType;
      Guid entityGuid = this.EntityGuid;
      if (this.EntityGuid.Equals(Guid.Empty))
        return string.Empty;
      this._entityType = (string) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT * FROM dbo.GetEntityType(@EntityGuid)", 0, (CommandArgumentType) 0, new object[2]
      {
        (object) "@EntityGuid",
        (object) this.EntityGuid
      });
      return this._entityType;
    }
    set => this._entityType = value;
  }

  public SelectedEntity(Guid entityGuid, string entityName, string entityType)
  {
    this.EntityGuid = entityGuid;
    this.EntityName = entityName;
    this.EntityType = entityType;
  }

  public SelectedEntity(Guid entityGuid, string entityName)
  {
    this.EntityGuid = entityGuid;
    this.EntityName = entityName;
  }

  public SelectedEntity()
  {
  }
}

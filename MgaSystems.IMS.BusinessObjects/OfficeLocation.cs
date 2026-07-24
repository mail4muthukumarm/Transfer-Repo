// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.OfficeLocation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblClientOffices")]
public class OfficeLocation : BaseDataObject
{
  private Guid _officeGuid;
  private static Dictionary<int, Guid> _officeIDToGuidCache = new Dictionary<int, Guid>();

  public OfficeLocation(int officeID)
  {
    this._officeGuid = Guid.Empty;
    if (OfficeLocation._officeIDToGuidCache.TryGetValue(officeID, out this._officeGuid))
      return;
    this._officeGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT OfficeGUID FROM dbo.tblClientOffices WHERE OfficeID = @OID", new object[2]
    {
      (object) "@OID",
      (object) officeID
    }) ?? Guid.Empty;
    if (this._officeGuid.Equals(Guid.Empty))
      throw new InvalidOperationException("Specified OfficeLocation does not exist");
  }

  public OfficeLocation(Guid officeGuid)
  {
    this._officeGuid = Guid.Empty;
    this._officeGuid = officeGuid;
  }

  [DataKey]
  public Guid OfficeGuid
  {
    get => this._officeGuid;
    protected set
    {
      this._officeGuid = this._officeGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified OfficeLocation {this._officeGuid} has already been initialized");
    }
  }

  [TableFieldMapping("dbo.IsPrimaryBankDefined(OfficeID) IsPrimaryBankDefined")]
  public bool IsPrimaryBankDefined
  {
    get => this.GetField<bool>(nameof (IsPrimaryBankDefined), nameof (IsPrimaryBankDefined));
  }

  [TableFieldMapping("Location")]
  public string LocationName => this.GetField<string>("Location", nameof (LocationName));

  [TableFieldMapping]
  public int OfficeID => this.GetField<int>(nameof (OfficeID), nameof (OfficeID));

  [TableFieldMapping]
  public string Address1 => this.GetField<string>(nameof (Address1), nameof (Address1));

  [TableFieldMapping]
  public string Address2 => this.GetField<string>(nameof (Address2), nameof (Address2));

  [TableFieldMapping]
  public string City => this.GetField<string>(nameof (City), nameof (City));

  [TableFieldMapping]
  public string County => this.GetField<string>(nameof (County), nameof (County));

  [TableFieldMapping]
  public string State => this.GetField<string>(nameof (State), nameof (State)) ?? string.Empty;

  [TableFieldMapping]
  public string ZipCode
  {
    get => this.GetField<string>(nameof (ZipCode), nameof (ZipCode)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string ZipPlus
  {
    get => this.GetField<string>(nameof (ZipPlus), nameof (ZipPlus)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax));

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email));

  public byte[] Logo => this.GetLazyField<byte[]>(nameof (Logo));

  public static OfficeLocation FromOfficeGuid(Guid officeGuid) => new OfficeLocation(officeGuid);
}

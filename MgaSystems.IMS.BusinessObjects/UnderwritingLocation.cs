// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.UnderwritingLocation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblUnderwritingLocations")]
public class UnderwritingLocation : BaseDataObject
{
  private int _locationId;

  public UnderwritingLocation(int underwritingLocationID)
  {
    this.LocationID = underwritingLocationID;
  }

  [DataKey]
  public int LocationID
  {
    get => this._locationId;
    set
    {
      this._locationId = this._locationId <= 0 ? value : throw new InvalidOperationException($"Specified UnderwritingLocation {this._locationId} has already been initialized");
    }
  }

  public int UnderwritingLocationID => this.LocationID;

  [TableFieldMapping]
  public Guid LocationGuid => this.GetField<Guid>(nameof (LocationGuid), nameof (LocationGuid));

  [TableFieldMapping]
  public short ClassCodeID => this.GetField<short>(nameof (ClassCodeID), nameof (ClassCodeID));

  [TableFieldMapping]
  public int InspectionCompanyID
  {
    get => this.GetField<int?>(nameof (InspectionCompanyID), nameof (InspectionCompanyID)) ?? -1;
  }

  public bool HasInspectionCompany => this.InspectionCompanyID != -1;

  [TableFieldMapping]
  public bool Photo => this.GetField<bool>(nameof (Photo), nameof (Photo));

  [TableFieldMapping]
  public bool Diagram => this.GetField<bool>(nameof (Diagram), nameof (Diagram));

  [TableFieldMapping]
  public bool CostEstimator => this.GetField<bool>(nameof (CostEstimator), nameof (CostEstimator));

  [TableFieldMapping]
  public string InspectionContact
  {
    get => this.GetField<string>(nameof (InspectionContact), nameof (InspectionContact));
  }

  public bool HasInspectionContact => string.IsNullOrEmpty(this.InspectionContact);

  [TableFieldMapping]
  public string InspectionContactPhone
  {
    get => this.GetField<string>(nameof (InspectionContactPhone), nameof (InspectionContactPhone));
  }
}

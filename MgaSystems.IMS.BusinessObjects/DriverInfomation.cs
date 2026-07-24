// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.DriverInfomation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblDriverInfo")]
public class DriverInfomation : BaseDataObject
{
  private int _driverId;

  public DriverInfomation(int controlNo, int driverID)
  {
    this.ControlNo = controlNo;
    this.DriverID = driverID;
  }

  [DataKey]
  public int DriverID
  {
    get => this._driverId;
    protected set
    {
      this._driverId = this._driverId <= 0 ? value : throw new InvalidOperationException($"Specified DriverInformation {this._driverId} has already been initialized");
    }
  }

  public int ControlNo { get; }

  [TableFieldMapping]
  public string FirstName => this.GetField<string>(nameof (FirstName), nameof (FirstName));

  [TableFieldMapping]
  public string LastName => this.GetField<string>(nameof (LastName), nameof (LastName));

  [TableFieldMapping]
  public DateTime? DOB => this.GetField<DateTime?>(nameof (DOB), nameof (DOB));

  [TableFieldMapping]
  public string LicenseNumber
  {
    get => this.GetField<string>(nameof (LicenseNumber), nameof (LicenseNumber));
  }

  [TableFieldMapping]
  public string StateID => this.GetField<string>(nameof (StateID), nameof (StateID));

  [TableFieldMapping]
  public int? StatusID => this.GetField<int?>(nameof (StatusID), nameof (StatusID));

  [TableFieldMapping]
  public DateTime DateAdded => this.GetField<DateTime>(nameof (DateAdded), nameof (DateAdded));

  [TableFieldMapping]
  public DateTime? DriverDeleted
  {
    get => this.GetField<DateTime?>(nameof (DriverDeleted), nameof (DriverDeleted));
  }

  [TableFieldMapping]
  public DateTime? DriverAdded
  {
    get => this.GetField<DateTime?>(nameof (DriverAdded), nameof (DriverAdded));
  }

  [TableFieldMapping]
  public string NumberOfPoints
  {
    get => this.GetField<string>(nameof (NumberOfPoints), nameof (NumberOfPoints));
  }

  [TableFieldMapping]
  public bool FurnishedCar => this.GetField<bool>(nameof (FurnishedCar), nameof (FurnishedCar));

  [TableFieldMapping]
  public string Comments
  {
    get => this.GetField<string>(nameof (Comments), nameof (Comments)) ?? string.Empty;
  }

  [TableFieldMapping]
  public byte? FullPartTime => this.GetField<byte?>(nameof (FullPartTime), nameof (FullPartTime));

  [TableFieldMapping]
  public bool CopyOnRenewal => this.GetField<bool>(nameof (CopyOnRenewal), nameof (CopyOnRenewal));

  [TableFieldMapping]
  public DateTime? LicenseExpDate
  {
    get => this.GetField<DateTime?>(nameof (LicenseExpDate), nameof (LicenseExpDate));
  }

  [TableFieldMapping]
  public string Street1
  {
    get => this.GetField<string>(nameof (Street1), nameof (Street1)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string Street2
  {
    get => this.GetField<string>(nameof (Street2), nameof (Street2)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string City => this.GetField<string>(nameof (City), nameof (City)) ?? string.Empty;

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

  public bool IsDOBNull => !this.DOB.HasValue;

  public bool IsLicenseNumberNull => string.IsNullOrEmpty(this.LicenseNumber);

  public bool IsStatusIDNull => !this.StatusID.HasValue;

  public bool IsDriverDeletedNull => !this.DriverDeleted.HasValue;

  public bool IsDriverAddedNull => !this.DriverAdded.HasValue;

  public bool IsNumberOfPointsNull => string.IsNullOrEmpty(this.NumberOfPoints);

  public bool IsFullPartTimeNull => !this.FullPartTime.HasValue;

  public bool IsLicenseExpDateNull => !this.LicenseExpDate.HasValue;

  public bool HasPolicyWatch
  {
    get
    {
      return this.CacheManualValue<bool>(nameof (HasPolicyWatch), (Func<bool>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP 1 ID FROM dbo.tblDriverReqs WITH (NOLOCK) WHERE DriverID=@DriverID", new object[2]
      {
        (object) "@DriverID",
        (object) this.DriverID
      }).HasValue));
    }
  }

  public List<DriverPolicyWatch> DriverPolicyWatches
  {
    get
    {
      return BaseDataObject.SelectMany<DriverPolicyWatch>("DriverID=@DriverID", (object) "@DriverID", (object) this.DriverID);
    }
  }
}

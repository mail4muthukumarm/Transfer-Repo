// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimDriverInformation
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System.Data.SqlTypes;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimDriverInformation
{
  public ClaimDriverInformation()
  {
  }

  public ClaimDriverInformation(int claimId) => this.ClaimId = claimId;

  public ClaimDriverInformation(int claimId, int driverId)
  {
    this.ClaimId = claimId;
    this.DriverId = driverId;
  }

  public ClaimDriverInformation(int claimId, string firstName, string lastName)
  {
    this.ClaimId = claimId;
    this.DriverFirstName = firstName;
    this.DriverLastName = lastName;
  }

  public int ClaimId { get; set; }

  public int DriverId { get; set; }

  public string DriverFirstName { get; set; }

  public string DriverLastName { get; set; }

  public bool ParkedVehicle { get; set; }

  public void Save()
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertDriverInformation", new object[10]
    {
      (object) "@ClaimId",
      (object) this.ClaimId,
      (object) "@DriverId",
      (object) (this.DriverId != 0 ? (SqlInt32) this.DriverId : SqlInt32.Null),
      (object) "@FirstName",
      (object) (string.IsNullOrEmpty(this.DriverFirstName) ? SqlString.Null : (SqlString) this.DriverFirstName),
      (object) "@LastName",
      (object) (string.IsNullOrEmpty(this.DriverLastName) ? SqlString.Null : (SqlString) this.DriverLastName),
      (object) "@parkedVehicle",
      (object) this.ParkedVehicle
    });
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.AccidentInformation
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Claims;

public class AccidentInformation
{
  private int _accidentInformationId;
  private int _claimId;
  private string _address1;
  private string _address2;
  private string _city;
  private string _state;
  private string _zipCode;
  private string _county;
  private string _isoCountryCode;
  private string _documentText;
  private string _accidentDescription;
  private string _accidentTime;
  private int _accidentTypeId;
  private Decimal _latitude;
  private Decimal _longitude;

  internal AccidentInformation()
  {
  }

  internal AccidentInformation(int claimId)
  {
    this._claimId = claimId;
    this.LoadAccidentInformation();
  }

  internal int AccidentInformationId => this._accidentInformationId;

  internal int ClaimId
  {
    get => this._claimId;
    set => this._claimId = value;
  }

  internal string Address1
  {
    get => this._address1;
    set => this._address1 = value;
  }

  internal string Address2
  {
    get => this._address2;
    set => this._address2 = value;
  }

  public string City
  {
    get => this._city;
    set => this._city = value;
  }

  public string State
  {
    get => this._state;
    set => this._state = value;
  }

  public string ZipCode
  {
    get => this._zipCode;
    set => this._zipCode = value;
  }

  public string ISOCountryCode
  {
    get => this._isoCountryCode;
    set => this._isoCountryCode = value;
  }

  public string County
  {
    get => this._county;
    set => this._county = value;
  }

  internal string DocumentText
  {
    get => this._documentText;
    set => this._documentText = value;
  }

  internal string AccidentDescription
  {
    get => this._accidentDescription;
    set => this._accidentDescription = value;
  }

  internal string AccidentTime
  {
    get => this._accidentTime;
    set => this._accidentTime = value;
  }

  public int AccidentTypeId
  {
    get => this._accidentTypeId;
    set => this._accidentTypeId = value;
  }

  internal Decimal Latitude
  {
    get => this._latitude;
    set => this._latitude = value;
  }

  internal Decimal Longitude
  {
    get => this._longitude;
    set => this._longitude = value;
  }

  internal void Save()
  {
    if (this._accidentInformationId == 0)
      this.SaveAccidentInformation();
    else
      this.UpdateAccidentInformation();
  }

  internal void SaveAccidentInformation()
  {
    this._accidentInformationId = int.Parse(DefaultDatabase.ExecuteScalar("spClaims_InsertAccidentInformation", new object[28]
    {
      (object) "@claimId",
      (object) this.ClaimId,
      (object) "@address1",
      (object) this.Address1,
      (object) "@address2",
      (object) this.Address2,
      (object) "@city",
      (object) this.City,
      (object) "@state",
      (object) this.State,
      (object) "@zipCode",
      (object) this.ZipCode,
      (object) "@isoCountryCode",
      (object) this.ISOCountryCode,
      (object) "@documentText",
      (object) this.DocumentText,
      (object) "@accidentDescription",
      (object) this.AccidentDescription,
      (object) "@accidentTime",
      (object) this.AccidentTime,
      (object) "@accidentTypeId",
      (object) this.AccidentTypeId,
      (object) "@latitude",
      (object) this.Latitude,
      (object) "@longitude",
      (object) this.Longitude,
      (object) "@county",
      (object) this.County
    }).ToString());
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.AppendLine(" saved new accident information.");
    stringBuilder.AppendLine("Address 1: ");
    stringBuilder.Append(this.Address1);
    stringBuilder.AppendLine("Address 2: ");
    stringBuilder.Append(this.Address2);
    stringBuilder.AppendLine("City: ");
    stringBuilder.Append(this.City);
    stringBuilder.AppendLine("State: ");
    stringBuilder.Append(this.State);
    stringBuilder.AppendLine("Zip Code: ");
    stringBuilder.Append(this.ZipCode);
    stringBuilder.AppendLine("Country Code: ");
    stringBuilder.Append(this.ISOCountryCode);
    stringBuilder.AppendLine("County: ");
    stringBuilder.Append(this.County);
    stringBuilder.AppendLine("Document Text: ");
    stringBuilder.Append(this.DocumentText);
    stringBuilder.AppendLine("Accident Description: ");
    stringBuilder.Append(this.AccidentDescription);
    stringBuilder.AppendLine("Accident Time: ");
    stringBuilder.Append(this.AccidentTime);
    stringBuilder.AppendLine("Latitude: ");
    stringBuilder.Append(this.Latitude);
    stringBuilder.AppendLine("Longitude: ");
    stringBuilder.Append(this.Longitude);
    Utility.LogAction(stringBuilder.ToString(), this.ClaimId);
  }

  internal void UpdateAccidentInformation()
  {
    DefaultDatabase.ExecuteScalar("spClaims_UpdateAccidentInformation", new object[28]
    {
      (object) "@accidentInformationId",
      (object) this.AccidentInformationId,
      (object) "@address1",
      (object) this.Address1,
      (object) "@address2",
      (object) this.Address2,
      (object) "@city",
      (object) this.City,
      (object) "@state",
      (object) this.State,
      (object) "@zipCode",
      (object) this.ZipCode,
      (object) "@isoCountryCode",
      (object) this.ISOCountryCode,
      (object) "@documentText",
      (object) this.DocumentText,
      (object) "@accidentDescription",
      (object) this.AccidentDescription,
      (object) "@accidentTime",
      (object) this.AccidentTime,
      (object) "@accidentTypeId",
      (object) this.AccidentTypeId,
      (object) "@latitude",
      (object) this.Latitude,
      (object) "@longitude",
      (object) this.Longitude,
      (object) "@county",
      (object) this.County
    });
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(CurrentUser.Instance.DisplayNameLastFirst);
    stringBuilder.AppendLine(" updated accident information.");
    stringBuilder.AppendLine("Address 1: ");
    stringBuilder.Append(this.Address1);
    stringBuilder.AppendLine("Address 2: ");
    stringBuilder.Append(this.Address2);
    stringBuilder.AppendLine("City: ");
    stringBuilder.Append(this.City);
    stringBuilder.AppendLine("State: ");
    stringBuilder.Append(this.State);
    stringBuilder.AppendLine("Zip Code: ");
    stringBuilder.Append(this.ZipCode);
    stringBuilder.AppendLine("Country Code: ");
    stringBuilder.Append(this.ISOCountryCode);
    stringBuilder.AppendLine("County: ");
    stringBuilder.Append(this.County);
    stringBuilder.AppendLine("Document Text: ");
    stringBuilder.Append(this.DocumentText);
    stringBuilder.AppendLine("Accident Description: ");
    stringBuilder.Append(this.AccidentDescription);
    stringBuilder.AppendLine("Accident Time: ");
    stringBuilder.Append(this.AccidentTime);
    stringBuilder.AppendLine("Latitude: ");
    stringBuilder.Append(this.Latitude);
    stringBuilder.AppendLine("Longitude: ");
    stringBuilder.Append(this.Longitude);
    Utility.LogAction(stringBuilder.ToString(), this.ClaimId);
  }

  private void LoadAccidentInformation()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetAccidentInformation", new object[2]
    {
      (object) "@ClaimId",
      (object) this._claimId
    });
    if (dataTable.Rows.Count != 1)
      return;
    DataRow row = dataTable.Rows[0];
    this._accidentInformationId = (int) row["accidentInformationId"];
    this._claimId = (int) row["claimId"];
    this._address1 = row["address1"].ToString();
    this._address2 = row["address2"].ToString();
    this._city = row["city"].ToString();
    this._state = row["state"].ToString();
    this._zipCode = row["zipcode"].ToString();
    if (row.Table.Columns.Contains("county"))
      this._county = row["county"].ToString();
    this._isoCountryCode = row["isocountrycode"].ToString();
    this._documentText = row["documenttext"].ToString();
    this._accidentDescription = row["accidentdescription"].ToString();
    this._accidentTime = row["accidenttime"].ToString();
    if (!string.IsNullOrEmpty(row["accidenttypeid"].ToString()))
      this._accidentTypeId = (int) row["accidenttypeid"];
    this._latitude = !((Decimal) row["latitude"] != -1M) ? 0M : (Decimal) row["latitude"];
    if ((Decimal) row["longitude"] != -1M)
      this._longitude = (Decimal) row["longitude"];
    else
      this._longitude = 0M;
  }
}

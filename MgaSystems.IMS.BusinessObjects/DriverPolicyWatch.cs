// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.DriverPolicyWatch
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblDriverReqs")]
public class DriverPolicyWatch : BaseDataObject
{
  private int _ID;

  public DriverPolicyWatch(int ID) => this._ID = ID;

  [DataKey]
  public int ID
  {
    get => this._ID;
    protected set
    {
      this._ID = this._ID <= 0 ? value : throw new InvalidOperationException($"Specified DriverPolicyWatch {this._ID} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int DriverID => this.GetField<int>(nameof (DriverID), nameof (DriverID));

  [TableFieldMapping]
  public string RequestControl
  {
    get => this.GetField<string>(nameof (RequestControl), nameof (RequestControl));
  }

  [TableFieldMapping("Valid")]
  public string ValidString => this.GetField<string>("Valid", nameof (ValidString));

  [TableFieldMapping]
  public string ErrorCode => this.GetField<string>(nameof (ErrorCode), nameof (ErrorCode));

  [TableFieldMapping]
  public string ErrorDescription
  {
    get => this.GetField<string>(nameof (ErrorDescription), nameof (ErrorDescription));
  }

  [TableFieldMapping("IsClear")]
  public string ClearString => this.GetField<string>("IsClear", nameof (ClearString));

  [TableFieldMapping]
  public DateTime OrderDate => this.GetField<DateTime>(nameof (OrderDate), nameof (OrderDate));

  [TableFieldMapping]
  public string CompanyClass => this.GetField<string>(nameof (CompanyClass), nameof (CompanyClass));

  [TableFieldMapping]
  public string CompanyScore => this.GetField<string>(nameof (CompanyScore), nameof (CompanyScore));

  [TableFieldMapping]
  public bool HasSuspensions
  {
    get => this.GetField<bool>(nameof (HasSuspensions), nameof (HasSuspensions));
  }

  [TableFieldMapping]
  public bool HasMajorViolations
  {
    get => this.GetField<bool>(nameof (HasMajorViolations), nameof (HasMajorViolations));
  }

  public bool Valid
  {
    get => !string.IsNullOrEmpty(this.ValidString) && this.ValidString.ToUpper().Equals("Y");
  }

  public bool HasError => !string.IsNullOrEmpty(this.ErrorCode);

  public bool IsClear
  {
    get => !string.IsNullOrEmpty(this.ClearString) && this.ClearString.ToUpper().Equals("Y");
  }

  public bool HasCompanyClass => !string.IsNullOrEmpty(this.CompanyClass);

  public bool HasCompanyScore => !string.IsNullOrEmpty(this.CompanyScore);
}

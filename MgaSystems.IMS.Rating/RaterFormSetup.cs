// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterFormSetup
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[TableMapping("dbo.tblRaterFormSetups")]
public class RaterFormSetup : BaseDataObject
{
  private int? _setupID;
  private CompanyLine _companyLine;
  private DataTable _dt;

  public RaterFormSetup(int setupID) => this._setupID = new int?(setupID);

  public RaterFormSetup(int setupID, Guid companylineGuid)
    : this(setupID)
  {
    this._companyLine = new CompanyLine(companylineGuid);
  }

  [DataKey]
  public int SetupID
  {
    get => this._setupID.Value;
    set
    {
      this._setupID = !this._setupID.HasValue ? new int?(value) : throw new InvalidOperationException($"Specified RaterFormSetup {this._setupID} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int? PolicyFormID => this.GetField<int?>(nameof (PolicyFormID), nameof (PolicyFormID));

  [TableFieldMapping]
  public int? CompanyLineConditionID
  {
    get => this.GetField<int?>(nameof (CompanyLineConditionID), nameof (CompanyLineConditionID));
  }

  [TableFieldMapping]
  public int CompanyLineID => this.GetField<int>(nameof (CompanyLineID), nameof (CompanyLineID));

  [TableFieldMapping]
  public int RaterID => this.GetField<int>(nameof (RaterID), nameof (RaterID));

  [TableFieldMapping]
  public bool SingleTransaction
  {
    get => this.GetField<bool>(nameof (SingleTransaction), nameof (SingleTransaction));
  }

  public CompanyLine CompanyLine
  {
    get
    {
      if (this._companyLine == null)
        this._companyLine = new CompanyLine(this.CompanyLineID);
      return this._companyLine;
    }
  }

  public bool HasPolicyFormID => this.PolicyFormID.HasValue;

  public bool HasCompanyLineConditionID => this.CompanyLineConditionID.HasValue;

  public Guid GetCompanyLineGuid => this.CompanyLine.CompanyLineGuid;

  public bool HasSimilarCompanyLineSetups => this.SimilarCompanyLineSetupsDatatable.Rows.Count > 0;

  public DataTable SimilarCompanyLineSetupsDatatable
  {
    get
    {
      if (this._dt == null)
        this._dt = DefaultDatabase.ExecuteDataTable("dbo.spHasSimilarCompanyLineRaterSetup", new object[6]
        {
          (object) "@SetupID",
          (object) this.SetupID,
          (object) "@companyLineGuid",
          (object) this.CompanyLine.CompanyLineGuid,
          (object) "@IsParentLine",
          (object) this.CompanyLine.IsParentLine
        });
      return this._dt;
    }
  }
}

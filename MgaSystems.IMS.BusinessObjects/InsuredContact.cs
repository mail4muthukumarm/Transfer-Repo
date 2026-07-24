// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.InsuredContact
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Data;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblInsuredContacts")]
public class InsuredContact : BaseDataObject
{
  private Guid _insuredContactGuid;

  public InsuredContact(Guid insuredLocationGuid, string systemDefinedCode)
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet("usp_GetContactName", new object[4]
    {
      (object) "@InsuredLocationGUID",
      (object) insuredLocationGuid,
      (object) "@SystemDefinedCode",
      (object) systemDefinedCode
    });
    this.FullName = dataSet.Tables[0].Rows[0].Field<string>(nameof (FullName));
    if (dataSet.Tables[1].Rows.Count <= 0)
      throw new SystemDefinedInsuredContactNotFoundException(systemDefinedCode);
    this._insuredContactGuid = dataSet.Tables[1].Rows[0].Field<Guid>("InsuredContactGUID");
  }

  public InsuredContact(Guid insuredContactGuid) => this._insuredContactGuid = insuredContactGuid;

  [DataKey]
  public Guid InsuredContactGuid
  {
    get => this._insuredContactGuid;
    protected set
    {
      this._insuredContactGuid = this._insuredContactGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified InsuredContact {this._insuredContactGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public string FName => this.GetField<string>(nameof (FName), nameof (FName));

  [TableFieldMapping]
  public string LName => this.GetField<string>(nameof (LName), nameof (LName));

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  public string FirstName => !string.IsNullOrEmpty(this.FName) ? this.FName : this.FullName;

  public string LastName => this.LName;

  public string FullName { get; }

  public bool HasPhoneNumber => !string.IsNullOrEmpty(this.Phone);
}

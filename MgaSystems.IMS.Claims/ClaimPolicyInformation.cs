// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimPolicyInformation
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimPolicyInformation
{
  private Guid _companyGuid;
  private string _companyName;
  private Guid _companyLocationGuid;
  private string _companyLocationName;
  private Guid _producerLocationGuid;
  private string _producerLocationName;
  private Guid _insuredGuid;
  private string _insuredName;
  private Guid _lineGuid;
  private string _policyNumber;
  private string _lineName;

  public ClaimPolicyInformation()
  {
  }

  public ClaimPolicyInformation(
    string policyNumber,
    Guid companyGuid,
    Guid producerLocationGuid,
    Guid insuredGuid)
  {
    this._policyNumber = policyNumber;
    this._companyGuid = companyGuid;
    this._producerLocationGuid = producerLocationGuid;
    this._insuredGuid = insuredGuid;
  }

  public DateTime PolicyEffectiveDate { get; set; }

  public DateTime PolicyExpirationDate { get; set; }

  public Guid CompanyGuid
  {
    get => this._companyGuid;
    set => this._companyGuid = value;
  }

  public string CompanyName
  {
    get => this._companyName;
    set => this._companyName = value;
  }

  public Guid CompanyLocationGuid
  {
    get => this._companyLocationGuid;
    set => this._companyLocationGuid = value;
  }

  public string CompanyLocationName
  {
    get => this._companyLocationName;
    set => this._companyLocationName = value;
  }

  public Guid LineGuid
  {
    get => this._lineGuid;
    set => this._lineGuid = value;
  }

  public Guid ProducerLocationGuid
  {
    get => this._producerLocationGuid;
    set => this._producerLocationGuid = value;
  }

  public string ProducerLocationName
  {
    get => this._producerLocationName;
    set => this._producerLocationName = value;
  }

  public Guid InsuredGuid
  {
    get => this._insuredGuid;
    set => this._insuredGuid = value;
  }

  public string InsuredName
  {
    get => this._insuredName;
    set => this._insuredName = value;
  }

  public string PolicyNumber
  {
    get => this._policyNumber;
    set => this._policyNumber = value;
  }

  public string LineName
  {
    get => this._lineName;
    set => this._lineName = value;
  }
}

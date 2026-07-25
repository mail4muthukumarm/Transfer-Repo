// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.ClearanceSearchInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.Clearance;

public struct ClearanceSearchInfo
{
  public bool InForce;
  public DateTime? EffectiveStart;
  public DateTime? EffectiveEnd;
  public DateTime? ExpirationStart;
  public DateTime? ExpirationEnd;
  public string PolicyNumber;
  public Guid? LineGuid;
  public string PolicyStatus;
  public string InsuredName;
  public string Address;
  public Guid? ProducerLocationGuid;
  public int? BusinessTypeID;
  public string FEIN;
  public bool StartsWith;
  public int NumResults;
  public int? InsuredID;
  public int? ControlNo;
  public int? SubmissionID;
  public string PolicyStateID;
  public string InsuredStateID;
  public Guid? CompanyLocationGuid;
  public bool IsSinglePolicySearch;
  public int? PolicyTypeID;
  public bool HideVoids;
  public Guid? Undewriter;
  public Guid? QuotingOffice;
  public Guid? IssuingOffice;
  public string InsuredPhone;
  public bool LimitToBoundStatusOnly;
  public string AccountNumber;
  public string ClaimNo;
  public object ClientData;
  public string MailingAddress;
  public string ProducerEmail;
  public string InsuredCity;
  public string RiskID;
}

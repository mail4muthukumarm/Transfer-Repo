// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimantLegalInformation
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimantLegalInformation
{
  private bool _suitServed;
  private DateTime? _dateServed;
  private DateTime? _dateAnswered;
  private ClaimantLegalInformation.EntityType _defenseEntityType;
  private string _defenseFirm = string.Empty;
  private string _defenseAttorney = string.Empty;
  private ClaimAddress _defenseAttorneyAddress;
  private ClaimantLegalInformation.EntityType _claimantAttorneyEntityType;
  private string _claimantLawFirm = string.Empty;
  private string _claimantAttorney = string.Empty;
  private ClaimAddress _claimantAttorneyAddress;
  private string _judge = string.Empty;
  private bool _publishedDecision;
  private string _defenseAttorneyFeinSsn = string.Empty;
  private string _claimantAttorneyFeinSsn = string.Empty;
  private Guid _defenseAttorneyGuid;
  private Guid _claimantAttorneyGuid;

  public bool SuitServed
  {
    get => this._suitServed;
    set => this._suitServed = value;
  }

  public DateTime? DateServed
  {
    get => this._dateServed;
    set => this._dateServed = value;
  }

  public DateTime? DateAnswered
  {
    get => this._dateAnswered;
    set => this._dateAnswered = value;
  }

  public ClaimantLegalInformation.EntityType DefenseFirmEntityType
  {
    get => this._defenseEntityType;
    set => this._defenseEntityType = value;
  }

  public string DefenseFirm
  {
    get => this._defenseFirm;
    set => this._defenseFirm = value;
  }

  public string DefenseAttorney
  {
    get => this._defenseAttorney;
    set => this._defenseAttorney = value;
  }

  public ClaimantLegalInformation.EntityType ClaimantAttorneyEntityType
  {
    get => this._claimantAttorneyEntityType;
    set => this._claimantAttorneyEntityType = value;
  }

  public string ClaimantLawFirm
  {
    get => this._claimantLawFirm;
    set => this._claimantLawFirm = value;
  }

  public string ClaimantAttorney
  {
    get => this._claimantAttorney;
    set => this._claimantAttorney = value;
  }

  public string Judge
  {
    get => this._judge;
    set => this._judge = value;
  }

  public bool PublishedDecision
  {
    get => this._publishedDecision;
    set => this._publishedDecision = value;
  }

  public ClaimAddress DefenseAttorneyAddress
  {
    get => this._defenseAttorneyAddress;
    set => this._defenseAttorneyAddress = value;
  }

  public ClaimAddress ClaimantAttorneyAddress
  {
    get => this._claimantAttorneyAddress;
    set => this._claimantAttorneyAddress = value;
  }

  public string DefenseAttorneyFeinSsn
  {
    get => this._defenseAttorneyFeinSsn;
    internal set => this._defenseAttorneyFeinSsn = value;
  }

  public string ClaimantAttorneyFeinSsn
  {
    get => this._claimantAttorneyFeinSsn;
    internal set => this._claimantAttorneyFeinSsn = value;
  }

  public Guid DefenseAttorneyGuid
  {
    get => this._defenseAttorneyGuid;
    set => this._defenseAttorneyGuid = value;
  }

  public Guid ClaimantAttorneyGuid
  {
    get => this._claimantAttorneyGuid;
    set => this._claimantAttorneyGuid = value;
  }

  public bool HasDefenseAttorney
  {
    get => this._defenseFirm.Length > 0 || this._defenseAttorney.Length > 0;
  }

  public bool HasClaimantAttorney
  {
    get => this._claimantLawFirm.Length > 0 || this._claimantAttorney.Length > 0;
  }

  [Flags]
  public enum EntityType
  {
    Individual = 0,
    Corporation = 1,
  }
}

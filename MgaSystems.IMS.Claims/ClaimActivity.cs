// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimActivity
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System;
using System.Data.SqlTypes;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimActivity
{
  private int? _activityId;
  private Utility.ClaimActivityType _activityType;
  private DateTime _activityDate;
  private Guid _userGuid;
  private string _userName;
  private Guid _claimantGuid;
  private string _claimantName;
  private Utility.ClaimStatus _status;

  private ClaimActivity()
  {
  }

  public ClaimActivity(
    Utility.ClaimActivityType activityType,
    DateTime activityDate,
    Guid userGuid,
    string userName,
    Utility.ClaimStatus status)
  {
    this._activityType = activityType;
    this._activityDate = activityDate;
    this._userGuid = userGuid;
    this._userName = userName;
    this._status = status;
  }

  public ClaimActivity(
    Utility.ClaimActivityType activityType,
    DateTime activityDate,
    Guid userGuid,
    string userName,
    Guid claimantGuid,
    string claimantName,
    Utility.ClaimStatus status)
  {
    this._activityType = activityType;
    this._activityDate = activityDate;
    this._userGuid = userGuid;
    this._userName = userName;
    this._claimantGuid = claimantGuid;
    this._claimantName = claimantName;
    this._status = status;
  }

  public ClaimActivity(
    int activityId,
    Utility.ClaimActivityType activityType,
    DateTime activityDate,
    Guid userGuid,
    string userName,
    Utility.ClaimStatus status)
  {
    this._activityId = new int?(activityId);
    this._activityType = activityType;
    this._activityDate = activityDate;
    this._userGuid = userGuid;
    this._userName = userName;
    this._status = status;
  }

  public ClaimActivity(
    int activityId,
    Utility.ClaimActivityType activityType,
    DateTime activityDate,
    Guid userGuid,
    string userName,
    Guid claimantGuid,
    string claimantName,
    Utility.ClaimStatus status)
  {
    this._activityId = new int?(activityId);
    this._activityType = activityType;
    this._activityDate = activityDate;
    this._userGuid = userGuid;
    this._userName = userName;
    this._claimantGuid = claimantGuid;
    this._claimantName = claimantName;
    this._status = status;
  }

  public int? ActivityId
  {
    get => this._activityId;
    protected set => this._activityId = value;
  }

  public Utility.ClaimActivityType ActivityType => this._activityType;

  public DateTime ActivityDate => this._activityDate;

  public Guid UserGuid => this._userGuid;

  internal string UserName => this._userName;

  public Guid ClaimantGuid => this._claimantGuid;

  public string ClaimantName => this._claimantName;

  public Utility.ClaimStatus Status => this._status;

  internal string Activity
  {
    get
    {
      string activity;
      switch (this._activityType)
      {
        case Utility.ClaimActivityType.ClaimCreated:
          activity = "Claim Created";
          break;
        case Utility.ClaimActivityType.ClaimantCreated:
          activity = "Claimant Created";
          break;
        case Utility.ClaimActivityType.ClaimModified:
          activity = "Claim Modified";
          break;
        case Utility.ClaimActivityType.ClaimantModified:
          activity = "Claimant Modified";
          break;
        case Utility.ClaimActivityType.ReserveCreated:
          activity = "Reserve Created";
          break;
        case Utility.ClaimActivityType.ReserveAdjusted:
          activity = "Reserve Adjusted";
          break;
        case Utility.ClaimActivityType.PaymentCreated:
          activity = "Payment Created";
          break;
        case Utility.ClaimActivityType.PaymentAdjusted:
          activity = "Payment Adjustment";
          break;
        case Utility.ClaimActivityType.ClaimClosed:
          activity = "Claim Closed";
          break;
        case Utility.ClaimActivityType.ClaimReopened:
          activity = "Claim Reopened";
          break;
        case Utility.ClaimActivityType.PaymentVoided:
          activity = "Payment Voided";
          break;
        default:
          activity = "Undefined";
          break;
      }
      return activity;
    }
  }

  public virtual void Save(int claimId)
  {
    object[] objArray = new object[12]
    {
      (object) "@ClaimId",
      (object) claimId,
      (object) "@Activity",
      (object) (int) this.ActivityType,
      (object) "@ActivityDate",
      (object) this.ActivityDate,
      (object) "@UserGuid",
      (object) this.UserGuid,
      (object) "@ClaimantGuid",
      null,
      null,
      null
    };
    Guid claimantGuid = this.ClaimantGuid;
    objArray[9] = (object) (this.ClaimantGuid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) this.ClaimantGuid);
    objArray[10] = (object) "@ClaimStatus";
    objArray[11] = (object) (int) this.Status;
    this._activityId = new int?((int) DefaultDatabase.ExecuteScalar("spClaims_InsertActivityRecord", objArray));
    this.ActivitySavedHandler();
  }

  public event EventHandler ActivitySaved;

  protected void ActivitySavedHandler()
  {
    if (this.ActivitySaved == null)
      return;
    this.ActivitySaved((object) this, new EventArgs());
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimitCheckManager
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.Lib;

public abstract class ThresholdLimitCheckManager : ValidatingBindingObject
{
  private int controlNo;

  public static bool RunThresholdCheckAtStartup { get; } = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ThresholdCheckAtStartup", true);

  public Guid QuoteGuid { get; set; }

  public Guid ControlGuid { get; set; }

  public string PolicyNo { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<ThresholdLimitCheck> ThresholdLimitCheckList { get; } = new BulkObservableCollection<ThresholdLimitCheck>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  public static ThresholdLimitCheckManager Create(
    Guid quoteGuid,
    int ctrlNo,
    Guid controlGuid,
    string policyNo,
    ThresholdLimitCheckType thresholdLimitCheckType)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitCheckManager>(new object[5]
    {
      (object) quoteGuid,
      (object) ctrlNo,
      (object) controlGuid,
      (object) policyNo,
      (object) thresholdLimitCheckType
    });
  }

  public ThresholdLimitCheckManager(
    Guid quoteGuid,
    int ctrlNo,
    Guid controlGuid,
    string policyNo,
    ThresholdLimitCheckType thresholdLimitCheckType)
  {
    this.QuoteGuid = quoteGuid;
    this.controlNo = ctrlNo;
    this.ControlGuid = controlGuid;
    this.PolicyNo = policyNo;
    this.RunThresholdCheck(thresholdLimitCheckType);
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
    {
      foreach (ChangeDetail delta in this.ChangeManager.DeltaList)
      {
        if (delta.ObjectThatChanged is ThresholdLimitCheck objectThatChanged)
        {
          object[] objArray = new object[4]
          {
            (object) (objectThatChanged.Approve ? " approved" : "unapproved"),
            (object) objectThatChanged.DatabaseField,
            null,
            null
          };
          Decimal? fieldValue = objectThatChanged.FieldValue;
          ref Decimal? local = ref fieldValue;
          objArray[2] = (object) (local.HasValue ? local.GetValueOrDefault().ToString("F") : (string) null);
          objArray[3] = (object) objectThatChanged.MaxValue;
          string action = string.Format("Threshold Limit {0}, Field {1} - {2}, Max Value {3}", objArray);
          DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spQuoteThresholdLimitsCheckUpdate", new object[14]
          {
            (object) "@ThresholdLimitsCheckID",
            (object) objectThatChanged.ThresholdLimitsCheckID,
            (object) "@ThresholdLimitID",
            (object) objectThatChanged.ThresholdLimitID,
            (object) "@QuoteGuid",
            (object) objectThatChanged.QuoteGuid,
            (object) "@FieldValue",
            (object) objectThatChanged.FieldValue,
            (object) "@ApproveDate",
            (object) objectThatChanged.ApproveDate,
            (object) "@ApproveUserGuid",
            (object) objectThatChanged.ApproveUserGuid,
            (object) "@MaxValueAtCheck",
            (object) objectThatChanged.MaxValue
          });
          CurrentUser.Instance.LogAction(action, this.ControlGuid);
        }
      }
      this.ChangeManager.AcceptChanges();
    }
    return validationResultList;
  }

  private void RunThresholdCheck(ThresholdLimitCheckType thresholdLimitCheckType)
  {
    ((Collection<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Clear();
    this.ThresholdLimitCheckList.AddRange((IEnumerable<ThresholdLimitCheck>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spQuoteThresholdLimitsCheck", new object[2]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid
    }).AsEnumerable().Select<DataRow, ThresholdLimitCheck>((System.Func<DataRow, ThresholdLimitCheck>) (row => ThresholdLimitCheck.Create(this, row))));
  }

  public void RefreshThresholdCheck(ThresholdLimitCheckType thresholdLimitCheckType)
  {
    this.ChangeManager.SuspendMonitoring((Action) (() => this.RunThresholdCheck(thresholdLimitCheckType)));
  }

  public bool CanBindHard(bool isQuoteBound)
  {
    return !isQuoteBound && ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopBind)).Count<ThresholdLimitCheck>() == ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopBind && a.ApproveDate.HasValue)).Count<ThresholdLimitCheck>();
  }

  public bool CanPrintQuoteHard()
  {
    return ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopQuote)).Count<ThresholdLimitCheck>() == ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopQuote && a.ApproveDate.HasValue)).Count<ThresholdLimitCheck>();
  }

  public bool CanBindSoft(bool isQuoteBound)
  {
    return !isQuoteBound && ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopBindSoft)).Count<ThresholdLimitCheck>() == ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopBindSoft && a.ApproveDate.HasValue)).Count<ThresholdLimitCheck>();
  }

  public bool CanPrintQuoteSoft()
  {
    return ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopQuoteSoft)).Count<ThresholdLimitCheck>() == ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopQuoteSoft && a.ApproveDate.HasValue)).Count<ThresholdLimitCheck>();
  }

  public bool ShowNotification(bool isQuoteBound)
  {
    return ((!this.CanBindHard(isQuoteBound) ? 1 : (!this.CanBindSoft(isQuoteBound) ? 1 : 0)) | (!this.CanPrintQuoteHard() ? (true ? 1 : 0) : (!this.CanPrintQuoteSoft() ? 1 : 0))) != 0;
  }

  public bool ShowBindMenu(bool isQuoteBound)
  {
    return !ThresholdLimitCheckManager.RunThresholdCheckAtStartup || this.CanBindHard(isQuoteBound);
  }

  public bool ShowQuotePrintMenu()
  {
    return !ThresholdLimitCheckManager.RunThresholdCheckAtStartup || this.CanPrintQuoteHard();
  }

  public bool HasApprovalItems()
  {
    return ((IEnumerable<ThresholdLimitCheck>) this.ThresholdLimitCheckList).Where<ThresholdLimitCheck>((System.Func<ThresholdLimitCheck, bool>) (a => a.StopQuote || a.StopBind || a.StopQuoteSoft || a.StopBindSoft)).Count<ThresholdLimitCheck>() > 0;
  }
}

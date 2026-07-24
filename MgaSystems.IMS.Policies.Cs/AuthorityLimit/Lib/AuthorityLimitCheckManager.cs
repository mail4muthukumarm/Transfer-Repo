// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitCheckManager
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

public abstract class AuthorityLimitCheckManager : ValidatingBindingObject
{
  private int controlNo;
  private ISupportNoteSystem supportNoteSystem;

  public static bool RunAuthorityCheckAtStartup { get; } = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("AuthorityCheckAtStartup", true);

  public Guid QuoteGuid { get; set; }

  public Guid UnderwriterGuid { get; set; }

  public Guid ControlGuid { get; set; }

  public string PolicyNo { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<AuthorityLimitCheck> AuthorityLimitCheckList { get; } = new BulkObservableCollection<AuthorityLimitCheck>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  public static AuthorityLimitCheckManager Create(
    Guid underwriterGuid,
    Guid quoteGuid,
    int ctrlNo,
    Guid controlGuid,
    string policyNo,
    ISupportNoteSystem sns,
    AuthorityLimitCheckType authorityLimitCheckType)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitCheckManager>(new object[7]
    {
      (object) underwriterGuid,
      (object) quoteGuid,
      (object) ctrlNo,
      (object) controlGuid,
      (object) policyNo,
      (object) sns,
      (object) authorityLimitCheckType
    });
  }

  public AuthorityLimitCheckManager(
    Guid underwriterGuid,
    Guid quoteGuid,
    int ctrlNo,
    Guid controlGuid,
    string policyNo,
    ISupportNoteSystem sns,
    AuthorityLimitCheckType authorityLimitCheckType)
  {
    this.QuoteGuid = quoteGuid;
    this.UnderwriterGuid = underwriterGuid;
    this.controlNo = ctrlNo;
    this.ControlGuid = controlGuid;
    this.PolicyNo = policyNo;
    this.supportNoteSystem = sns;
    this.RunAuthorityCheck(authorityLimitCheckType);
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
    {
      foreach (ChangeDetail delta in this.ChangeManager.DeltaList)
      {
        if (delta.ObjectThatChanged is AuthorityLimitCheck objectThatChanged)
        {
          object[] objArray = new object[6]
          {
            (object) (objectThatChanged.Approve ? " approved" : "unapproved"),
            (object) objectThatChanged.UnderwriterName,
            (object) objectThatChanged.DatabaseField,
            null,
            null,
            null
          };
          Decimal? fieldValue = objectThatChanged.FieldValue;
          ref Decimal? local = ref fieldValue;
          objArray[3] = (object) (local.HasValue ? local.GetValueOrDefault().ToString("F") : (string) null);
          objArray[4] = (object) objectThatChanged.MinValue;
          objArray[5] = (object) objectThatChanged.MaxValue;
          string action = string.Format("Authority Limit {0}, Underwriter {1}, Field {2} - {3}, Min Value {4}, Max Value {5}", objArray);
          DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spQuoteAuthorityLimitsCheckUpdate", new object[16 /*0x10*/]
          {
            (object) "@AuthorityLimitsCheckID",
            (object) objectThatChanged.AuthorityLimitsCheckID,
            (object) "@AuthorityLimitsUserID",
            (object) objectThatChanged.AuthorityLimitsUserID,
            (object) "@QuoteGuid",
            (object) objectThatChanged.QuoteGuid,
            (object) "@FieldValue",
            (object) objectThatChanged.FieldValue,
            (object) "@ApproveDate",
            (object) objectThatChanged.ApproveDate,
            (object) "@ApproveUserGuid",
            (object) objectThatChanged.ApproveUserGuid,
            (object) "@MinValueAtCheck",
            (object) objectThatChanged.MinValue,
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

  private void RunAuthorityCheck(AuthorityLimitCheckType authorityLimitCheckType)
  {
    ((Collection<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Clear();
    this.AuthorityLimitCheckList.AddRange((IEnumerable<AuthorityLimitCheck>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spQuoteAuthorityLimitsCheck", new object[6]
    {
      (object) "@UnderwriterGuid",
      (object) this.UnderwriterGuid,
      (object) "@quoteGuid",
      (object) this.QuoteGuid,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    }).AsEnumerable().Select<DataRow, AuthorityLimitCheck>((System.Func<DataRow, AuthorityLimitCheck>) (row => AuthorityLimitCheck.Create(this, row))));
    this.SendTask(authorityLimitCheckType);
  }

  public void RefreshAuthorityCheck(AuthorityLimitCheckType authorityLimitCheckType)
  {
    this.ChangeManager.SuspendMonitoring((Action) (() => this.RunAuthorityCheck(authorityLimitCheckType)));
  }

  private void SendTask(AuthorityLimitCheckType authorityLimitCheckType)
  {
    IEnumerable<AuthorityLimitCheck> authorityLimitChecks = (IEnumerable<AuthorityLimitCheck>) new List<AuthorityLimitCheck>();
    if (AuthorityLimitCheckManager.RunAuthorityCheckAtStartup)
    {
      authorityLimitChecks = ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a =>
      {
        if (!a.StopBind && !a.StopQuote && !a.StopBindSoft && !a.StopQuoteSoft || a.ApproveDate.HasValue)
          return false;
        return a.SendTask || a.SendTaskQuote;
      }));
    }
    else
    {
      switch (authorityLimitCheckType)
      {
        case AuthorityLimitCheckType.Bind:
          authorityLimitChecks = ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => (a.StopBind || a.StopBindSoft) && !a.ApproveDate.HasValue && a.SendTask));
          break;
        case AuthorityLimitCheckType.PrintQuote:
          authorityLimitChecks = ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => (a.StopQuote || a.StopQuoteSoft) && !a.ApproveDate.HasValue && a.SendTaskQuote));
          break;
      }
    }
    foreach (AuthorityLimitCheck authorityLimitCheck in authorityLimitChecks)
    {
      Guid? sendTaskUserGuid = authorityLimitCheck.SendTaskUserGuid;
      if (sendTaskUserGuid.HasValue && !AuthorityLimitsTaskHistory.HasTaskBeenSent(this.QuoteGuid, authorityLimitCheck.FieldValue, authorityLimitCheck.MinValue, authorityLimitCheck.MaxValue, authorityLimitCheck.AuthorityLimitsUserID, authorityLimitCheckType))
      {
        string str = "Values found outside Authority Limit:";
        if (!AuthorityLimitCheckManager.RunAuthorityCheckAtStartup)
        {
          switch (authorityLimitCheckType)
          {
            case AuthorityLimitCheckType.Bind:
              str += "  (at Bind)";
              break;
            case AuthorityLimitCheckType.PrintQuote:
              str += "  (at Print Quote)";
              break;
          }
        }
        string[] strArray = new string[10]
        {
          str,
          Environment.NewLine,
          "Underwriter ",
          authorityLimitCheck.UnderwriterName,
          " is writing ",
          null,
          null,
          null,
          null,
          null
        };
        Decimal? fieldValue = authorityLimitCheck.FieldValue;
        ref Decimal? local = ref fieldValue;
        strArray[5] = local.HasValue ? local.GetValueOrDefault().ToString("F") : (string) null;
        strArray[6] = " ";
        strArray[7] = authorityLimitCheck.DatabaseField;
        strArray[8] = " - ";
        strArray[9] = authorityLimitCheck.Cell;
        string body = string.Concat(strArray) + $"{Environment.NewLine}Min Value:  {authorityLimitCheck.MinValue}" + $"{Environment.NewLine}Max Value:  {authorityLimitCheck.MaxValue}";
        AuthorityLimitsTaskHistory limitsTaskHistory1 = new AuthorityLimitsTaskHistory();
        limitsTaskHistory1.AuthortityLimitsUserID = authorityLimitCheck.AuthorityLimitsUserID;
        limitsTaskHistory1.QuoteGuid = this.QuoteGuid;
        fieldValue = authorityLimitCheck.FieldValue;
        limitsTaskHistory1.FieldValue = fieldValue.Value;
        long? nullable = authorityLimitCheck.MinValue;
        limitsTaskHistory1.MinValue = nullable.Value;
        nullable = authorityLimitCheck.MaxValue;
        limitsTaskHistory1.MaxValue = nullable.Value;
        limitsTaskHistory1.CheckType = authorityLimitCheckType;
        AuthorityLimitsTaskHistory limitsTaskHistory2 = limitsTaskHistory1;
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("AuthorityNote.SendAutomatically", true))
        {
          Guid[] guidArray1 = new Guid[1];
          sendTaskUserGuid = authorityLimitCheck.SendTaskUserGuid;
          guidArray1[0] = sendTaskUserGuid.Value;
          Guid[] guidArray2 = guidArray1;
          NoteSupportCache noteSupportCache = new NoteSupportCache(this.ControlGuid, "Policy: " + this.PolicyNo, "Policy: " + this.PolicyNo, "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, this.ControlGuid);
          Guid boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(Note_System.NonInteractiveNoteManipulator.SystemEntity.IMS, $"Authority Approval needed for Control No. {this.controlNo}", body, guidArray2, this.supportNoteSystem, guidArray2, DateTime.Now, DateTime.Now);
          limitsTaskHistory2.NoteGuid = boundNote;
          limitsTaskHistory2.Update();
        }
        else
        {
          string subject = $"Authority Approval needed for Control No. {this.controlNo}";
          string msg = body;
          sendTaskUserGuid = authorityLimitCheck.SendTaskUserGuid;
          Guid recipient = sendTaskUserGuid.Value;
          AuthorityLimitsTaskHistory authorityLimitsTaskHistory = limitsTaskHistory2;
          this.OpenNoteBeforeSend(subject, msg, recipient, authorityLimitsTaskHistory);
        }
      }
    }
    IEnumerable<AuthorityLimitCheck> source = (IEnumerable<AuthorityLimitCheck>) new List<AuthorityLimitCheck>();
    if (AuthorityLimitCheckManager.RunAuthorityCheckAtStartup)
    {
      source = ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => (a.StopBind || a.StopQuote || a.StopBindSoft || a.StopQuoteSoft) && !a.ApproveDate.HasValue && (a.SendTask || a.SendTaskQuote) && a.ApprovalDaysOverage.GetValueOrDefault() == 30));
    }
    else
    {
      switch (authorityLimitCheckType)
      {
        case AuthorityLimitCheckType.Bind:
          source = ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => (a.StopBind || a.StopBindSoft) && !a.ApproveDate.HasValue && a.SendTask && a.ApprovalDaysOverage.GetValueOrDefault() == 30));
          break;
        case AuthorityLimitCheckType.PrintQuote:
          source = ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => (a.StopQuote || a.StopQuoteSoft) && !a.ApproveDate.HasValue && a.SendTaskQuote && a.ApprovalDaysOverage.GetValueOrDefault() == 30));
          break;
      }
    }
    if (source.Count<AuthorityLimitCheck>() <= 0)
      return;
    foreach (AuthorityLimitCheck authorityLimitCheck in source)
    {
      Guid? sendTaskUserGuid = authorityLimitCheck.SendTaskUserGuid;
      Guid guid = sendTaskUserGuid.Value;
      if (!AuthorityLimitsTaskHistory.HasOverageTaskBeenSent(this.QuoteGuid, authorityLimitCheck.FieldValue, authorityLimitCheck.MinValue, authorityLimitCheck.MaxValue, authorityLimitCheck.AuthorityLimitsUserID, 30, authorityLimitCheckType))
      {
        string str = $"Approval occurred more than 30 days ago.{Environment.NewLine}Values found outside Authority Limit:";
        if (!AuthorityLimitCheckManager.RunAuthorityCheckAtStartup)
        {
          switch (authorityLimitCheckType)
          {
            case AuthorityLimitCheckType.Bind:
              str += "  (at Bind)";
              break;
            case AuthorityLimitCheckType.PrintQuote:
              str += "  (at Print Quote)";
              break;
          }
        }
        string[] strArray = new string[8]
        {
          str,
          Environment.NewLine,
          "Underwriter ",
          authorityLimitCheck.UnderwriterName,
          " is writing ",
          null,
          null,
          null
        };
        Decimal? fieldValue = authorityLimitCheck.FieldValue;
        ref Decimal? local = ref fieldValue;
        strArray[5] = local.HasValue ? local.GetValueOrDefault().ToString("F") : (string) null;
        strArray[6] = " ";
        strArray[7] = authorityLimitCheck.DatabaseField;
        string body = string.Concat(strArray) + $"{Environment.NewLine}Min Value:  {authorityLimitCheck.MinValue}" + $"{Environment.NewLine}Max Value:  {authorityLimitCheck.MaxValue}";
        AuthorityLimitsTaskHistory limitsTaskHistory = new AuthorityLimitsTaskHistory()
        {
          AuthortityLimitsUserID = authorityLimitCheck.AuthorityLimitsUserID,
          QuoteGuid = this.QuoteGuid,
          FieldValue = authorityLimitCheck.FieldValue.Value,
          MinValue = authorityLimitCheck.MinValue.Value,
          MaxValue = authorityLimitCheck.MaxValue.Value,
          ApprovalDaysOverage = new int?(30),
          CheckType = authorityLimitCheckType
        };
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("AuthorityNote.SendAutomatically", true))
        {
          Guid[] guidArray3 = new Guid[1];
          sendTaskUserGuid = authorityLimitCheck.SendTaskUserGuid;
          guidArray3[0] = sendTaskUserGuid.Value;
          Guid[] guidArray4 = guidArray3;
          NoteSupportCache noteSupportCache = new NoteSupportCache(this.ControlGuid, "Policy: " + this.PolicyNo, "Policy: " + this.PolicyNo, "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, this.ControlGuid);
          Guid boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(Note_System.NonInteractiveNoteManipulator.SystemEntity.IMS, $"Authority Approval needed for Control No. {this.controlNo}", body, guidArray4, this.supportNoteSystem, guidArray4, DateTime.Now, DateTime.Now);
          limitsTaskHistory.NoteGuid = boundNote;
          limitsTaskHistory.Update();
        }
        else
        {
          string subject = $"Authority Approval needed for Control No. {this.controlNo}";
          string msg = body;
          sendTaskUserGuid = authorityLimitCheck.SendTaskUserGuid;
          Guid recipient = sendTaskUserGuid.Value;
          AuthorityLimitsTaskHistory authorityLimitsTaskHistory = limitsTaskHistory;
          this.OpenNoteBeforeSend(subject, msg, recipient, authorityLimitsTaskHistory);
        }
      }
    }
  }

  public bool CanBindHard(bool isQuoteBound)
  {
    return !isQuoteBound && ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopBind)).Count<AuthorityLimitCheck>() == ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopBind && a.ApproveDate.HasValue)).Count<AuthorityLimitCheck>();
  }

  public bool CanPrintQuoteHard()
  {
    return ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopQuote)).Count<AuthorityLimitCheck>() == ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopQuote && a.ApproveDate.HasValue)).Count<AuthorityLimitCheck>();
  }

  public bool CanBindSoft(bool isQuoteBound)
  {
    return !isQuoteBound && ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopBindSoft)).Count<AuthorityLimitCheck>() == ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopBindSoft && a.ApproveDate.HasValue)).Count<AuthorityLimitCheck>();
  }

  public bool CanPrintQuoteSoft()
  {
    return ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopQuoteSoft)).Count<AuthorityLimitCheck>() == ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopQuoteSoft && a.ApproveDate.HasValue)).Count<AuthorityLimitCheck>();
  }

  public bool ShowNotification(bool isQuoteBound)
  {
    return ((!this.CanBindHard(isQuoteBound) ? 1 : (!this.CanBindSoft(isQuoteBound) ? 1 : 0)) | (!this.CanPrintQuoteHard() ? (true ? 1 : 0) : (!this.CanPrintQuoteSoft() ? 1 : 0))) != 0;
  }

  public bool ShowBindMenu(bool isQuoteBound)
  {
    return !AuthorityLimitCheckManager.RunAuthorityCheckAtStartup || this.CanBindHard(isQuoteBound);
  }

  public bool ShowQuotePrintMenu()
  {
    return !AuthorityLimitCheckManager.RunAuthorityCheckAtStartup || this.CanPrintQuoteHard();
  }

  public bool HasApprovalItems()
  {
    return ((IEnumerable<AuthorityLimitCheck>) this.AuthorityLimitCheckList).Where<AuthorityLimitCheck>((System.Func<AuthorityLimitCheck, bool>) (a => a.StopQuote || a.StopBind || a.StopQuoteSoft || a.StopBindSoft)).Count<AuthorityLimitCheck>() > 0;
  }

  private void OpenNoteBeforeSend(
    string subject,
    string msg,
    Guid recipient,
    AuthorityLimitsTaskHistory authorityLimitsTaskHistory)
  {
    (ObjectFactory.Instance.CreateObjectEX(typeof (NoteOverrideInformation), (object) "attaching authority limit note", (object) new object[6]
    {
      (object) new NoteSupportCache(this.ControlGuid, "Policy: " + this.PolicyNo, "Policy: " + this.PolicyNo, "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, this.ControlGuid),
      (object) true,
      (object) subject,
      (object) msg,
      (object) recipient,
      (object) authorityLimitsTaskHistory
    }) as NoteOverrideInformation).PerformOverrideAction();
  }
}

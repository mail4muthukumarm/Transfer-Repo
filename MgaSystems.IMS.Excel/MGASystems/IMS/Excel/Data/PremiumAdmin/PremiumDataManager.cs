// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.PremiumAdmin.PremiumDataManager
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.ExtensionMethods;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MGASystems.IMS.Policies.PolicyDetail;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Data;
using System.Xml;

#nullable disable
namespace MgaSystems.IMS.Excel.Data.PremiumAdmin;

public class PremiumDataManager : ValidatingDependentBindingObject, ISubmittable
{
  private readonly Guid quoteGuid;

  public bool IsBound { get; }

  [TrackChanges]
  public BulkObservableCollection<OptionPremium> OptionPremiums { get; } = new BulkObservableCollection<OptionPremium>();

  [Required]
  public string Reason { get; set; }

  public XmlDataProvider XmlLogData { get; } = new XmlDataProvider()
  {
    IsAsynchronous = false
  };

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges
  {
    get
    {
      ChangeManager changeManager = this.ChangeManager;
      return changeManager != null && changeManager.HasChanges;
    }
  }

  public bool IsAdmin => CurrentUser.IsMGADeveloper;

  public PremiumDataManager(Guid quoteGuid)
  {
    this.quoteGuid = quoteGuid;
    this.OptionPremiums.AddRange((IEnumerable<OptionPremium>) DefaultDatabase.ExecuteDataTable("ExcelRating_FetchOptionPremiums", new object[2]
    {
      (object) "@QuoteGUID",
      (object) quoteGuid
    }).AsEnumerable().Select<DataRow, OptionPremium>((System.Func<DataRow, OptionPremium>) (row => OptionPremium.Create(row))));
    this.RefreshChangeLog(quoteGuid);
    this.ReapplyPriorChanges = this.InitReapplyPriorChangesCommand();
    this.IsBound = new Quote(quoteGuid).IsBound;
    if (this.IsBound)
      return;
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
    ((DependentBindingObject) this).UseChangeMonitor = true;
  }

  private void RefreshChangeLog(Guid quoteGuid)
  {
    string str = DefaultDatabase.ExecuteScalar<string>("ExcelRating_FetchManualPremiumChangeLog", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    });
    if (string.IsNullOrWhiteSpace(str))
      return;
    XmlDataProviderExtensions.LoadXml(this.XmlLogData, str);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    try
    {
      if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      {
        if (!this.IsBound)
        {
          List<ChangeDetail> list = this.ChangeManager.DeltaList.ToList<ChangeDetail>();
          DatabaseCommands.SubmitAndLogChanges(this.ChangeManager, this.quoteGuid);
          foreach (ChangeDetail changeDetail in list)
            DefaultDatabase.ExecuteNonQuery("ExcelRating_InsertManualPremiumChangeLogEntry", new object[12]
            {
              (object) "@UserID",
              (object) CurrentUser.Instance.UserID,
              (object) "@MachineName",
              (object) Environment.MachineName,
              (object) "@PremiumID",
              (object) ((OptionPremium) changeDetail.ObjectThatChanged).PremiumID,
              (object) "@OldValue",
              changeDetail.PriorValue,
              (object) "@NewValue",
              changeDetail.Value,
              (object) "@Reason",
              (object) this.Reason
            });
          foreach (OptionPremium optionPremium in (Collection<OptionPremium>) this.OptionPremiums)
            DefaultDatabase.ExecuteNonQuery("spAutoApplyFees", new object[2]
            {
              (object) "@quoteOptionGuid",
              (object) optionPremium.QuoteOptionGuid
            });
          foreach (frmPolicyDetail frmPolicyDetail in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>().Where<frmPolicyDetail>((System.Func<frmPolicyDetail, bool>) (detail => detail.Quote.QuoteGuid == this.quoteGuid)))
            frmPolicyDetail.RefreshPremiums();
          this.RefreshChangeLog(this.quoteGuid);
        }
      }
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleError(ex, false);
    }
    return validationResultList;
  }

  public RelayCommand LaunchSSMSCommand { get; } = SSMSInterop.CreateOpenSSMSCommand();

  public RelayCommand CopySSMSPasswordToClipboardCommand { get; } = SSMSInterop.CreateCopySSMSPasswordToClipboardCommand();

  public bool CanCopySSMSPasswordToClipboard { get; } = SSMSInterop.CanCopySSMSPasswordToClipboard;

  public RelayCommand ReapplyPriorChanges { get; }

  private RelayCommand InitReapplyPriorChangesCommand()
  {
    return new RelayCommand((Action) (() =>
    {
      foreach (var data in this.XmlLogData.Document.SelectNodes("//LogEntry").Cast<XmlElement>().Select(logEntry => new
      {
        ID = int.Parse(logEntry.Attributes["ID"].Value),
        NewValue = Decimal.Parse(logEntry.Attributes["newvalue"].Value),
        PremiumID = int.Parse(logEntry.Attributes["premiumid"].Value)
      }).OrderBy(item => item.ID))
      {
        var logEntry = data;
        OptionPremium optionPremium1 = ((IEnumerable<OptionPremium>) this.OptionPremiums).SingleOrDefault<OptionPremium>((System.Func<OptionPremium, bool>) (optionPremium => optionPremium.PremiumID == logEntry.PremiumID));
        if (optionPremium1 != null)
          optionPremium1.Premium = logEntry.NewValue;
      }
    }), (Func<bool>) (() => this.XmlLogData?.Document?.SelectNodes("//LogEntry")?.Count.GetValueOrDefault() > 0));
  }
}

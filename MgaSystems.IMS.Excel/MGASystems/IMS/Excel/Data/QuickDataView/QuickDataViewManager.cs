// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.QuickDataView.QuickDataViewManager
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MGASystems.IMS.Policies.PolicyDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.Excel.Data.QuickDataView;

public abstract class QuickDataViewManager : DependentBindingObject, ISubmittable
{
  private readonly Guid firstQuoteOptionGuid;
  private readonly Guid quoteGuid;
  private readonly string defaultPremiumQuery;

  [NotificationProperty]
  public virtual bool ViewSSMSPasswordButtonVisible { get; set; }

  [NotificationProperty]
  public virtual bool ViewOpenSSMSButtonVisible { get; set; }

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  [TrackChanges]
  public BulkObservableCollection<QuoteOption> QuoteOptions { get; } = new BulkObservableCollection<QuoteOption>();

  public bool HasChanges
  {
    get
    {
      ChangeManager changeManager = this.ChangeManager;
      return changeManager != null && changeManager.HasChanges;
    }
  }

  public string RatingProcedure { get; }

  public bool HasManualPremiumChanges { get; }

  public string RatingProcedureWithFirstOption { get; }

  public string FactorSetInformation { get; }

  [NotificationProperty]
  public virtual bool IncludeProRataData { get; set; }

  [DependsOn("IncludeProRataData")]
  public virtual string PremiumQuery
  {
    get
    {
      return !this.IncludeProRataData ? this.defaultPremiumQuery : this.defaultPremiumQuery.Replace("from ", $", pd.* {Environment.NewLine}from ").Replace("where q.", $"left outer join tblQuoteProrataDetail pd on pd.QuoteGuid = q.QuoteGUID {Environment.NewLine}where q.");
    }
  }

  [DependsOn("PremiumQuery")]
  public DataView DefaultPremiumData
  {
    get
    {
      DataTable table = DefaultDatabase.ExecuteDataTable(CommandType.Text, this.PremiumQuery);
      return table == null ? (DataView) null : table.AsDataView();
    }
  }

  public RelayCommand LaunchSSMSCommand { get; } = SSMSInterop.CreateOpenSSMSCommand();

  public RelayCommand CopySSMSPasswordToClipboardCommand { get; } = SSMSInterop.CreateCopySSMSPasswordToClipboardCommand();

  public bool CanCopySSMSPasswordToClipboard { get; } = SSMSInterop.CanCopySSMSPasswordToClipboard;

  public RelayCommand RerunRatingProcCommand { get; }

  public static QuickDataViewManager Create(Guid quoteGuid)
  {
    return NotifyProxyTypeManager.Allocate<QuickDataViewManager>(new object[1]
    {
      (object) quoteGuid
    });
  }

  public QuickDataViewManager(Guid quoteGuid)
  {
    this.quoteGuid = quoteGuid;
    var data = DefaultDatabase.ExecuteDataTable("ExcelRating_FetchDefaultPremiumData", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    }).AsEnumerable().Select(row => new
    {
      DefaultPremiumQuery = row.Field<string>("DefaultPremiumQuery"),
      RatingProcName = row.Field<string>("RatingProcName"),
      FactorSetInformation = row.Field<string>(nameof (FactorSetInformation)),
      FirstOptionGuid = row.Field<Guid?>("FirstOptionGuid") ?? Guid.Empty
    }).Single();
    this.firstQuoteOptionGuid = data.FirstOptionGuid;
    this.RatingProcedure = data.RatingProcName;
    this.RatingProcedureWithFirstOption = $"{data.RatingProcName} '{this.firstQuoteOptionGuid.ToString()}'";
    this.defaultPremiumQuery = data.DefaultPremiumQuery;
    this.FactorSetInformation = data.FactorSetInformation;
    this.HasManualPremiumChanges = !string.IsNullOrWhiteSpace(DefaultDatabase.ExecuteScalar<string>("ExcelRating_FetchManualPremiumChangeLog", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    }));
    this.QuoteOptions.AddRange((IEnumerable<QuoteOption>) DefaultDatabase.ExecuteDataTable("ExcelRating_FetchQuoteOptionInformation", new object[2]
    {
      (object) "@QuoteGUID",
      (object) quoteGuid
    }).AsEnumerable().Select<DataRow, QuoteOption>((System.Func<DataRow, QuoteOption>) (row => QuoteOption.Create(row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
    this.RerunRatingProcCommand = new RelayCommand((Action) (() =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery(this.RatingProcedure, new object[2]
        {
          (object) "@QuoteOptionGuid",
          (object) this.firstQuoteOptionGuid
        });
        this.RefreshPolicyDetail();
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }));
  }

  private void RefreshPolicyDetail()
  {
    foreach (frmPolicyDetail frmPolicyDetail in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>().Where<frmPolicyDetail>((System.Func<frmPolicyDetail, bool>) (detail => detail.Quote.QuoteGuid == this.quoteGuid)))
      frmPolicyDetail.RefreshPremiums();
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    try
    {
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager, this.quoteGuid);
      this.RefreshPolicyDetail();
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleError(ex, false);
    }
    return validationResultList;
  }
}

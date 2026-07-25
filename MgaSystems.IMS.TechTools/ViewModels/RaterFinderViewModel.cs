// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.ViewModels.RaterFinderViewModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.Policies;
using MgaSystems.IMS.TechTools.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.TechTools.ViewModels;

public abstract class RaterFinderViewModel : BindingObject
{
  public virtual ObservableCollection<RaterModel> Raters { get; set; } = new ObservableCollection<RaterModel>();

  public virtual ObservableCollection<BoundStatusModel> BoundStatuses { get; set; } = new ObservableCollection<BoundStatusModel>();

  public virtual ObservableCollection<QuoteStatusModel> QuoteStatuses { get; set; } = new ObservableCollection<QuoteStatusModel>();

  [NotificationProperty]
  public virtual ObservableCollection<QuoteDetailModel> QuoteDetails { get; set; } = new ObservableCollection<QuoteDetailModel>();

  public virtual int RatingTypeId { get; set; } = -1;

  public virtual DateTime DateFrom { get; set; } = DateTime.Now;

  public virtual DateTime DateTo { get; set; } = DateTime.Now;

  public virtual int BoundStatusId { get; set; }

  public virtual int QuoteStatusId { get; set; }

  [NotificationProperty]
  public virtual bool IsBusy { get; set; }

  [NotificationProperty]
  public virtual bool IsAnyEnabled { get; set; } = true;

  [NotificationProperty]
  public virtual bool IsByBoundEnabled { get; set; }

  [NotificationProperty]
  public virtual bool IsByQuoteStatusDescriptionEnabled { get; set; }

  public static RaterFinderViewModel Create()
  {
    return NotifyProxyTypeManager.Allocate<RaterFinderViewModel>();
  }

  public RaterFinderViewModel()
  {
    this.GetRatersCommand.Execute((object) this);
    this.GetQuoteStatusesCommand.Execute((object) this);
    this.PopulateBoundStatuses();
  }

  private void PopulateBoundStatuses()
  {
    this.BoundStatuses.Add(new BoundStatusModel(0, "Not Bound"));
    this.BoundStatuses.Add(new BoundStatusModel(1, "Bound"));
  }

  private async Task RefreshQuoteDetailsAsync()
  {
    this.IsBusy = true;
    this.QuoteDetails.Clear();
    try
    {
      ArrayList lstNamedParams = new ArrayList()
      {
        (object) "@DateFrom",
        (object) this.DateFrom,
        (object) "@DateTo",
        (object) this.DateTo
      };
      if (this.RatingTypeId != -1)
        lstNamedParams.AddRange((ICollection) new object[2]
        {
          (object) "@RatingTypeId",
          (object) this.RatingTypeId
        });
      if (this.IsByBoundEnabled)
        lstNamedParams.AddRange((ICollection) new object[2]
        {
          (object) "@Bound",
          (object) this.BoundStatusId
        });
      if (this.IsByQuoteStatusDescriptionEnabled)
        lstNamedParams.AddRange((ICollection) new object[2]
        {
          (object) "@QuoteStatusId",
          (object) this.QuoteStatusId
        });
      foreach (DataRow row in (InternalDataCollectionBase) (await Task.Run<DataTable>((Func<DataTable>) (() => DefaultDatabase.ExecuteDataTable("dbo.GetQuoteDetailsByRater", lstNamedParams.ToArray())))).Rows)
        this.QuoteDetails.Add(new QuoteDetailModel(ExtensionsMethods.FieldAs<int>(row, "QuoteDetailId", DataRowVersion.Current), ExtensionsMethods.FieldAs<Guid>(row, "QuoteGuid", DataRowVersion.Current), ExtensionsMethods.FieldAs<int>(row, "ControlNumber", DataRowVersion.Current), ExtensionsMethods.FieldAs<int>(row, "RatingTypeId", DataRowVersion.Current), ExtensionsMethods.FieldAs<string>(row, "RatingType", DataRowVersion.Current), ExtensionsMethods.FieldAs<int>(row, "QuoteStatusId", DataRowVersion.Current), ExtensionsMethods.FieldAs<string>(row, "QuoteStatus", DataRowVersion.Current), ExtensionsMethods.FieldAs<bool>(row, "IsBound", DataRowVersion.Current)));
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString(), "Error getting raters");
    }
    finally
    {
      this.IsBusy = false;
    }
  }

  private async Task RefreshQuoteStatusesAsync()
  {
    this.IsBusy = true;
    this.QuoteStatuses.Clear();
    try
    {
      foreach (QuoteStatusModel quoteStatusModel in await Task.Run<List<QuoteStatusModel>>((Func<List<QuoteStatusModel>>) (() => DefaultDatabase.ExecuteMappedObjectSelectMultiple<QuoteStatusModel>((System.Func<DataRow, QuoteStatusModel>) (dr => QuoteStatusModel.Create(dr)), "ORDER BY Description", Array.Empty<object>()))))
        this.QuoteStatuses.Add(quoteStatusModel);
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString(), "Error getting quote statuses");
    }
    finally
    {
      this.IsBusy = false;
    }
  }

  private async Task RefreshRatersAsync()
  {
    this.IsBusy = true;
    this.Raters.Clear();
    try
    {
      foreach (RaterModel raterModel in await Task.Run<List<RaterModel>>((Func<List<RaterModel>>) (() => DefaultDatabase.ExecuteMappedObjectSelectMultiple<RaterModel>((System.Func<DataRow, RaterModel>) (dr => RaterModel.Create(dr)), "ORDER BY RatingType", Array.Empty<object>()))))
        this.Raters.Add(raterModel);
      this.Raters.Insert(0, new RaterModel(-1, "Any"));
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString(), "Error getting raters");
    }
    finally
    {
      this.IsBusy = false;
    }
  }

  private async Task OpenPolicyDetailWindowAsync(int controlNumber)
  {
    this.IsBusy = true;
    try
    {
      await Task.Run((Action) (() => frmControlNumberJump.LaunchAppropriateQuoteForm(controlNumber)));
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString(), "Error opening policy detail window for this control number");
    }
    finally
    {
      this.IsBusy = false;
    }
  }

  public RelayCommand<int> OpenPolicyDetailWindowCommand
  {
    get
    {
      return new RelayCommand<int>((Action<int>) (controlNumber =>
      {
        try
        {
          frmControlNumberJump.LaunchAppropriateQuoteForm(controlNumber);
        }
        catch (Exception ex)
        {
          ErrorHandler.SilentHandleError(ex);
          int num = (int) MessageBox.Show(ex.ToString(), "Error opening policy detail window for this control number");
        }
      }));
    }
  }

  public RelayCommand GetRatersCommand
  {
    get => new RelayCommand((Action) (async () => await this.RefreshRatersAsync()));
  }

  public RelayCommand GetQuoteStatusesCommand
  {
    get => new RelayCommand((Action) (async () => await this.RefreshQuoteStatusesAsync()));
  }

  public RelayCommand GetQuoteDetailsCommand
  {
    get => new RelayCommand((Action) (async () => await this.RefreshQuoteDetailsAsync()));
  }
}

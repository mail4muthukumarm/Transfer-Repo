// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportSummaryViewModel
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.Ims.Fortegra.PolicyImport.Data;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportDetail;
using MgaSystems.Ims.Fortegra.PolicyImport.UI.PreprocessErrorViewer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI;

public abstract class PolicyImportSummaryViewModel : BindingObject, ISubmittable
{
  private readonly IWinMsgBoxService msgBoxSvc;

  [NotificationProperty]
  public virtual PolicyImportDataManager PolicyImportDataManager { get; set; }

  [NotificationProperty]
  public virtual ImportSource SelectedImportSource { get; set; }

  [NotificationProperty]
  public virtual ImportLogItem SelectedImportLogItem { get; set; }

  [NotificationProperty]
  public virtual bool IsBusy { get; set; }

  internal static PolicyImportSummaryViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<PolicyImportSummaryViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public PolicyImportSummaryViewModel(IWinMsgBoxService msgBoxService)
  {
    this.msgBoxSvc = msgBoxService;
  }

  public void Initialize() => this.PolicyImportDataManager = PolicyImportDataManager.Create();

  public RelayCommand RefreshImportLogList
  {
    get
    {
      return new RelayCommand((Action) (async () =>
      {
        try
        {
          this.IsBusy = true;
          await this.PolicyImportDataManager.RefreshImportLogItemListAsync(this.SelectedImportSource.ID);
        }
        catch (Exception ex)
        {
          ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
        }
        finally
        {
          this.IsBusy = false;
        }
      }), (Func<bool>) (() => !this.PolicyImportDataManager.RetrievingSummaryData));
    }
  }

  public RelayCommand ShowImportScreen
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        ((Collection<ImportLogDetailItem>) this.PolicyImportDataManager.CurrentImportDetailList).Clear();
        PolicyImportDetailView importDetailView = MgaMdiChild.Create<PolicyImportDetailView>(new object[4]
        {
          (object) new WinMsgBoxService(),
          (object) this.PolicyImportDataManager,
          (object) this.SelectedImportSource,
          (object) true
        });
        importDetailView.Form.MdiParent = MDIControls.Instance.MDIParent;
        importDetailView.Form.Show();
      }), (Func<bool>) (() => true));
    }
  }

  public RelayCommand ShowExistingImport
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        PolicyImportDetailView importDetailView = MgaMdiChild.Create<PolicyImportDetailView>(new object[5]
        {
          (object) new WinMsgBoxService(),
          (object) this.PolicyImportDataManager,
          (object) this.SelectedImportSource,
          (object) false,
          (object) this.SelectedImportLogItem.ID
        });
        importDetailView.Form.MdiParent = MDIControls.Instance.MDIParent;
        importDetailView.Form.Show();
      }), (Func<bool>) (() => true));
    }
  }

  internal async void ShowImportPreprocessErrors(object sender, RoutedEventArgs e)
  {
    try
    {
      await this.PolicyImportDataManager.RefreshImportPreprocessErrorListAsync(Utility.ImportLogIDsToXML(this.SelectedImportLogItem.ID));
      if (((IEnumerable<Form>) MDIControls.Instance.MDIParent.MdiChildren).Where<Form>((Func<Form, bool>) (x => x.Text.Equals("Preprocess Errors"))).Count<Form>() != 0)
        return;
      PreprocessErrorViewerView preprocessErrorViewerView = MgaMdiChild.Create<PreprocessErrorViewerView>(new object[1]
      {
        (object) this.PolicyImportDataManager
      });
      preprocessErrorViewerView.Form.MdiParent = MDIControls.Instance.MDIParent;
      preprocessErrorViewerView.Form.Show();
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
    }
  }

  public List<ValidationResult> SubmitChanges() => this.PolicyImportDataManager.SubmitChanges();

  public bool HasChanges
  {
    get => this.PolicyImportDataManager != null && this.PolicyImportDataManager.HasChanges;
  }
}

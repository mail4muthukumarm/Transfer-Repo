// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.ViewModels.CheckFinderViewModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.Accounting.Banking.Forms;
using MGASystems.IMS.Accounting.Core.Forms;
using MgaSystems.IMS.TechTools.Enums;
using MgaSystems.IMS.TechTools.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.TechTools.ViewModels;

public abstract class CheckFinderViewModel : BindingObject
{
  [NotificationProperty]
  public virtual ObservableCollection<CheckModel> Checks { get; set; } = new ObservableCollection<CheckModel>();

  [NotificationProperty]
  public virtual ObservableCollection<CheckPrinterSettingsModel> CheckPrinterSettings { get; set; } = new ObservableCollection<CheckPrinterSettingsModel>();

  private CheckModel SelectedCheck { get; set; }

  public virtual int? PrinterId { get; set; }

  public virtual DateTime DateFrom { get; set; } = DateTime.Now;

  public virtual DateTime DateTo { get; set; } = DateTime.Now;

  public virtual bool IsInvoiceChecked { get; set; } = true;

  public virtual bool IsClaimsChecked { get; set; } = true;

  public virtual bool IsOperatingChecked { get; set; } = true;

  [NotificationProperty]
  public virtual bool IsBusy { get; set; }

  public static CheckFinderViewModel Create()
  {
    return NotifyProxyTypeManager.Allocate<CheckFinderViewModel>();
  }

  public async Task InitializeAsync() => await this.RefreshCheckPrinterSettingsAsync();

  private async Task RefreshCheckPrinterSettingsAsync()
  {
    this.IsBusy = true;
    this.PrinterId = new int?();
    this.CheckPrinterSettings.Clear();
    try
    {
      foreach (CheckPrinterSettingsModel printerSettingsModel in await Task.Run<List<CheckPrinterSettingsModel>>((Func<List<CheckPrinterSettingsModel>>) (() => DefaultDatabase.ExecuteMappedObjectSelectMultiple<CheckPrinterSettingsModel>((System.Func<DataRow, CheckPrinterSettingsModel>) (setting => CheckPrinterSettingsModel.Create(setting))))))
        this.CheckPrinterSettings.Add(printerSettingsModel);
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString(), "Error getting printer settings");
    }
    finally
    {
      this.IsBusy = false;
    }
  }

  private async Task RefreshChecksAsync()
  {
    this.IsBusy = true;
    this.Checks.Clear();
    try
    {
      foreach (DataRow row in (InternalDataCollectionBase) (await Task.Run<DataTable>((Func<DataTable>) (() => DefaultDatabase.ExecuteDataTable("dbo.GetChecksByType", new object[10]
      {
        (object) "@DateFrom",
        (object) this.DateFrom,
        (object) "@DateTo",
        (object) this.DateTo,
        (object) "@GetInvoiceChecks",
        (object) this.IsInvoiceChecked,
        (object) "@GetClaimsChecks",
        (object) this.IsClaimsChecked,
        (object) "@GetOperatingChecks",
        (object) this.IsOperatingChecked
      })))).Rows)
      {
        CheckType result = CheckType.Other;
        Enum.TryParse<CheckType>(ExtensionsMethods.FieldAs<string>(row, "CheckType", DataRowVersion.Current), out result);
        this.Checks.Add(new CheckModel(ExtensionsMethods.FieldAs<int>(row, "TransactNum", DataRowVersion.Current), ExtensionsMethods.FieldAs<int>(row, "CheckNum", DataRowVersion.Current), ExtensionsMethods.FieldAs<DateTime>(row, "CheckDate", DataRowVersion.Current), ExtensionsMethods.FieldAs<string>(row, "PayeeName", DataRowVersion.Current), result, ExtensionsMethods.FieldAs<int>(row, "GLAcctID", DataRowVersion.Current), ExtensionsMethods.FieldAs<DateTime?>(row, "PrintDate", DataRowVersion.Current), ExtensionsMethods.FieldAs<Decimal>(row, "amount", DataRowVersion.Current)));
      }
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.ToString(), "Error getting checks");
    }
    finally
    {
      this.IsBusy = false;
    }
  }

  public RelayCommand<int> ReprintCheckCommand
  {
    get
    {
      return new RelayCommand<int>((Action<int>) (transactNum =>
      {
        if (!this.PrinterId.HasValue)
        {
          int num1 = (int) MessageBox.Show("Please select a check printer");
        }
        else
        {
          this.SelectedCheck = this.Checks.Select<CheckModel, CheckModel>((System.Func<CheckModel, CheckModel>) (c => c)).Where<CheckModel>((System.Func<CheckModel, bool>) (c => c.TransactNum == transactNum)).First<CheckModel>();
          CheckPrinterSettingsModel printerSettingsModel = this.CheckPrinterSettings.Select<CheckPrinterSettingsModel, CheckPrinterSettingsModel>((System.Func<CheckPrinterSettingsModel, CheckPrinterSettingsModel>) (cps => cps)).Where<CheckPrinterSettingsModel>((System.Func<CheckPrinterSettingsModel, bool>) (cps =>
          {
            int printerId3 = cps.PrinterId;
            int? printerId4 = this.PrinterId;
            int valueOrDefault = printerId4.GetValueOrDefault();
            return printerId3 == valueOrDefault & printerId4.HasValue;
          })).First<CheckPrinterSettingsModel>();
          int num2 = (int) new frmReprintChecks(this.SelectedCheck.CheckNum, this.SelectedCheck.GLAcctID, printerSettingsModel.CheckPrinterName, printerSettingsModel.CheckPrinterSettings, printerSettingsModel.CheckDetailName, printerSettingsModel.CheckDetailSettings).ShowDialog();
        }
      }));
    }
  }

  public RelayCommand ConfigureAccountingPrintersCommand
  {
    get
    {
      return new RelayCommand((Action) (async () =>
      {
        int num = (int) new formAccountingPrinters().ShowDialog();
        await this.RefreshCheckPrinterSettingsAsync();
      }));
    }
  }

  public RelayCommand GetChecksCommand
  {
    get => new RelayCommand((Action) (async () => await this.RefreshChecksAsync()));
  }
}

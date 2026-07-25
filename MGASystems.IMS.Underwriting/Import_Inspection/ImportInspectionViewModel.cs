// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.ImportInspectionViewModel
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data.Binding;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class ImportInspectionViewModel : BindingObject
{
  private IWin32DialogService win32DialogSvc;
  private IWinMsgBoxService msgBoxSvc;
  private ISearchService searchSvc;

  [NotificationProperty]
  public virtual InspectionInfoMapping InspectionMapping { get; set; }

  [NotificationProperty]
  public virtual InspectionInfoColumnMapping SelectedItem { get; set; }

  [NotificationProperty]
  public virtual SpreadsheetInfo SpreadsheetInfo { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource ListCVS { get; set; } = new CollectionViewSource();

  [NotificationProperty]
  public virtual Cursor UICursor { get; set; }

  public static ImportInspectionViewModel Create()
  {
    return NotifyProxyTypeManager.Allocate<ImportInspectionViewModel>();
  }

  public ImportInspectionViewModel()
  {
    this.win32DialogSvc = (IWin32DialogService) new Win32DialogService();
    this.msgBoxSvc = (IWinMsgBoxService) new WinMsgBoxService();
  }

  public RelayCommand<ImportInspectionViewModel> LoadSpreadsheetCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        string fileName = importInspectionVM.win32DialogSvc.OpenFileDialog("Excel 1995-2003 Files (*.xls)|*.xls|Excel 2007-2010 Files(*.xlsx)|*.xlsx");
        if (string.IsNullOrEmpty(fileName))
          return;
        this.UICursor = Cursors.Wait;
        importInspectionVM.InspectionMapping = InspectionInfoMapping.Create();
        importInspectionVM.InspectionMapping.LoadDatabaseColumns();
        this.ListCVS.Source = (object) importInspectionVM.InspectionMapping.ColumnMapping;
        this.ListCVS.Filter += (FilterEventHandler) ((s, e) =>
        {
          InspectionInfoColumnMapping infoColumnMapping = e.Item as InspectionInfoColumnMapping;
          e.Accepted = infoColumnMapping.IMS != "PolicyNumber";
        });
        try
        {
          importInspectionVM.SpreadsheetInfo = SpreadsheetInfo.Create(fileName);
        }
        catch (IOException ex)
        {
          int num = (int) importInspectionVM.msgBoxSvc.ShowMessageBox($"The IMS was unable to open this file.{Environment.NewLine}Please ensure that it is not currently open in Excel.", "Unable to Open File", MessageBoxButton.OK);
        }
        catch (Exception ex)
        {
          int num = (int) importInspectionVM.msgBoxSvc.ShowMessageBox(ex.Message, "NotSupported", MessageBoxButton.OK);
        }
        this.UICursor = Cursors.Arrow;
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null));
    }
  }

  public RelayCommand<ImportInspectionViewModel> LoadMappingCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        if (this.searchSvc == null)
          this.searchSvc = (ISearchService) new SearchService();
        SearchObject searchObject = (SearchObject) null;
        this.searchSvc.ShowSimpleSearchSingle(InspectionInfoMapping.GetMappings(), "Choose Mapping", "Mapping Name", "Mapping Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null)
          return;
        string definingObject = searchObject.DefiningObject as string;
        IEnumerable<InspectionInfoColumnMapping> source = (IEnumerable<InspectionInfoColumnMapping>) importInspectionVM.InspectionMapping.LoadMappings(definingObject, this.SpreadsheetInfo);
        if (source.Count<InspectionInfoColumnMapping>() <= 0)
          return;
        int num = (int) this.msgBoxSvc.ShowMessageBox("The following saved mappings could not be found in the spreadsheet:  " + string.Join(", ", source.Select<InspectionInfoColumnMapping, string>((Func<InspectionInfoColumnMapping, string>) (x => x.Spreadsheet))), "", MessageBoxButton.OK);
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null && importInspectionVM.SpreadsheetInfo != null && importInspectionVM.SpreadsheetInfo.SelectedWorksheet != null));
    }
  }

  public RelayCommand<ImportInspectionViewModel> SaveMappingCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        importInspectionVM.InspectionMapping.MappingName = Interaction.InputBox("Please enter a name for these mappings:", "Mappings Name", Path.GetFileNameWithoutExtension(this.SpreadsheetInfo.FileName));
        if (string.IsNullOrEmpty(importInspectionVM.InspectionMapping.MappingName))
          return;
        importInspectionVM.InspectionMapping.UpdateMappings();
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null && importInspectionVM.InspectionMapping != null && !string.IsNullOrEmpty(importInspectionVM.InspectionMapping.PolicyNumberColumn)));
    }
  }

  public RelayCommand<ImportInspectionViewModel> ImportCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        if (string.IsNullOrEmpty(importInspectionVM.InspectionMapping.PolicyNumberColumn))
        {
          int num1 = (int) this.msgBoxSvc.ShowMessageBox("Policy # cannot be empty.", "Select mapping", MessageBoxButton.OK);
        }
        else
        {
          ProcessImportViewModel processImportViewModel = ProcessImportViewModel.Create(importInspectionVM.InspectionMapping, importInspectionVM.SpreadsheetInfo);
          ProcessImportView processImportView = MgaMdiChild.Create<ProcessImportView>(Array.Empty<object>());
          ((FrameworkElement) processImportView).DataContext = (object) processImportViewModel;
          int num2 = (int) processImportView.Form.ShowDialog();
        }
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null && importInspectionVM.InspectionMapping != null && !string.IsNullOrEmpty(importInspectionVM.InspectionMapping.PolicyNumberColumn)));
    }
  }

  public RelayCommand<ImportInspectionViewModel> GetSpreadsheetColumnCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        if (this.searchSvc == null)
          this.searchSvc = (ISearchService) new SearchService();
        SearchObject searchObject = (SearchObject) null;
        this.searchSvc.ShowSimpleSearchSingle(importInspectionVM.SpreadsheetInfo.GetListForSearch(), "Choose Spreadsheet Column", "Column Name", "Column Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null)
          return;
        SpreadsheetColumn definingObject = searchObject.DefiningObject as SpreadsheetColumn;
        importInspectionVM.SelectedItem.Spreadsheet = definingObject.ColumnName;
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null && importInspectionVM.InspectionMapping != null));
    }
  }

  public RelayCommand<ImportInspectionViewModel> GetPolicyNoColumnCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        if (this.searchSvc == null)
          this.searchSvc = (ISearchService) new SearchService();
        SearchObject searchObject = (SearchObject) null;
        this.searchSvc.ShowSimpleSearchSingle(importInspectionVM.SpreadsheetInfo.GetListForSearch(), "Choose Spreadsheet Column", "Column Name", "Column Name", (Action<SearchObject>) (r => searchObject = r));
        if (searchObject == null)
          return;
        SpreadsheetColumn definingObject = searchObject.DefiningObject as SpreadsheetColumn;
        importInspectionVM.InspectionMapping.PolicyNumberColumn = definingObject.ColumnName;
        InspectionInfoColumnMapping infoColumnMapping = importInspectionVM.InspectionMapping.ColumnMapping.Where<InspectionInfoColumnMapping>((Func<InspectionInfoColumnMapping, bool>) (m => m.IMS == "PolicyNumber")).FirstOrDefault<InspectionInfoColumnMapping>();
        if (infoColumnMapping == null)
          return;
        infoColumnMapping.Spreadsheet = definingObject.ColumnName;
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null && importInspectionVM.InspectionMapping != null));
    }
  }

  public RelayCommand<ImportInspectionViewModel> MatchColumnsCommand
  {
    get
    {
      return new RelayCommand<ImportInspectionViewModel>((Action<ImportInspectionViewModel>) (importInspectionVM =>
      {
        foreach (PropertyInfo property in typeof (InspectionInformation).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public))
        {
          PropertyInfo pi = property;
          Attribute customAttribute = pi.GetCustomAttribute(typeof (DefaultColumnAttribute));
          if (customAttribute != null)
          {
            DefaultColumnAttribute colAttribute = customAttribute as DefaultColumnAttribute;
            if (importInspectionVM.SpreadsheetInfo.ColumnList.Where<SpreadsheetColumn>((Func<SpreadsheetColumn, bool>) (c => c.ColumnName.Trim() == colAttribute.Column)).FirstOrDefault<SpreadsheetColumn>() != null)
            {
              InspectionInfoColumnMapping infoColumnMapping = importInspectionVM.InspectionMapping.ColumnMapping.Where<InspectionInfoColumnMapping>((Func<InspectionInfoColumnMapping, bool>) (i => i.IMS == pi.Name)).FirstOrDefault<InspectionInfoColumnMapping>();
              if (infoColumnMapping != null)
                infoColumnMapping.Spreadsheet = colAttribute.Column;
            }
          }
        }
        SpreadsheetColumn spreadsheetColumn = importInspectionVM.SpreadsheetInfo.ColumnList.Where<SpreadsheetColumn>((Func<SpreadsheetColumn, bool>) (c => c.ColumnName.Trim() == "Policy Number")).FirstOrDefault<SpreadsheetColumn>();
        if (spreadsheetColumn == null)
          return;
        importInspectionVM.InspectionMapping.PolicyNumberColumn = spreadsheetColumn.ColumnName;
        InspectionInfoColumnMapping infoColumnMapping1 = importInspectionVM.InspectionMapping.ColumnMapping.Where<InspectionInfoColumnMapping>((Func<InspectionInfoColumnMapping, bool>) (m => m.IMS == "PolicyNumber")).FirstOrDefault<InspectionInfoColumnMapping>();
        if (infoColumnMapping1 == null)
          return;
        infoColumnMapping1.Spreadsheet = spreadsheetColumn.ColumnName;
      }), (Predicate<ImportInspectionViewModel>) (importInspectionVM => importInspectionVM != null && importInspectionVM.SpreadsheetInfo != null && importInspectionVM.SpreadsheetInfo.SelectedWorksheet != null));
    }
  }
}

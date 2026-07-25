// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Controllers.ExcelAdministrationCommands
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Interop;
using Mga.Wpf.Ims.ValueConverters;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Validation;
using MGASystems.IMS.Excel.Data.Administration2;
using MgaSystems.IMS.Excel.Data.ScheduleChooser;
using MgaSystems.IMS.Excel.Views;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Excel.Controllers;

public static class ExcelAdministrationCommands
{
  public static RelayCommand<ExcelRaterFactorSet> EnableFactorsetsForAllCompanyLines { get; } = new RelayCommand<ExcelRaterFactorSet>((Action<ExcelRaterFactorSet>) (factorSet => DefaultDatabase.ExecuteNonQuery("ExcelRating_EnableFactorsetForAllCompanyLines", new object[2]
  {
    (object) "@factorSetGuid",
    (object) factorSet.FactorSetGuid
  })), (Predicate<ExcelRaterFactorSet>) (factorSet => factorSet != null && factorSet.FactorSetGuid.HasValue));

  public static RelayCommand<ExcelRaterFactorSet> AddQuoteDetail { get; } = new RelayCommand<ExcelRaterFactorSet>((Action<ExcelRaterFactorSet>) (excelRaterFactorSet => ((Collection<ExcelLineQuoteDetail>) excelRaterFactorSet.ExcelLineQuoteDetails).Add(ExcelLineQuoteDetail.Create(excelRaterFactorSet, new int?(), new Guid?(), "Enter the Description for the detail item here", "Enter the tag that will provide the detail data here"))), (Predicate<ExcelRaterFactorSet>) (excelRaterFactorSet => excelRaterFactorSet != null));

  public static RelayCommand<ExcelLineQuoteDetail> RemoveQuoteDetail { get; } = new RelayCommand<ExcelLineQuoteDetail>((Action<ExcelLineQuoteDetail>) (lineQuoteDetail => ((Collection<ExcelLineQuoteDetail>) lineQuoteDetail.Parent.ExcelLineQuoteDetails).Remove(lineQuoteDetail)), (Predicate<ExcelLineQuoteDetail>) (lineQuoteDetail => lineQuoteDetail?.Parent != null));

  public static RelayCommand<ExcelMapping> ChangeMappingTypeToDecimal { get; } = new RelayCommand<ExcelMapping>((Action<ExcelMapping>) (mapping =>
  {
    if (mapping.Parent.Parent.Parent.ChangeManager.HasChanges)
    {
      int num1 = (int) System.Windows.MessageBox.Show("Pending changes must be committed before changing the data type of a mapping. Please save and then try this function again.", "Unsaved changes detected", MessageBoxButton.OK, MessageBoxImage.Asterisk);
    }
    else
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("ExcelRating_ChangeMappingTypeToDecimal", new object[4]
        {
          (object) "@raterName",
          (object) mapping.Parent.Parent.Name,
          (object) "@cell",
          (object) mapping.Cell
        });
        mapping.Parent.Parent.Parent.ChangeManager.SuspendMonitoring((Action) (() => mapping.DatabaseType = "System.Decimal"));
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
        int num2 = (int) System.Windows.MessageBox.Show(ex.Message);
      }
    }
  }), (Predicate<ExcelMapping>) (mapping => mapping?.Parent != null && mapping.ConvertableToDecimal));

  public static RelayCommand<ExcelMapping> ChangeMappingTypeToText { get; } = new RelayCommand<ExcelMapping>((Action<ExcelMapping>) (mapping =>
  {
    if (mapping.Parent.Parent.Parent.ChangeManager.HasChanges)
    {
      int num3 = (int) System.Windows.MessageBox.Show("Pending changes must be committed before changing the data type of a mapping. Please save and then try this function again.", "Unsaved changes detected", MessageBoxButton.OK, MessageBoxImage.Asterisk);
    }
    else
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("ExcelRating_ChangeMappingTypeToString", new object[4]
        {
          (object) "@raterName",
          (object) mapping.Parent.Parent.Name,
          (object) "@cell",
          (object) mapping.Cell
        });
        mapping.Parent.Parent.Parent.ChangeManager.SuspendMonitoring((Action) (() => mapping.DatabaseType = "System.String"));
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
        int num4 = (int) System.Windows.MessageBox.Show(ex.Message);
      }
    }
  }), (Predicate<ExcelMapping>) (mapping => mapping?.Parent != null && mapping.ConvertableToString));

  public static RelayCommand<ExcelMapping> ChangeMappingTypeToDateTime { get; } = new RelayCommand<ExcelMapping>((Action<ExcelMapping>) (mapping =>
  {
    if (mapping.Parent.Parent.Parent.ChangeManager.HasChanges)
    {
      int num5 = (int) System.Windows.MessageBox.Show("Pending changes must be committed before changing the data type of a mapping. Please save and then try this function again.", "Unsaved changes detected", MessageBoxButton.OK, MessageBoxImage.Asterisk);
    }
    else
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("ExcelRating_ChangeMappingTypeToDate", new object[4]
        {
          (object) "@raterName",
          (object) mapping.Parent.Parent.Name,
          (object) "@cell",
          (object) mapping.Cell
        });
        mapping.Parent.Parent.Parent.ChangeManager.SuspendMonitoring((Action) (() => mapping.DatabaseType = "System.DateTime"));
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
        int num6 = (int) System.Windows.MessageBox.Show(ex.Message);
      }
    }
  }), (Predicate<ExcelMapping>) (mapping => mapping?.Parent != null && mapping.ConvertableToDate));

  private static bool ValidateModel(ExcelAdministrationData excelAdministrationData)
  {
    List<ValidationResult> validationResults = new List<ValidationResult>();
    excelAdministrationData.ValidateChanges(validationResults);
    if (validationResults.Count > 0)
    {
      int num = (int) System.Windows.MessageBox.Show("Please fix the following errors: " + validationResults[0].ErrorMessage, "Unable to save your changes.", MessageBoxButton.OK, MessageBoxImage.Asterisk);
    }
    return validationResults.Count == 0;
  }

  public static RelayCommand<object[]> AddMapping { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<ExcelRaterFactorSet, ICollectionView>(arguments);
    ExcelRaterFactorSet parent = (ExcelRaterFactorSet) arguments[0];
    ICollectionView collectionView = (ICollectionView) arguments[1];
    if (!ExcelAdministrationCommands.ValidateModel(parent.Parent.Parent))
      return;
    ExcelMapping excelMapping;
    if (((Collection<ExcelMapping>) parent.ExcelMappings).Count > 0)
    {
      int index = ((Collection<ExcelMapping>) parent.ExcelMappings).Count - 1;
      if (index >= 0)
      {
        int num = ((Collection<ExcelMapping>) parent.ExcelMappings)[index].Cell.IndexOf("!", StringComparison.InvariantCultureIgnoreCase);
        if (num != -1)
        {
          excelMapping = ExcelMapping.Create(parent, ((Collection<ExcelMapping>) parent.ExcelMappings)[index].Cell.Substring(0, num + 1));
          ((Collection<ExcelMapping>) parent.ExcelMappings).Add(excelMapping);
        }
        else
        {
          excelMapping = ExcelMapping.Create(parent);
          ((Collection<ExcelMapping>) parent.ExcelMappings).Add(excelMapping);
        }
      }
      else
      {
        excelMapping = ExcelMapping.Create(parent);
        ((Collection<ExcelMapping>) parent.ExcelMappings).Add(excelMapping);
      }
    }
    else
    {
      excelMapping = ExcelMapping.Create(parent);
      ((Collection<ExcelMapping>) parent.ExcelMappings).Add(excelMapping);
    }
    collectionView?.MoveCurrentTo((object) excelMapping);
  }), (Predicate<object[]>) (arguments => arguments != null && arguments.Length == 2));

  public static RelayCommand<object[]> DeleteMappingCommand { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<ExcelRaterFactorSet, ICollectionView, ExcelAdministrationData>(arguments);
    ExcelRaterFactorSet excelRaterFactorSet = (ExcelRaterFactorSet) arguments[0];
    ICollectionView collectionView = (ICollectionView) arguments[1];
    ExcelAdministrationData administrationData = (ExcelAdministrationData) arguments[2];
    ExcelRater parent = excelRaterFactorSet.Parent;
    if (administrationData.SelectedExcelMappingList.Count != 1)
      return;
    (bool canDelete2, string str2, bool columnExists2) = ExcelMapping.CanDeleteMapping(parent.Name, administrationData.SelectedExcelMappingList[0].DatabaseField);
    if (canDelete2)
    {
      if (System.Windows.MessageBox.Show(str2, "Delete mapping", MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No) != MessageBoxResult.Yes)
        return;
      ExcelMapping.DeleteMapping(administrationData.SelectedExcelMappingList[0].ExcelFactorSetId.Value, parent.TableNameOverride, administrationData.SelectedExcelMappingList[0].DatabaseField, parent.Name);
      ((Collection<ExcelMapping>) excelRaterFactorSet.ExcelMappings).Remove(administrationData.SelectedExcelMappingList[0]);
      if (columnExists2)
        administrationData.SubmitChanges();
      int num = (int) System.Windows.MessageBox.Show("Mapping has been deleted");
    }
    else
    {
      int num7 = (int) System.Windows.MessageBox.Show(str2, "Delete mapping");
    }
  }), (Predicate<object[]>) (arguments =>
  {
    if (arguments == null)
      return false;
    ExcelAdministrationData administrationData = (ExcelAdministrationData) arguments[2];
    return arguments.Length == 3 && administrationData.SelectedExcelMappingList.Count > 0;
  }));

  public static RelayCommand<ExcelRaterFactorSet> ImportMappings { get; } = new RelayCommand<ExcelRaterFactorSet>((Action<ExcelRaterFactorSet>) (excelRaterFactorSet =>
  {
    if (excelRaterFactorSet.Parent.Parent.HasChanges)
    {
      int num = (int) System.Windows.MessageBox.Show("Changes must be saved prior to importing mappings", "Unsaved changes");
    }
    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog()
    {
      FileName = "Mappings.xls",
      DefaultExt = ".xls",
      Filter = "Excel document (*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb)|*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb"
    };
    bool? nullable = openFileDialog.ShowDialog();
    bool flag = true;
    if (!(nullable.GetValueOrDefault() == flag & nullable.HasValue))
      return;
    string fileName = openFileDialog.FileName;
    if (string.IsNullOrEmpty(fileName))
      return;
    using (Workbook workbook = new Workbook(fileName))
    {
      Dictionary<string, ExcelMapping> dictionary = ((IEnumerable<ExcelMapping>) excelRaterFactorSet.ExcelMappings).ToDictionary<ExcelMapping, string>((System.Func<ExcelMapping, string>) (item => item.DatabaseField));
      Worksheet worksheet = workbook.Worksheets[0];
      for (int index = 0; index < 2000; ++index)
      {
        string stringValue1 = worksheet.Cells[index, 0].StringValue;
        string stringValue2 = worksheet.Cells[index, 1].StringValue;
        string stringValue3 = worksheet.Cells[index, 2].StringValue;
        if (!stringValue1.Equals("cell", StringComparison.InvariantCultureIgnoreCase))
        {
          if (string.IsNullOrWhiteSpace(stringValue1))
            break;
          if (!dictionary.ContainsKey(stringValue1))
          {
            ExcelMapping excelMapping = ExcelMapping.Create(excelRaterFactorSet);
            excelMapping.Cell = stringValue1;
            excelMapping.DatabaseField = stringValue2;
            excelMapping.DatabaseType = stringValue3;
            ((Collection<ExcelMapping>) excelRaterFactorSet.ExcelMappings).Add(excelMapping);
          }
        }
      }
    }
  }), (Predicate<ExcelRaterFactorSet>) (excelRaterFactorSet => excelRaterFactorSet != null));

  public static RelayCommand<ExcelRaterFactorSet> ExportMappings { get; } = new RelayCommand<ExcelRaterFactorSet>((Action<ExcelRaterFactorSet>) (excelRaterFactorSet =>
  {
    if (excelRaterFactorSet.Parent.Parent.HasChanges)
    {
      int num = (int) System.Windows.MessageBox.Show("Changes must be saved prior to exporting mappings", "Unsaved changes");
    }
    DataTable source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select Cell, DatabaseField, DatabaseFieldType from tblExcelRating_Mappings where ExcelFactorSetId = @excelFactorSetId", new object[2]
    {
      (object) "@excelFactorSetId",
      (object) excelRaterFactorSet.FactorSetGuid
    });
    if (source == null || source.Rows.Count <= 0)
      return;
    Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog()
    {
      FileName = "Mappings.xls",
      DefaultExt = ".xls",
      Filter = "Excel document (*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb)|*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb"
    };
    bool? nullable = saveFileDialog.ShowDialog();
    bool flag = true;
    if (!(nullable.GetValueOrDefault() == flag & nullable.HasValue))
      return;
    string fileName = saveFileDialog.FileName;
    if (string.IsNullOrEmpty(fileName))
      return;
    if (File.Exists(fileName))
      File.Delete(fileName);
    ExcelExport.ToExcel(source, fileName);
  }), (Predicate<ExcelRaterFactorSet>) (excelRaterFactorSet => excelRaterFactorSet != null));

  public static RelayCommand<ExcelRaterFactorSet> AssociateSchedule { get; } = new RelayCommand<ExcelRaterFactorSet>((Action<ExcelRaterFactorSet>) (excelRaterFactorSet =>
  {
    if (excelRaterFactorSet.Parent.Parent.HasChanges)
    {
      int num8 = (int) System.Windows.MessageBox.Show("Changes must be saved prior to associating a schedule", "Unsaved changes");
    }
    ScheduleChooserDataManager chooserDataManager = new ScheduleChooserDataManager(excelRaterFactorSet.FactorSetGuid.Value);
    if (((IEnumerable<ScheduleInfo>) chooserDataManager.AvailableSchedules).Any<ScheduleInfo>())
    {
      int num9 = (int) ((Form) MgaMdiChild.CreateForm<ScheduleChooserView>(new object[1]
      {
        (object) chooserDataManager
      })).ShowDialog();
    }
    else
    {
      int num10 = (int) System.Windows.MessageBox.Show("No new schedules available for this rater", "No new schedules");
    }
  }), (Predicate<ExcelRaterFactorSet>) (excelRaterFactorSet => excelRaterFactorSet != null));

  public static RelayCommand<ExcelRaterFactorSet> ExportSpreadSheet { get; } = new RelayCommand<ExcelRaterFactorSet>((Action<ExcelRaterFactorSet>) (excelRaterFactorSet =>
  {
    ZipUtility zipUtility = new ZipUtility();
    string tempSubdirectory1 = MGATempFolder.CreateTempSubdirectory();
    string tempSubdirectory2 = MGATempFolder.CreateTempSubdirectory();
    string str3 = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}temp.xls", (object) tempSubdirectory1);
    byte[] bytes;
    if (excelRaterFactorSet.ExcelTemplate != null && excelRaterFactorSet.ExcelTemplate.Length != 0)
      bytes = excelRaterFactorSet.ExcelTemplate;
    else
      bytes = (byte[]) DefaultDatabase.ExecuteScalar(CommandType.Text, "select compressedexcelsheet from tblExcelRating_FactorSets where FactorSetGuid = @FactorSetGuid", int.MaxValue, (CommandArgumentType) 0, new object[2]
      {
        (object) "@FactorSetGuid",
        (object) excelRaterFactorSet.FactorSetGuid.Value
      });
    File.WriteAllBytes(str3, bytes);
    zipUtility.ExtractFilesFromZipArchive(str3, tempSubdirectory2);
    string[] files = Directory.GetFiles(tempSubdirectory2);
    if (files.Length != 1)
      return;
    Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog()
    {
      FileName = Path.GetFileNameWithoutExtension(files[0]),
      DefaultExt = Path.GetExtension(files[0]),
      Filter = "Excel document (*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb)|*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb"
    };
    bool? nullable = saveFileDialog.ShowDialog();
    bool flag = true;
    if (!(nullable.GetValueOrDefault() == flag & nullable.HasValue))
      return;
    string fileName = saveFileDialog.FileName;
    if (string.IsNullOrEmpty(fileName))
      return;
    if (File.Exists(fileName))
      File.Delete(fileName);
    File.Move(files[0], fileName);
  }), (Predicate<ExcelRaterFactorSet>) (excelRaterFactorSet => excelRaterFactorSet != null));

  public static RelayCommand<object[]> CreateRater { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<ExcelAdministrationData, System.Windows.Controls.TreeView>(arguments);
    ExcelAdministrationData administrationData = (ExcelAdministrationData) arguments[0];
    System.Windows.Controls.TreeView treeView = (System.Windows.Controls.TreeView) arguments[1];
    administrationData.EnsureChildNodesCreated();
    if (!ExcelAdministrationCommands.ValidateModel(administrationData))
      return;
    byte[] numArray = ExcelAdministrationCommands.LoadSpreadSheetFromFile();
    if (numArray == null || numArray.Length == 0)
      return;
    ExcelRater excelRater = ExcelRater.Create(administrationData);
    administrationData.ExcelRaters.Add(excelRater);
    ExcelRaterFactorSet excelRaterFactorSet = ExcelRaterFactorSet.Create(excelRater, new Guid?(), DateTime.Now, false, "New SpreadSheet", "This is a newly added spreadsheet", "ExcelRating_RateOption4", true, true, true, false, false, false);
    excelRaterFactorSet.ExcelTemplate = numArray;
    ((Collection<ExcelRaterFactorSet>) excelRater.FactorSets).Add(excelRaterFactorSet);
    ExcelAdministrationCommands.SelectRater(treeView, excelRater);
  }), (Predicate<object[]>) (arguments => arguments != null && arguments.Length == 2));

  public static RelayCommand<object[]> AddSpreadSheet { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<ExcelRater, System.Windows.Controls.TreeView>(arguments);
    ExcelRater parent = (ExcelRater) arguments[0];
    System.Windows.Controls.TreeView treeView = (System.Windows.Controls.TreeView) arguments[1];
    if (!ExcelAdministrationCommands.ValidateModel(parent.Parent))
      return;
    byte[] numArray = ExcelAdministrationCommands.LoadSpreadSheetFromFile();
    parent.EnsureChildNodesCreated();
    if (numArray == null || numArray.Length == 0)
      return;
    ExcelRaterFactorSet excelRaterFactorSet1 = ExcelRaterFactorSet.Create(parent, new Guid?(), DateTime.Now, false, "New SpreadSheet", "This is a newly added spreadsheet", "ExcelRating_RateOption", false, true, true, false, false, false);
    if (((Collection<ExcelRaterFactorSet>) parent.FactorSets).Count > 0)
    {
      ExcelRaterFactorSet excelRaterFactorSet2 = ((IEnumerable<ExcelRaterFactorSet>) parent.FactorSets).OrderByDescending<ExcelRaterFactorSet, DateTime>((System.Func<ExcelRaterFactorSet, DateTime>) (f => f.EffectiveDate)).First<ExcelRaterFactorSet>();
      excelRaterFactorSet1.FactorSetInitializedFrom = excelRaterFactorSet2.FactorSetGuid;
      excelRaterFactorSet1.RatingProcedure = excelRaterFactorSet2.RatingProcedure;
      excelRaterFactorSet1.ExcelTemplate = numArray;
      excelRaterFactorSet1.ShowUpdateHistoricOptions = excelRaterFactorSet2.ShowUpdateHistoricOptions;
      excelRaterFactorSet1.RoundPremiums = excelRaterFactorSet2.RoundPremiums;
      excelRaterFactorSet1.IncludeLeapDayInProrataCalc = excelRaterFactorSet2.IncludeLeapDayInProrataCalc;
      excelRaterFactorSet1.DisableAllProrataCalculation = excelRaterFactorSet2.DisableAllProrataCalculation;
      excelRaterFactorSet1.AllowZeroPremium = excelRaterFactorSet2.AllowZeroPremium;
      excelRaterFactorSet1.UseWebServiceParameters = excelRaterFactorSet2.UseWebServiceParameters;
      excelRaterFactorSet1.EffectiveDate = !(excelRaterFactorSet2.EffectiveDate.Date == DateTime.Now.Date) ? excelRaterFactorSet2.EffectiveDate.AddDays(1.0) : excelRaterFactorSet2.EffectiveDate.AddMinutes(10.0);
      ((Collection<ExcelRaterFactorSet>) parent.FactorSets).Add(excelRaterFactorSet1);
      excelRaterFactorSet2.EnsureChildNodesCreated();
      foreach (ExcelMapping excelMapping in (Collection<ExcelMapping>) excelRaterFactorSet2.ExcelMappings)
        ((Collection<ExcelMapping>) excelRaterFactorSet1.ExcelMappings).Add(ExcelMapping.Create(excelRaterFactorSet1, excelMapping));
      foreach (RaterScheduleLink scheduleLink in (Collection<RaterScheduleLink>) excelRaterFactorSet2.ScheduleLinks)
      {
        DataRow row = DefaultDatabase.ExecuteDataRow("ExcelRating_FetchLatestScheduleVersion", new object[2]
        {
          (object) "@factorSetGUID",
          (object) scheduleLink.ScheduleFactorSetGuid
        });
        ((Collection<RaterScheduleLink>) excelRaterFactorSet1.ScheduleLinks).Add(new RaterScheduleLink(excelRaterFactorSet1, row.Field<int>("ScheduleRaterID"), row.Field<Guid>("ScheduleFactorSetGuid"), row.Field<string>("ScheduleName"), row.Field<string>("ScheduleVersionTitle"), row.Field<DateTime>("ScheduleEffectiveDate"), row.Field<int?>("RowStart"), row.Field<int?>("RowEnd"), row.Field<int?>("SetinelColumn"), row.Field<string>("NullSetinelRetVal")));
      }
    }
    else
    {
      excelRaterFactorSet1.ExcelTemplate = numArray;
      ((Collection<ExcelRaterFactorSet>) parent.FactorSets).Add(excelRaterFactorSet1);
    }
    ExcelAdministrationCommands.SelectFactorSet(treeView, excelRaterFactorSet1);
  }), (Predicate<object[]>) (arguments => arguments != null && arguments.Length == 2));

  public static RelayCommand<Guid?> GenerateOrSyncRepTags { get; } = new RelayCommand<Guid?>((Action<Guid?>) (scheduleFactorSet =>
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.ExcelRating_CreateRepeaterTagsForSchedule", new object[2]
    {
      (object) "@scheduleFactorSetGuid",
      (object) scheduleFactorSet.Value
    });
    int num = (int) System.Windows.MessageBox.Show($"Repeater tags for this schedule have been {(ExtensionsMethods.FieldAs<bool>(dataRow, "isNewStore", DataRowVersion.Current) ? "generated" : "synced")}, and are available as Custom User Tags under the tag datastore {ExtensionsMethods.FieldAs<string>(dataRow, "StoreName", DataRowVersion.Current)}.", "Tags " + (ExtensionsMethods.FieldAs<bool>(dataRow, "isNewStore", DataRowVersion.Current) ? "generated" : "synced"), MessageBoxButton.OK);
  }), (Predicate<Guid?>) (scheduleFactorSet => scheduleFactorSet.HasValue && MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Excel.ScheduleTagAutoGenerationSupported", true)));

  private static void SelectRater(System.Windows.Controls.TreeView treeView, ExcelRater excelRater)
  {
    try
    {
      DependencyObject dependencyObject = treeView.ItemContainerGenerator.ContainerFromItem((object) excelRater);
      if (dependencyObject is TreeViewItem treeViewItem && !treeViewItem.IsExpanded && ((Collection<ExcelRaterFactorSet>) excelRater.FactorSets).Count >= 1)
        treeViewItem.IsExpanded = true;
      typeof (TreeViewItem).GetMethod("Select", BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) dependencyObject, new object[1]
      {
        (object) true
      });
    }
    catch
    {
    }
  }

  private static void SelectFactorSet(System.Windows.Controls.TreeView treeView, ExcelRaterFactorSet excelRaterFactorSet)
  {
    try
    {
      if (treeView.ItemContainerGenerator.ContainerFromItem((object) excelRaterFactorSet.Parent) is TreeViewItem treeViewItem && !treeViewItem.IsExpanded && ((Collection<ExcelRaterFactorSet>) excelRaterFactorSet.Parent.FactorSets).Count >= 1)
        treeViewItem.IsExpanded = true;
      MethodInfo method = typeof (TreeViewItem).GetMethod("Select", BindingFlags.Instance | BindingFlags.NonPublic);
      DependencyObject dependencyObject = treeViewItem.ItemContainerGenerator.ContainerFromItem((object) excelRaterFactorSet);
      if (dependencyObject == null)
        return;
      method.Invoke((object) dependencyObject, new object[1]
      {
        (object) true
      });
    }
    catch
    {
    }
  }

  private static byte[] LoadSpreadSheetFromFile()
  {
    Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
    openFileDialog1.FileName = "ExcelDocument.xls";
    openFileDialog1.DefaultExt = ".xls";
    openFileDialog1.Filter = "Excel document (*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb)|*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb";
    Microsoft.Win32.OpenFileDialog openFileDialog2 = openFileDialog1;
    bool? nullable = openFileDialog2.ShowDialog();
    bool flag = true;
    if (nullable.GetValueOrDefault() == flag & nullable.HasValue)
    {
      string fileName = openFileDialog2.FileName;
      if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
      {
        ZipUtility zipUtility = new ZipUtility();
        try
        {
          byte[] fileData = FileReader.ReadAllBytes(fileName);
          byte[] newZipStream = zipUtility.CompressStreamToNewZipStream(fileData, fileName);
          if (newZipStream != null)
          {
            if (newZipStream.Length != 0)
              return newZipStream;
          }
        }
        catch (IOException ex)
        {
          int num = (int) System.Windows.MessageBox.Show(ex.Message, "An error occurred opening this file", MessageBoxButton.OK, MessageBoxImage.Hand);
          ErrorHandler.SilentHandleError((Exception) ex);
        }
      }
    }
    return (byte[]) null;
  }
}

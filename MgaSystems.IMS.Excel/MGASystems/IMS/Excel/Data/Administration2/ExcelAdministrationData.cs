// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.ExcelAdministrationData
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Controls;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

public abstract class ExcelAdministrationData : OnDemandViewModel, ISubmittable, IDataErrorInfo
{
  private readonly BulkObservableCollection<ExcelRater> excelRaters = new BulkObservableCollection<ExcelRater>();
  private bool isTrackingChanges;
  private bool loadChildNodesOnThread;
  private bool freezeChildNodeLoad;

  public ChangeManager ChangeManager { get; private set; }

  [NotificationProperty]
  public virtual bool ExcludeHiddenFactorSetsFromView { get; set; }

  [NotificationProperty]
  public virtual bool IsLoadingExcelFactorSets { get; set; }

  [NotificationProperty]
  public virtual int SheetUploadPercentage { get; set; }

  [NotificationProperty]
  public virtual string StatusText { get; set; }

  [DependsOn("SheetUploadPercentage")]
  public bool IsUploadingSpreadSheet => this.SheetUploadPercentage != 0;

  public static bool DisplayDateMappingConversion
  {
    get => MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("Excel.DisplayDateMappingConversion", false);
  }

  public static string ShowScheduleAutoGenerationByColumnWidth { get; set; } = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Excel.ScheduleTagAutoGenerationSupported", true) ? "auto" : "0";

  public List<ExcelMapping> SelectedExcelMappingList { get; } = new List<ExcelMapping>();

  protected override void OnPropertyChanged(string propertyName)
  {
    if (propertyName == "ExcludeHiddenFactorSetsFromView")
    {
      foreach (ExcelRater excelRater in (Collection<ExcelRater>) this.ExcelRaters)
        excelRater.UpdateFactorSetsView();
    }
    base.OnPropertyChanged(propertyName);
  }

  public override bool LoadChildNodesOnThread => this.loadChildNodesOnThread;

  public override bool FreezeChildNodeLoad => this.freezeChildNodeLoad;

  public static ExcelAdministrationData Create(bool loadChildNodesOnThread = true, bool trackChanges = true)
  {
    return NotifyProxyTypeManager.Allocate<ExcelAdministrationData>(new object[2]
    {
      (object) loadChildNodesOnThread,
      (object) trackChanges
    });
  }

  public ExcelAdministrationData(bool loadChildNodesOnThread, bool trackChanges)
  {
    this.loadChildNodesOnThread = loadChildNodesOnThread;
    this.isTrackingChanges = trackChanges;
    if (!trackChanges)
      return;
    this.ChangeManager = new ChangeManager((INotifyPropertyChanged) this);
    this.UseChangeMonitor = true;
    this.ExcludeHiddenFactorSetsFromView = true;
  }

  public static IEnumerable Lines { get; } = Information.IsDesignMode ? (IEnumerable) null : (IEnumerable) DefaultDatabase.ExecuteDataTable(CommandType.Text, "select LineGuid, LineName from lstLines order by LineName").AsEnumerable().Select(row => new
  {
    Name = row.Field<string>("LineName"),
    Value = row.Field<Guid?>("LineGuid")
  });

  public static IEnumerable PremiumOptions { get; }

  private static int GetPremiumOptionSortOrder(string premiumOption)
  {
    switch (premiumOption)
    {
      case "PREM":
        return 1;
      case "TERR":
        return 2;
      default:
        return 3;
    }
  }

  public static ArrayList SystemTypes { get; }

  [DisallowDuplicateValues("Name")]
  public ObservableCollection<ExcelRater> ExcelRaters
  {
    get
    {
      this.InitializeChildNodes();
      return (ObservableCollection<ExcelRater>) this.excelRaters;
    }
  }

  protected override void ProcessChildNodes(object childNodes)
  {
    this.excelRaters.AddRange((IEnumerable<ExcelRater>) ((DataTable) childNodes).AsEnumerable().OrderBy<DataRow, bool>((System.Func<DataRow, bool>) (row => row.Field<bool>("Hidden"))).ThenBy<DataRow, string>((System.Func<DataRow, string>) (row => row.Field<string>("Name"))).Select<DataRow, ExcelRater>((System.Func<DataRow, ExcelRater>) (row => ExcelRater.Create(this, row.Field<int>("Id"), row.Field<string>("Name"), row.Field<bool>("Hidden"), row.Field<int>("RatingTypeId"), row.Field<bool>("RaterDisplaysModally"), row.Field<bool>("ResetRaterOnEndorsement"), row.Field<string>("DatabaseTableName")))));
    this.ChangeManager?.StartMonitor((INotifyPropertyChanged) this.ExcelRaters, "ExcelRaters");
  }

  protected override object FetchChildNodes()
  {
    return (object) DefaultDatabase.ExecuteDataTable("tblExcelRating_Raters_SelectAll");
  }

  public bool HasChanges
  {
    get => this.isTrackingChanges && this.ChangeManager != null && this.ChangeManager.HasChanges;
  }

  public List<ValidationResult> SubmitChanges()
  {
    if (!this.isTrackingChanges)
      throw new InvalidOperationException("Cannot SubmitChanges while in Readonly Mode (trackChanges == false)");
    List<ValidationResult> validationResults = new List<ValidationResult>();
    if (!((Guid?) DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 CompanyLineGuid from tblCompanyLines (nolock)")).HasValue)
    {
      validationResults.Add(new ValidationResult("A company Line must be defined before a rater can be saved into the system."));
      return validationResults;
    }
    this.SheetUploadPercentage = 1;
    this.StatusText = "Validating Model please wait...";
    MgaWindow.DoEvents();
    int num = this.ValidateChanges(validationResults) ? 1 : 0;
    MgaWindow.DoEvents();
    if (num != 0)
    {
      List<ExcelRaterFactorSet> list = this.ChangeManager.DeltaList.Where<ChangeDetail>((System.Func<ChangeDetail, bool>) (changeDetail => changeDetail.ObjectThatChanged is INotifyCollectionChanged && changeDetail.PriorValue != null && changeDetail.PriorValue.ToString() == "Added" && changeDetail.Value != null && typeof (ExcelMapping).IsAssignableFrom(changeDetail.Value.GetType()))).Select<ChangeDetail, ExcelRaterFactorSet>((System.Func<ChangeDetail, ExcelRaterFactorSet>) (changeDetail => ((ExcelMapping) changeDetail.Value).Parent)).Distinct<ExcelRaterFactorSet>().ToList<ExcelRaterFactorSet>();
      try
      {
        DatabaseCommands.SubmitAndLogChanges(IsolationLevel.ReadUncommitted, this.ChangeManager, (Action<int, int>) ((i, t) =>
        {
          if (i == t)
          {
            this.StatusText = "";
            this.SheetUploadPercentage = 0;
          }
          else
          {
            this.SheetUploadPercentage = (int) (100.0 / (double) t * (double) i);
            this.StatusText = $"Saving {i} of {t} changes.";
          }
          MgaWindow.DoEvents();
        }));
        foreach (ExcelRaterFactorSet excelRaterFactorSet in list)
          DefaultDatabase.ExecuteNonQuery("Dynamic_PrepareExcelDataStore", new object[2]
          {
            (object) "@FactorSetGUID",
            (object) excelRaterFactorSet.FactorSetGuid.Value
          });
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
        throw;
      }
    }
    else
    {
      this.SheetUploadPercentage = 0;
      this.StatusText = "";
    }
    return validationResults;
  }

  internal bool ValidateChanges(List<ValidationResult> validationResults)
  {
    return this.ChangeManager.GetAllChangedItems().Concat<INotifyPropertyChanged>(this.ChangeManager.GetAllAddedItems()).OfType<IDataErrorInfo>().ToList<IDataErrorInfo>().All<IDataErrorInfo>((System.Func<IDataErrorInfo, bool>) (itemToValidate => DataErrorInfoSupport.ValidateObject(itemToValidate, validationResults)));
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  static ExcelAdministrationData()
  {
    OrderedEnumerableRowCollection<string> enumerableRowCollection;
    if (!Information.IsDesignMode)
      enumerableRowCollection = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT ChargeID FROM dbo.tblFin_PolicyCharges WHERE ChargeID IS NOT NULL AND ChargeType = @ChargeType", new object[2]
      {
        (object) "@ChargeType",
        (object) "P"
      }).AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (row => row.Field<string>("ChargeID"))).OrderBy<string, int>(new System.Func<string, int>(ExcelAdministrationData.GetPremiumOptionSortOrder)).ThenBy<string, string>((System.Func<string, string>) (row => row));
    else
      enumerableRowCollection = (OrderedEnumerableRowCollection<string>) null;
    ExcelAdministrationData.PremiumOptions = (IEnumerable) enumerableRowCollection;
    ExcelAdministrationData.SystemTypes = new ArrayList()
    {
      (object) new
      {
        Name = typeof (int).FullName,
        Value = "Integer"
      },
      (object) new
      {
        Name = typeof (long).FullName,
        Value = "Long"
      },
      (object) new
      {
        Name = typeof (Decimal).FullName,
        Value = "Decimal/Money"
      },
      (object) new
      {
        Name = typeof (string).FullName,
        Value = "Text"
      },
      (object) new
      {
        Name = typeof (DateTime).FullName,
        Value = "Date/Time"
      },
      (object) new
      {
        Name = typeof (bool).FullName,
        Value = "True/False"
      }
    };
  }
}

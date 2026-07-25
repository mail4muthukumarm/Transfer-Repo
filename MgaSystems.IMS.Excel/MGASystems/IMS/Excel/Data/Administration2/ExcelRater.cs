// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.ExcelRater
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

[Description("Excel Rater")]
[TableMapping("tblExcelRating_Raters")]
public abstract class ExcelRater : OnDemandViewModel, IDataErrorInfo, IDataTransferFilter
{
  public ExcelAdministrationData Parent { get; }

  public ExcelRater(ExcelAdministrationData parent)
  {
    string newRaterName = "New Excel Rater";
    IEnumerable<ExcelRater> source = parent.ExcelRaters.Where<ExcelRater>((System.Func<ExcelRater, bool>) (excelRater => string.CompareOrdinal(excelRater.Name, newRaterName) == 0));
    int num = 1;
    while (source.Count<ExcelRater>() > 0)
    {
      string newPositionedRaterName = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0} {1}", (object) newRaterName, (object) num);
      source = parent.ExcelRaters.Where<ExcelRater>((System.Func<ExcelRater, bool>) (excelRater => string.CompareOrdinal(excelRater.Name, newPositionedRaterName) == 0));
      if (source.Count<ExcelRater>() == 0)
        newRaterName = newPositionedRaterName;
      ++num;
    }
    this.Parent = parent;
    this.Name = newRaterName;
    this.InitializeChildNodes();
  }

  public ExcelRater(
    ExcelAdministrationData parent,
    int id,
    string name,
    bool hidden,
    int ratingTypeId,
    bool promptForSpreadsheet,
    bool resetRaterOnEndorsement,
    string databaseTableName)
  {
    this.Parent = parent;
    this.PromptForSpreadsheet = promptForSpreadsheet;
    this.Name = name;
    this.RatingTypeID = ratingTypeId;
    this.Id = new int?(id);
    this.Hidden = hidden;
    this.ResetRaterOnEndorsement = resetRaterOnEndorsement;
    this.TableNameOverride = databaseTableName;
    ((Collection<ExcelRaterFactorSet>) this.FactorSets).Add(ExcelRaterFactorSet.Create(this, new Guid?(), DateTime.Now, false, "PLACEHOLDER", "", "", false, true, true, false, false, false));
  }

  public static ExcelRater Create(
    ExcelAdministrationData parent,
    int id,
    string name,
    bool hidden,
    int ratingTypeId,
    bool promptForSpreadsheet,
    bool resetRaterOnEndorsement,
    string databaseTableName)
  {
    return NotifyProxyTypeManager.Allocate<ExcelRater>(new object[8]
    {
      (object) parent,
      (object) id,
      (object) name,
      (object) hidden,
      (object) ratingTypeId,
      (object) promptForSpreadsheet,
      (object) resetRaterOnEndorsement,
      (object) databaseTableName
    });
  }

  public static ExcelRater Create(ExcelAdministrationData parent)
  {
    return NotifyProxyTypeManager.Allocate<ExcelRater>(new object[1]
    {
      (object) parent
    });
  }

  [DataKey]
  [TableFieldMapping]
  public int? Id { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  [Required]
  [StringLength(30)]
  [RegularExpression("^[a-zA-Z0-9_' ']*$")]
  public virtual string Name { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool Hidden { get; set; }

  public string TableNameOverride { get; set; }

  [DependsOn("Name")]
  [TableFieldMapping]
  public string DatabaseTableName
  {
    get
    {
      return string.IsNullOrEmpty(this.TableNameOverride) ? $"Dynamic_Data_{this.Name.Replace(" ", "")}" : this.TableNameOverride;
    }
  }

  [TableFieldMapping]
  public int RatingTypeID { get; set; }

  [TrackChanges]
  [TableFieldMapping("RaterDisplaysModally")]
  [NotificationProperty]
  public virtual bool PromptForSpreadsheet { get; set; }

  protected override void OnPropertyChanged(string propertyName)
  {
    if (propertyName == "ExcludeHiddenFactorSetsFromView")
      this.UpdateFactorSetsView();
    base.OnPropertyChanged(propertyName);
  }

  public void UpdateFactorSetsView()
  {
    if (!this.ChildNodesInitialized)
      return;
    ICollectionView defaultView = CollectionViewSource.GetDefaultView((object) this.FactorSets);
    defaultView.Filter = (Predicate<object>) null;
    defaultView.Filter = (Predicate<object>) (factorSetObject => !(factorSetObject is ExcelRaterFactorSet excelRaterFactorSet) || this.Parent == null || !this.Parent.ExcludeHiddenFactorSetsFromView || !excelRaterFactorSet.Hidden);
  }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool ResetRaterOnEndorsement { get; set; }

  [DisallowDuplicateValues("Title", ErrorMessage = "Invalid Title {2} must be unique for all spreadsheets under this rater.")]
  public BulkObservableCollection<ExcelRaterFactorSet> FactorSets { get; } = new BulkObservableCollection<ExcelRaterFactorSet>();

  protected override void PrepareFetchChildNodes()
  {
    this.Parent.IsLoadingExcelFactorSets = true;
    ((Collection<ExcelRaterFactorSet>) this.FactorSets).Clear();
    base.PrepareFetchChildNodes();
  }

  protected override void ProcessChildNodes(object childNodes)
  {
    this.FactorSets.AddRange(((DataTable) childNodes).Rows.Cast<DataRow>().OrderBy<DataRow, bool>((System.Func<DataRow, bool>) (row => row.Field<bool>("Hidden"))).ThenBy<DataRow, DateTime>((System.Func<DataRow, DateTime>) (row => row.Field<DateTime>("EffectiveDate"))).ThenBy<DataRow, string>((System.Func<DataRow, string>) (row => row.Field<string>("Title"))).Select<DataRow, ExcelRaterFactorSet>((System.Func<DataRow, ExcelRaterFactorSet>) (row => ExcelRaterFactorSet.Create(this, new Guid?(row.Field<Guid>("FactorSetGUID")), row.Field<DateTime>("EffectiveDate"), row.Field<bool>("Hidden"), row.Field<string>("Title"), row.Field<string>("Memo"), row.Field<string>("RatingProcedure"), row.Field<bool>("ShowUpdateHistoricOptions"), row.Field<bool>("RoundPremiums"), row.Field<bool>("IncludeLeapDayInProrataCalc"), row.Field<bool>("DisableAllProrataCalculation"), row.Field<bool>("AllowZeroPremium"), row.Field<bool>("UseWebServiceParameters")))));
    this.Parent.IsLoadingExcelFactorSets = false;
    if (this.Parent.ChangeManager != null)
      this.Parent.ChangeManager.StartMonitor((INotifyPropertyChanged) this.FactorSets, "FactorSets");
    this.UpdateFactorSetsView();
  }

  protected override object FetchChildNodes()
  {
    return (object) DefaultDatabase.ExecuteDataTable("tblExcelRating_FactorSets_SelectByRaterId", new object[2]
    {
      (object) "@raterId",
      (object) this.RatingTypeID
    });
  }

  public override bool LoadChildNodesOnThread
  {
    get => this.Id.HasValue && this.Parent.LoadChildNodesOnThread;
  }

  public override bool FreezeChildNodeLoad => this.Parent.FreezeChildNodeLoad;

  [NotificationProperty]
  public virtual bool IsExpanded { get; set; }

  protected override void OnPropertyChanging(string propertyName)
  {
    if (propertyName == "IsExpanded" && !this.IsExpanded)
      this.InitializeChildNodes();
    base.OnPropertyChanging(propertyName);
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  public void OnWriteAdditionalValuesToSource(Dictionary<string, object> values)
  {
    if (this.Id.HasValue)
      return;
    this.RatingTypeID = (int) DefaultDatabase.ExecuteScalar("lstRatingTypes_InsertRater", new object[4]
    {
      (object) "@baseId",
      (object) 4000,
      (object) "@ratingType",
      (object) this.Name
    });
    values.Add("RatingTypeID", (object) this.RatingTypeID);
  }

  public void OnWriteToDestination(DataTransferFilterEventArgs e)
  {
  }

  public void OnWriteToSource(DataTransferFilterEventArgs e)
  {
  }
}

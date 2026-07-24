// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.Lib.ThresholdLimitManager
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.Lib;

public abstract class ThresholdLimitManager : ValidatingBindingObject
{
  private List<int> FetchedThresholds { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<ThresholdLimitRater> ThresholdRaterList { get; } = new BulkObservableCollection<ThresholdLimitRater>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static ThresholdLimitManager Create()
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitManager>();
  }

  public ThresholdLimitManager()
  {
    this.FetchedThresholds = new List<int>();
    this.ThresholdRaterList.AddRange((IEnumerable<ThresholdLimitRater>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spThresholdLimitsGetList").AsEnumerable().Select<DataRow, ThresholdLimitRater>((System.Func<DataRow, ThresholdLimitRater>) (row => ThresholdLimitRater.Create(this, row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public bool FetchThresholds(int thresholdRaterID)
  {
    if (this.FetchedThresholds.Contains(thresholdRaterID))
      return false;
    this.FetchedThresholds.Add(thresholdRaterID);
    return true;
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }
}

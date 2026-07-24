// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.FCWComments.LIb.FCWConditionListManager
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
namespace MgaSystems.IMS.Policies.FCWComments.LIb;

public abstract class FCWConditionListManager : ValidatingBindingObject
{
  [TrackChanges]
  public virtual BulkObservableCollection<FCWConditionList> CodeList { get; } = new BulkObservableCollection<FCWConditionList>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  [NotificationProperty]
  public virtual string FilterRater { get; set; }

  internal static FCWConditionListManager Create()
  {
    return NotifyProxyTypeManager.Allocate<FCWConditionListManager>();
  }

  public FCWConditionListManager()
  {
    this.CodeList.AddRange((IEnumerable<FCWConditionList>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "select lstRatingTypes.RatingType, tblFCWConditions.RaterId, tblFCWConditions.ID, FCWConditionID, FCWConditionName, OperatorTypeID,FCWConditionComments  from tblFCWConditions INNER JOIN lstRatingTypes on lstRatingTypes.RatingTypeID = tblFCWConditions.RaterID order by lstRatingTypes.RatingTypeID, FCWConditionName").AsEnumerable().Select<DataRow, FCWConditionList>((System.Func<DataRow, FCWConditionList>) (row => FCWConditionList.Create(this, row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }
}

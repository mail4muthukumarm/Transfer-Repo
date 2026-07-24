// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitManager
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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

public abstract class AuthorityLimitManager : ValidatingBindingObject
{
  private List<int> FetchedChildren { get; set; }

  [TrackChanges]
  public virtual BulkObservableCollection<MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit> AuthorityLimitList { get; } = new BulkObservableCollection<MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>();

  public ObservableCollection<AuthorityLimitCellType> CellTypeList { get; }

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static AuthorityLimitManager Create()
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitManager>();
  }

  public AuthorityLimitManager()
  {
    this.FetchedChildren = new List<int>();
    this.CellTypeList = AuthorityLimitCellType.GetAuthorityLimitCellTypeList();
    this.AuthorityLimitList.AddRange((IEnumerable<MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spAuthorityLimitsGetList").AsEnumerable().Select<DataRow, MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>((System.Func<DataRow, MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit>) (row => MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimit.Create(this, row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public bool FetchChildren(int authorityLimitsID)
  {
    if (this.FetchedChildren.Contains(authorityLimitsID))
      return false;
    this.FetchedChildren.Add(authorityLimitsID);
    return true;
  }

  public string GetCellType(int cellTypeID)
  {
    return this.CellTypeList.Where<AuthorityLimitCellType>((System.Func<AuthorityLimitCellType, bool>) (c => c.CellTypeID == cellTypeID)).FirstOrDefault<AuthorityLimitCellType>().CellType;
  }
}

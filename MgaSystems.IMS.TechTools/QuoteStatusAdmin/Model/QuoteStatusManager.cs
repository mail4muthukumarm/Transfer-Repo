// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.QuoteStatusAdmin.Model.QuoteStatusManager
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using MgaSystems.IMS.TechTools.SharedModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.QuoteStatusAdmin.Model;

public abstract class QuoteStatusManager : ValidatingBindingObject
{
  [TrackChanges]
  public virtual BulkObservableCollection<QuoteStatus> QuoteStatusList { get; } = new BulkObservableCollection<QuoteStatus>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static QuoteStatusManager Create()
  {
    return NotifyProxyTypeManager.Allocate<QuoteStatusManager>();
  }

  public QuoteStatusManager()
  {
    this.QuoteStatusList.AddRange((IEnumerable<QuoteStatus>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spQuoteStatusGetList").AsEnumerable().Select<DataRow, QuoteStatus>((System.Func<DataRow, QuoteStatus>) (row => QuoteStatus.Create(this, row))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public QuoteStatus NewQuoteStatus()
  {
    QuoteStatus quoteStatus = QuoteStatus.Create(this);
    ((Collection<QuoteStatus>) this.QuoteStatusList).Add(quoteStatus);
    return quoteStatus;
  }
}

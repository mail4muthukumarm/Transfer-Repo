// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.HelpMenuAdmin.HelpAdminManager
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Forms.HelpMenuAdmin;

public abstract class HelpAdminManager : ValidatingBindingObject
{
  [TrackChanges]
  public virtual BulkObservableCollection<HelpItemModel> HelpItems { get; } = new BulkObservableCollection<HelpItemModel>();

  public ChangeManager ChangeManager { get; } = new ChangeManager();

  public bool HasChanges => this.ChangeManager.HasChanges;

  internal static HelpAdminManager Create() => NotifyProxyTypeManager.Allocate<HelpAdminManager>();

  public HelpAdminManager()
  {
    this.HelpItems.AddRange((IEnumerable<HelpItemModel>) DefaultDatabase.ExecuteMappedObjectSelectMultiple<HelpItemModel>((System.Func<DataRow, HelpItemModel>) (r => HelpItemModel.Create(r.Field<int>("ID"), r.Field<string>("HelpToolKey"), r.Field<string>("HelpToolCaption"), r.Field<string>("HelpToolUri"), r.Field<bool>("Active")))));
    this.ChangeManager.Initialize((INotifyPropertyChanged) this);
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> source = new List<ValidationResult>();
    DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, source);
    IEnumerable<string> strings = ((IEnumerable<HelpItemModel>) this.HelpItems).GroupBy<HelpItemModel, string>((System.Func<HelpItemModel, string>) (c => c.HelpToolKey)).Where<IGrouping<string, HelpItemModel>>((System.Func<IGrouping<string, HelpItemModel>, bool>) (g => g.Skip<HelpItemModel>(1).Any<HelpItemModel>())).Select<IGrouping<string, HelpItemModel>, string>((System.Func<IGrouping<string, HelpItemModel>, string>) (c => c.Key));
    if (strings.Any<string>())
      source.Add(new ValidationResult($"Duplicate Keys '{string.Join(", ", strings)}' found"));
    if (!source.Any<ValidationResult>())
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return source;
  }
}

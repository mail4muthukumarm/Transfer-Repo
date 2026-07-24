// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics.FormActionDurationStatisticsKeeper
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Data.Repository.Interface;
using System;
using System.Diagnostics;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics;

[Override(typeof (IFormActionDurationStatisticsKeeper))]
public class FormActionDurationStatisticsKeeper : IFormActionDurationStatisticsKeeper
{
  private readonly bool _isDebug;
  private readonly string _formName;
  private readonly IFormActionDurationRepository _repository;

  public FormActionDurationStatisticsKeeper(string formName)
    : this(formName, ObjectFactory.Instance.CreateObjectAs<IFormActionDurationRepository>())
  {
  }

  public FormActionDurationStatisticsKeeper(
    string formName,
    IFormActionDurationRepository repository)
  {
    this._formName = formName ?? throw new ArgumentNullException(nameof (formName));
    this._repository = repository ?? throw new ArgumentNullException(nameof (repository));
  }

  public void ExecuteAndTrackTime(string actionName, Action action)
  {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    action();
    stopwatch.Stop();
    ((ICreateRepository<FormActionDurationDto, int>) this._repository).Insert(new FormActionDurationDto()
    {
      FormName = this._formName,
      ActionName = actionName,
      TimeMs = (int) stopwatch.ElapsedMilliseconds,
      IsDebug = this._isDebug,
      UserGuid = CurrentUser.Instance.UserGUID
    });
  }
}

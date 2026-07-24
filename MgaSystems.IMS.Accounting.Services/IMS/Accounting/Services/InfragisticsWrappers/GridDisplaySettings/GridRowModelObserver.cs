// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.GridRowModelObserver
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public class GridRowModelObserver : IModelObserver<IMvcModel>, IModelObserver
{
  public GridRowModelObserver(System.Action<IMvcModel> action) => this.Action = action;

  public System.Action<IMvcModel> Action { get; }

  public void Update(object model)
  {
    if (!(model is IMvcModel model1))
      return;
    this.Update(model1);
  }

  public void Update(IMvcModel model) => this.Action(model);
}

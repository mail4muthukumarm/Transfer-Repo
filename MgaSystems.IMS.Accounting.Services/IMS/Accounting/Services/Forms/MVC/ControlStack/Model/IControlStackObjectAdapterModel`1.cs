// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model.IControlStackObjectAdapterModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.Utility;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model;

public interface IControlStackObjectAdapterModel<TDisplayItem> : 
  IControlStackObjectAdapterModel,
  IMvcModel,
  ISave
  where TDisplayItem : class
{
  TDisplayItem DisplayItem { get; }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels.IUpdateDatabaseModel`1
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;

public interface IUpdateDatabaseModel<TIdentifier> : 
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject,
  IUniqueObject<TIdentifier>
{
}

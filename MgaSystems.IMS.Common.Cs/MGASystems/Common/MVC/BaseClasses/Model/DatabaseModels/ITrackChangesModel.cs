// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels.ITrackChangesModel
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using System;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;

[Obsolete("Use IUpdateDatabaseModel which now inherits ITrackChanges or just use ITrackChanges")]
public interface ITrackChangesModel : 
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject
{
}

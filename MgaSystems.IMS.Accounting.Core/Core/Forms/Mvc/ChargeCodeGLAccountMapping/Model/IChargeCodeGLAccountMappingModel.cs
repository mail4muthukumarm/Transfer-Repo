// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model.IChargeCodeGLAccountMappingModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model;

public interface IChargeCodeGLAccountMappingModel : 
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject
{
  string Name { get; }

  IEnumerable<OfficeGlMapping> OfficeGlMappings { get; }

  string Description { get; }

  string State { get; }
}

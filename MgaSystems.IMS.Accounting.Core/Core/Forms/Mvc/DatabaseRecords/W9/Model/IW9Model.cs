// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model.IW9Model
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;
using MGASystems.IMS.Accounting.Services.Utility.EntityTypes;
using MGASystems.IMS.Accounting.Services.Utility.LastEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model;

public interface IW9Model : 
  IDatabaseSaveModel<Guid>,
  IDatabaseSaveModel,
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject,
  IUpdateDatabaseModel<Guid>,
  IUniqueObject<Guid>,
  INamedValue<Guid>,
  INamedValue
{
  string TaxingEntity { get; set; }

  string BusinessName { get; set; }

  IAddressModel Address { get; }

  ILastEditData ModificationData { get; }

  string TinEin { get; set; }

  ISelectableValueWithOtherModel<INamedValue<int>, int> EntityType { get; }

  DateTime? W9Date { get; set; }

  AccountingEntityType AccountingType { get; set; }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.IAttorneyManagementModel
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Utility.LastEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

public interface IAttorneyManagementModel : 
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
  IUniqueObject<Guid>
{
  Guid AttorneyGuid { get; set; }

  string AttorneyType { get; set; }

  string LawFirm { get; set; }

  string AttorneyName { get; set; }

  string FEINSSN { get; set; }

  string AttorneyEntityType { get; set; }

  IAddressModel Address { get; }

  string PhoneNumber { get; set; }

  string FaxNumber { get; set; }

  ILastEditData ModificationData { get; }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.MVC.Model.IClaimsEntityModel
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
namespace MGASystems.IMS.Claims.Claims_Entities.MVC.Model;

public interface IClaimsEntityModel : 
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
  Guid EntityGuid { get; set; }

  int EntityTypeId { get; set; }

  string EntityTypeDesc { get; set; }

  string EntityName { get; set; }

  string DBA { get; set; }

  string FirstName { get; set; }

  string MiddleName { get; set; }

  string LastName { get; set; }

  IAddressModel Address { get; }

  ILastEditData ModificationData { get; }

  string FEINSSN { get; set; }

  string ContactName { get; set; }

  string PhoneNumber { get; set; }

  string FaxNumber { get; set; }
}

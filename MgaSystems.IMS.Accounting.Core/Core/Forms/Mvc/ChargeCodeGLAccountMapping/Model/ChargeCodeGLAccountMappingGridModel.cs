// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model.ChargeCodeGLAccountMappingGridModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.Repository.Interface;
using MGASystems.IMS.Accounting.Core.DataAccess.ChargeCode;
using MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice;
using MGASystems.IMS.Accounting.Core.DataAccess.GLAccount;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model;

[Override(typeof (IChargeCodeGLAccountMappingGridModel))]
public class ChargeCodeGLAccountMappingGridModel : 
  UltraGridDataBulkEditModel<IChargeCodeGLAccountMappingModel>,
  IChargeCodeGLAccountMappingGridModel,
  IUltraGridDataModel<IChargeCodeGLAccountMappingModel>,
  IUltraGridDataModel,
  IValidateModel,
  IMvcModel,
  IValidate
{
  private readonly IChargeCodeGLAccountMappingRepository _mappingRepository = ObjectFactory.Instance.CreateObjectAs<IChargeCodeGLAccountMappingRepository>();
  private readonly IGLAccountRepository _glAccountRepository = ObjectFactory.Instance.CreateObjectAs<IGLAccountRepository>();
  private readonly IClientOfficeRepository _clientOfficeRepository = ObjectFactory.Instance.CreateObjectAs<IClientOfficeRepository>();
  private readonly IChargeCodeRepository _chargeCodeRepository = ObjectFactory.Instance.CreateObjectAs<IChargeCodeRepository>();

  protected override IChargeCodeGLAccountMappingModel[] GetDisplayItems()
  {
    IEnumerable<ChargeCodeDto> allFees = this._chargeCodeRepository.GetAllFees();
    ChargeCodeGLAccountMappingDto[] all = ((IGetAllRepository<ChargeCodeGLAccountMappingDto, int>) this._mappingRepository).GetAll();
    IEnumerable<ClientOfficeDto> accountingOffices = this._clientOfficeRepository.GetAllAccountingOffices();
    IEnumerable<GLAccountDto> allIncome = this._glAccountRepository.GetAllIncome();
    List<IChargeCodeGLAccountMappingModel> accountMappingModelList = new List<IChargeCodeGLAccountMappingModel>();
    foreach (ChargeCodeDto chargeCodeDto1 in allFees)
    {
      ChargeCodeDto chargeCodeDto = chargeCodeDto1;
      accountMappingModelList.Add(ObjectFactory.Instance.CreateObjectAs<IChargeCodeGLAccountMappingModel>((object) this._mappingRepository, (object) chargeCodeDto, (object) ((IEnumerable<ChargeCodeGLAccountMappingDto>) all).Where<ChargeCodeGLAccountMappingDto>((Func<ChargeCodeGLAccountMappingDto, bool>) (x => x.ChargeCode == chargeCodeDto.ChargeCode)), (object) accountingOffices.ToList<ClientOfficeDto>(), (object) allIncome));
    }
    return accountMappingModelList.ToArray();
  }
}

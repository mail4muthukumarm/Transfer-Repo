// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Model.PayeeMissingBankAccountGridModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Model;

public class PayeeMissingBankAccountGridModel : UltraGridDataModel<PayeeMissingBankAccountDto>
{
  public PayeeMissingBankAccountGridModel(PayeeMissingBankAccountDto[] dtos)
  {
    this.Dtos = dtos ?? throw new ArgumentNullException(nameof (dtos));
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
  }

  public PayeeMissingBankAccountDto Selected { get; set; }

  public PayeeMissingBankAccountDto[] Dtos { get; }

  protected override PayeeMissingBankAccountDto[] GetDisplayItems() => this.Dtos;
}

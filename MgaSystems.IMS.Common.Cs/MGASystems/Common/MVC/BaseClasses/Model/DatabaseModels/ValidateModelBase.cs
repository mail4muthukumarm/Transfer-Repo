// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels.ValidateModelBase
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;

public abstract class ValidateModelBase : MvcModelBase, IValidateModel, IMvcModel, IValidate
{
  public void ValidateData()
  {
    DataValidationResultGroup validationResultGroup = new DataValidationResultGroup();
    this.ValidateData(validationResultGroup);
    if (!validationResultGroup.IsValid)
      throw new DataValidationException((IDataValidationResult) validationResultGroup);
  }

  public bool GetIsValid()
  {
    try
    {
      this.ValidateData();
      return true;
    }
    catch (DataValidationException ex)
    {
      return false;
    }
  }

  public void ValidateData(DataValidationResultGroup validationResult)
  {
    this.ChildValidateData(validationResult);
  }

  protected abstract void ChildValidateData(DataValidationResultGroup validationResult);
}

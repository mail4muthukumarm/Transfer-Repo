// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels.SaveModelDtoAdapter`3
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Dto;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;

public abstract class SaveModelDtoAdapter<TRepository, TDto, TIdentifier> : 
  DatabaseSaveModel<TRepository, TDto, TIdentifier>,
  ISaveModelDtoAdapter<TDto, TIdentifier>,
  IDatabaseSaveModel<TIdentifier>,
  IDatabaseSaveModel,
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject,
  IUpdateDatabaseModel<TIdentifier>,
  IUniqueObject<TIdentifier>,
  ISaveModelDtoAdapter
  where TRepository : class, IGetByIdRepository<TDto, TIdentifier>, IUpdateRepository<TDto, TIdentifier>, ICreateRepository<TDto, TIdentifier>, IDeleteRepository<TDto, TIdentifier>
  where TDto : DtoBase<TIdentifier>, new()
{
  public SaveModelDtoAdapter(TRepository repository)
    : base(repository)
  {
    this.ChildSetPropertiesFromDto(this.GetDefaultDto());
  }

  public SaveModelDtoAdapter(TDto dto, TRepository repository)
    : base(repository)
  {
    this.Dto = dto ?? throw new ArgumentNullException(nameof (dto));
    this.SetPropertiesFromDto(dto);
  }

  public override bool CanDelete() => this.IsNew;

  public TDto Dto { get; private set; }

  object ISaveModelDtoAdapter.Dto => (object) this.Dto;

  public override bool HasIdentifier() => !this.IsNew;

  protected override void ChildSetPropertiesFromDto(TDto dto) => this.Dto = dto;

  protected override TDto GetDefaultDto() => new TDto();

  protected override TDto GetDto() => this.Dto;

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
  }
}

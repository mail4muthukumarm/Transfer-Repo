// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels.UpdateDatabaseModelBase`3
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Dto;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;

public abstract class UpdateDatabaseModelBase<TRepository, TDto, TIdentifier> : 
  ValidateModelBase,
  IUpdateDatabaseModel<TIdentifier>,
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject,
  IUniqueObject<TIdentifier>,
  ITrackChangesModel
  where TRepository : class, IUpdateRepository<TDto, TIdentifier>, IGetByIdRepository<TDto, TIdentifier>
  where TDto : DtoBase<TIdentifier>
{
  private bool _hasChanges;

  object IUniqueObject.UniqueIdentifier => (object) this.UniqueIdentifier;

  public abstract TIdentifier UniqueIdentifier { get; protected internal set; }

  protected virtual TRepository Repository { get; }

  protected UpdateDatabaseModelBase(TRepository updateRepository)
  {
    this.Repository = updateRepository ?? throw new ArgumentNullException(nameof (updateRepository));
  }

  public virtual void ResetChanges()
  {
    this.SetPropertiesFromDto(this.Repository.GetById(this.UniqueIdentifier));
    this._hasChanges = false;
  }

  public void SaveChanges()
  {
    this.ValidateData();
    this.ChildSaveToDatabase(this.GetDto());
    this.ResetChanges();
  }

  public virtual bool HasChanges() => this._hasChanges;

  public void MarkChanged() => this._hasChanges = true;

  protected virtual void ChildSaveToDatabase(TDto thisDto) => this.Repository.Update(thisDto);

  protected virtual void SetPropertiesFromDto(TDto dto)
  {
    this.UniqueIdentifier = ((UniqueObject<TIdentifier>) (object) dto).UniqueIdentifier;
    this.ChildSetPropertiesFromDto(dto);
  }

  protected abstract TDto GetDto();

  protected abstract void ChildSetPropertiesFromDto(TDto dto);
}

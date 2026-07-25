// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels.DatabaseSaveModel`3
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

public abstract class DatabaseSaveModel<TRepository, TDto, TIdentifier>(TRepository repository) : 
  UpdateDatabaseModelBase<TRepository, TDto, TIdentifier>(repository),
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
  IUniqueObject<TIdentifier>
  where TRepository : class, IGetByIdRepository<TDto, TIdentifier>, IUpdateRepository<TDto, TIdentifier>, ICreateRepository<TDto, TIdentifier>, IDeleteRepository<TDto, TIdentifier>
  where TDto : DtoBase<TIdentifier>
{
  private TIdentifier _uniqueIdentifier;

  object IDatabaseSaveModel.UpdatedId => (object) this.UpdatedId;

  public sealed override TIdentifier UniqueIdentifier
  {
    get => this._uniqueIdentifier;
    protected internal set
    {
      this._uniqueIdentifier = value;
      this.UpdatedId = value;
    }
  }

  public bool IsNew { get; private set; } = true;

  public bool IsDeleted { get; private set; }

  public bool IdChanged
  {
    get
    {
      TIdentifier updatedId = this.UpdatedId;
      ref TIdentifier local = ref updatedId;
      return (object) local == null ? (object) this.UniqueIdentifier == null : !local.Equals((object) this.UniqueIdentifier);
    }
  }

  public TIdentifier UpdatedId { get; private set; }

  public override bool HasChanges() => base.HasChanges() || this.IsNew;

  public override void ResetChanges()
  {
    if (this.IsNew)
      return;
    base.ResetChanges();
  }

  public void DeleteFromDatabase()
  {
    if (!this.IsNew)
    {
      if (!this.CanDelete())
        throw new InvalidOperationException("Cannot delete this object because CanDelete() returned false!");
      this.IsNew = true;
      this.Repository.Delete(this.UniqueIdentifier);
    }
    this.IsDeleted = true;
  }

  public void SetNewId(object identifier)
  {
    if (identifier is TIdentifier identifier1)
      this.SetNewId(identifier1);
    throw new InvalidOperationException("When setting the ID of this object you must use an ID of type " + typeof (TIdentifier).Name);
  }

  public void SetNewId(TIdentifier identifier) => this.UpdatedId = identifier;

  public abstract bool HasIdentifier();

  public virtual bool CanDelete() => true;

  protected sealed override void SetPropertiesFromDto(TDto dto)
  {
    this.IsNew = false;
    base.SetPropertiesFromDto(dto);
  }

  protected override void ChildSaveToDatabase(TDto thisDto)
  {
    if (!((UniqueObject<TIdentifier>) (object) thisDto).UniqueIdentifier.Equals((object) this.UpdatedId))
      throw new InvalidOperationException("When creating a DTO for a DatabaseSaveModel the DTO's UniqueIdentifier must be populated with the UpdatedId of this object.");
    if (this.IsNew)
      this.UniqueIdentifier = this.Repository.Insert(thisDto);
    else
      ((IExecuteTransaction) (object) this.Repository).ExecuteAsTransaction((Action) (() =>
      {
        if (this.IdChanged)
        {
          this.Repository.Delete(this.UniqueIdentifier);
          this.Repository.Insert(thisDto);
          this.UniqueIdentifier = ((UniqueObject<TIdentifier>) (object) thisDto).UniqueIdentifier;
        }
        else
          this.Repository.Update(thisDto);
      }));
    this.IsDeleted = false;
    this.IsNew = false;
  }

  protected abstract TDto GetDefaultDto();
}

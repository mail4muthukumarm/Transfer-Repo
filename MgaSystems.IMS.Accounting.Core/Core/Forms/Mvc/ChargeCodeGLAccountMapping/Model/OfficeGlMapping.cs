// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model.OfficeGlMapping
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice;
using MGASystems.IMS.Accounting.Core.DataAccess.GLAccount;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model;

public class OfficeGlMapping : ITrackChanges
{
  private readonly ClientOfficeDto _clientOfficeDto;
  private ChargeCodeGLAccountMappingDto _existingMapping;
  private bool _modified;

  public OfficeGlMapping(
    ClientOfficeDto clientOfficeDto,
    ChargeCodeGLAccountMappingDto existingMapping,
    IEnumerable<GLAccountDto> glAccounts)
  {
    this._clientOfficeDto = clientOfficeDto ?? throw new ArgumentNullException(nameof (clientOfficeDto));
    this._existingMapping = existingMapping;
    this.GlAccounts = glAccounts;
    if (this._existingMapping == null)
      return;
    if (!this._existingMapping.GlAccountId.HasValue)
      this.GlAccount = (GLAccountDto) null;
    else
      this.GlAccount = this.GlAccounts.First<GLAccountDto>((Func<GLAccountDto, bool>) (x =>
      {
        int glAccountId1 = x.GlAccountId;
        int? glAccountId2 = this._existingMapping.GlAccountId;
        int valueOrDefault = glAccountId2.GetValueOrDefault();
        return glAccountId1 == valueOrDefault & glAccountId2.HasValue;
      }));
  }

  public GLAccountDto GlAccount { get; set; }

  public int ClientOfficeId => this._clientOfficeDto.OfficeId;

  public string Name => this._clientOfficeDto.Location;

  public IEnumerable<GLAccountDto> GlAccounts { get; }

  public int DatabaseId
  {
    get
    {
      return (this._existingMapping ?? throw new InvalidOperationException("Cannot access DatabaseId unless there is an existing mapping!")).Id;
    }
  }

  public DateTime? LastModifiedDate => this._existingMapping?.LastModifiedDate;

  public string LastModifiedUser => this._existingMapping?.LastModifiedUserName;

  public bool IsEditable
  {
    get
    {
      ChargeCodeGLAccountMappingDto existingMapping = this._existingMapping;
      return existingMapping == null || existingMapping.IsEditable;
    }
  }

  public bool HasExistingMapping() => this._existingMapping != null;

  public bool HasDirtyData()
  {
    if (this.GlAccount == null)
      return this.HasExistingMapping() && this._existingMapping.GlAccountId.HasValue;
    if (this.HasExistingMapping())
    {
      int? glAccountId1 = this._existingMapping.GlAccountId;
      int glAccountId2 = this.GlAccount.GlAccountId;
      if (glAccountId1.GetValueOrDefault() == glAccountId2 & glAccountId1.HasValue)
        return false;
    }
    return true;
  }

  public void UpdateDatabaseRecord(ChargeCodeGLAccountMappingDto updatedMapping)
  {
    this._existingMapping = updatedMapping;
  }

  public bool HasChanges() => this._modified;

  public void MarkChanged() => this._modified = true;

  public void SetGLAccountToDatabaseValue()
  {
    if (!this._existingMapping.GlAccountId.HasValue)
    {
      this.GlAccount = (GLAccountDto) null;
    }
    else
    {
      this.GlAccount = this.GlAccounts.First<GLAccountDto>((Func<GLAccountDto, bool>) (x =>
      {
        int glAccountId1 = x.GlAccountId;
        int? glAccountId2 = this._existingMapping.GlAccountId;
        int valueOrDefault = glAccountId2.GetValueOrDefault();
        return glAccountId1 == valueOrDefault & glAccountId2.HasValue;
      }));
      this.ResetChanges();
    }
  }

  public void ResetChanges() => this._modified = false;
}

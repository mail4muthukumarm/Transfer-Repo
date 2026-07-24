// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericBusinessObject.GenericPolicyData
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures;
using MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects.GenericBusinessObject;

public class GenericPolicyData : IPolicyData
{
  private string _description;
  private BindingList<PolicyDataElement> _policyDataElements;
  private BindingList<IPolicyEntity> _policyEntities;
  private Guid _quoteGuid;
  private int _quoteID;
  private MGASystems.BusinessObjects.GenericBusinessObject.GenericBusinessObject _parentPolicies;

  public GenericPolicyData(
    string Description,
    Guid QuoteGuid,
    int QuoteID,
    ref MGASystems.BusinessObjects.GenericBusinessObject.GenericBusinessObject ParentPolicies)
  {
    this._description = Description;
    this._policyDataElements = new BindingList<PolicyDataElement>();
    this._policyEntities = new BindingList<IPolicyEntity>();
    this._quoteGuid = QuoteGuid;
    this._quoteID = QuoteID;
    this._parentPolicies = ParentPolicies;
  }

  public string Description => this._description;

  public BindingList<PolicyDataElement> PolicyDataElements => this._policyDataElements;

  public BindingList<IPolicyEntity> PolicyEntities => this._policyEntities;

  public Guid QuoteGuid => this._quoteGuid;

  public int QuoteID => this._quoteID;

  public void AddPolicyDataElement(
    PolicyDataTypeElement policyDataTypeElement,
    string policyDataTypeElementData)
  {
    PolicyDataElement policyDataElement = new PolicyDataElement(policyDataTypeElement, policyDataTypeElementData);
    if (this._policyDataElements.Contains(policyDataElement))
      return;
    this._policyDataElements.Add(policyDataElement);
  }

  public void AddPolicyEntity(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType policyEntityType)
  {
    IEnumerable<IPolicyEntity> source = this._policyEntities.Where<IPolicyEntity>((System.Func<IPolicyEntity, bool>) ([SpecialName] (e) => e.EntityGuid == EntityGuid));
    System.Func<IPolicyEntity, IPolicyEntity> selector;
    // ISSUE: reference to a compiler-generated field
    if (GenericPolicyData._Closure\u0024__.\u0024I18\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = GenericPolicyData._Closure\u0024__.\u0024I18\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GenericPolicyData._Closure\u0024__.\u0024I18\u002D1 = selector = (System.Func<IPolicyEntity, IPolicyEntity>) ([SpecialName] (e) => e);
    }
    if (source.Select<IPolicyEntity, IPolicyEntity>(selector).Count<IPolicyEntity>() != 0)
      return;
    this.FillEntityData(EntityData, EntityGuid, policyEntityType);
  }

  protected virtual void FillEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    switch (EntityType)
    {
      case PolicyEntityType.Insured:
        this.FillInsuredEntityData(EntityData, EntityGuid, EntityType);
        break;
      case PolicyEntityType.Company:
        this.FillCompanyEntityData(EntityData, EntityGuid, EntityType);
        break;
      case PolicyEntityType.AdditionalInterest:
        this.FillAdditionalInterestEntityData(EntityData, EntityGuid, EntityType);
        break;
      case PolicyEntityType.CompanyLocation:
        this.FillCompanyLocationEntityData(EntityData, EntityGuid, EntityType);
        break;
      case PolicyEntityType.QuotingLocation:
        this.FillQuotingLocationEntityData(EntityData, EntityGuid, EntityType);
        break;
      case PolicyEntityType.IssuingLocation:
        this.FillIssuingLocationEntityData(EntityData, EntityGuid, EntityType);
        break;
    }
  }

  protected virtual void FillInsuredEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    string description = this.Description;
    Guid EntityGuid1 = EntityGuid;
    int EntityType1 = (int) EntityType;
    GenericPolicyData genericPolicyData = this;
    ref GenericPolicyData local = ref genericPolicyData;
    GenericPolicyEntity genericPolicyEntity = new GenericPolicyEntity(description, EntityGuid1, (PolicyEntityType) EntityType1, ref local);
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredFirstName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredFirstName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FirstName, EntityData["InsuredFirstName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredLastName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredLastName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.LastName, EntityData["InsuredLastName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredMiddleName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredMiddleName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.MiddleName, EntityData["InsuredMiddleName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredSalutation"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredSalutation"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Salutation, EntityData["InsuredSalutation"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredCorporationName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredCorporationName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.BusinessName, EntityData["InsuredCorporationName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["BusinessType"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["BusinessType"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.BusinessType, EntityData["BusinessType"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredFEIN"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredFEIN"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FEIN, EntityData["InsuredFEIN"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredSSN"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredSSN"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.SSN, EntityData["InsuredSSN"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredAddress1"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredAddress1"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address1, EntityData["InsuredAddress1"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredAddress2"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredAddress2"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address2, EntityData["InsuredAddress2"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredCity"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredCity"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.City, EntityData["InsuredCity"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredState"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredState"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.State, EntityData["InsuredState"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredCounty"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredCounty"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.County, EntityData["InsuredCounty"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredZipCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredZipCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipCode, EntityData["InsuredZipCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredZipPlus"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredZipPlus"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipPlus, EntityData["InsuredZipPlus"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredISOCountryCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredISOCountryCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.CountryCode, EntityData["InsuredISOCountryCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredRegion"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredRegion"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Region, EntityData["InsuredRegion"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredPhone"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredPhone"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Phone, EntityData["InsuredPhone"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["InsuredFax"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["InsuredFax"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Fax, EntityData["InsuredFax"].ToString());
    this._policyEntities.Add((IPolicyEntity) genericPolicyEntity);
  }

  protected virtual void FillCompanyLocationEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    string Description = EntityData["Name"].ToString();
    Guid EntityGuid1 = EntityGuid;
    int EntityType1 = (int) EntityType;
    GenericPolicyData genericPolicyData = this;
    ref GenericPolicyData local = ref genericPolicyData;
    GenericPolicyEntity genericPolicyEntity = new GenericPolicyEntity(Description, EntityGuid1, (PolicyEntityType) EntityType1, ref local);
    genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Name, EntityData["Name"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address1"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address1"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address1, EntityData["Address1"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address2"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address2"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address2, EntityData["Address2"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["City"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["City"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.City, EntityData["City"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["State"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["State"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.State, EntityData["State"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipCode, EntityData["ZipCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipPlus"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipPlus"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipPlus, EntityData["ZipPlus"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["County"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["County"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.County, EntityData["County"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ISOCountryCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ISOCountryCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.CountryCode, EntityData["ISOCountryCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Region"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Region"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Region, EntityData["Region"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Phone"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Phone"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Phone, EntityData["Phone"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Fax"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Fax"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Fax, EntityData["Fax"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["LocationCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["LocationCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.LocationCode, EntityData["LocationCode"].ToString());
    this._policyEntities.Add((IPolicyEntity) genericPolicyEntity);
  }

  protected virtual void FillCompanyEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    string Description = EntityData["CompanyName"].ToString();
    Guid EntityGuid1 = EntityGuid;
    int EntityType1 = (int) EntityType;
    GenericPolicyData genericPolicyData = this;
    ref GenericPolicyData local = ref genericPolicyData;
    GenericPolicyEntity genericPolicyEntity = new GenericPolicyEntity(Description, EntityGuid1, (PolicyEntityType) EntityType1, ref local);
    genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Name, EntityData["CompanyName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["FEIN"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["FEIN"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FEIN, EntityData["FEIN"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["NAIC"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["NAIC"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.NAIC, EntityData["NAIC"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["NYSDMVID"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["NYSDMVID"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.NYSDMVID, EntityData["NYSDMVID"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["NYSDMVEncryptionKey"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["NYSDMVEncryptionKey"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.NYSDMVEncryptionKey, EntityData["NYSDMVEncryptionKey"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["NYSDMVEncryptionPassphrase"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["NYSDMVEncryptionPassphrase"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.NYSDMVEncryptionPassphrase, EntityData["NYSDMVEncryptionPassphrase"].ToString());
    this._policyEntities.Add((IPolicyEntity) genericPolicyEntity);
  }

  protected virtual void FillQuotingLocationEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    string Description = EntityData["Location"].ToString();
    Guid EntityGuid1 = EntityGuid;
    int EntityType1 = (int) EntityType;
    GenericPolicyData genericPolicyData = this;
    ref GenericPolicyData local = ref genericPolicyData;
    GenericPolicyEntity genericPolicyEntity = new GenericPolicyEntity(Description, EntityGuid1, (PolicyEntityType) EntityType1, ref local);
    genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Name, EntityData["Location"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["DBA"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["DBA"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.DBA, EntityData["DBA"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address1"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address1"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address1, EntityData["Address1"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address2"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address2"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address2, EntityData["Address2"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["City"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["City"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.City, EntityData["City"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["State"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["State"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.State, EntityData["State"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipCode, EntityData["ZipCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipPlus"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipPlus"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipPlus, EntityData["ZipPlus"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["County"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["County"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.County, EntityData["County"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ISOCountryCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ISOCountryCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.CountryCode, EntityData["ISOCountryCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Region"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Region"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Region, EntityData["Region"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Phone"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Phone"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Phone, EntityData["Phone"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Fax"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Fax"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Fax, EntityData["Fax"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["FEIN"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["FEIN"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FEIN, EntityData["FEIN"].ToString());
    this._policyEntities.Add((IPolicyEntity) genericPolicyEntity);
  }

  protected virtual void FillIssuingLocationEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    string Description = EntityData["Location"].ToString();
    Guid EntityGuid1 = EntityGuid;
    int EntityType1 = (int) EntityType;
    GenericPolicyData genericPolicyData = this;
    ref GenericPolicyData local = ref genericPolicyData;
    GenericPolicyEntity genericPolicyEntity = new GenericPolicyEntity(Description, EntityGuid1, (PolicyEntityType) EntityType1, ref local);
    genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Name, EntityData["Location"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["DBA"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["DBA"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.DBA, EntityData["DBA"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address1"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address1"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address1, EntityData["Address1"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address2"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address2"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address2, EntityData["Address2"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["City"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["City"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.City, EntityData["City"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["State"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["State"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.State, EntityData["State"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipCode, EntityData["ZipCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipPlus"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipPlus"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipPlus, EntityData["ZipPlus"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["County"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["County"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.County, EntityData["County"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ISOCountryCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ISOCountryCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.CountryCode, EntityData["ISOCountryCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Region"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Region"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Region, EntityData["Region"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Phone"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Phone"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Phone, EntityData["Phone"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Fax"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Fax"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Fax, EntityData["Fax"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["FEIN"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["FEIN"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FEIN, EntityData["FEIN"].ToString());
    this._policyEntities.Add((IPolicyEntity) genericPolicyEntity);
  }

  protected virtual void FillAdditionalInterestEntityData(
    DataRow EntityData,
    Guid EntityGuid,
    PolicyEntityType EntityType)
  {
    string Description = EntityData["InterestName"].ToString();
    Guid EntityGuid1 = EntityGuid;
    int EntityType1 = (int) EntityType;
    GenericPolicyData genericPolicyData = this;
    ref GenericPolicyData local = ref genericPolicyData;
    GenericPolicyEntity genericPolicyEntity = new GenericPolicyEntity(Description, EntityGuid1, (PolicyEntityType) EntityType1, ref local);
    genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Name, EntityData["InterestName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["FirstName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["FirstName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FirstName, EntityData["FirstName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["MiddleName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["MiddleName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.MiddleName, EntityData["MiddleName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["LastName"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["LastName"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.LastName, EntityData["LastName"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address1"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address1"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address1, EntityData["Address1"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Address2"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Address2"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Address2, EntityData["Address2"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["City"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["City"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.City, EntityData["City"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["StateID"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["StateID"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.State, EntityData["StateID"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipCode, EntityData["ZipCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ZipPlus"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ZipPlus"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.ZipPlus, EntityData["ZipPlus"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["County"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["County"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.County, EntityData["County"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["ISOCountryCode"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["ISOCountryCode"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.CountryCode, EntityData["ISOCountryCode"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Region"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Region"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Region, EntityData["Region"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Phone"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Phone"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Phone, EntityData["Phone"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["Fax"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["Fax"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.Fax, EntityData["Fax"].ToString());
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(EntityData["FEIN"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EntityData["FEIN"].ToString(), string.Empty, false) != 0)
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.FEIN, EntityData["FEIN"].ToString());
    string[] strArray = EntityData["InterestTypes"].ToString().Split(new string[1]
    {
      ","
    }, StringSplitOptions.RemoveEmptyEntries);
    int index = 0;
    while (index < strArray.Length)
    {
      string policyEntityTypeElementData = strArray[index];
      genericPolicyEntity.AddEntityElement(PolicyEntityTypeElement.AdditionalInterestType, policyEntityTypeElementData);
      checked { ++index; }
    }
    this._policyEntities.Add((IPolicyEntity) genericPolicyEntity);
  }
}

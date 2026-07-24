// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericBusinessObject.GenericPolicyEntity
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures;
using MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;
using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.BusinessObjects.GenericBusinessObject;

public class GenericPolicyEntity : IPolicyEntity
{
  private string _description;
  private Guid _entityGuid;
  private PolicyEntityType _entityType;
  private BindingList<PolicyEntityElement> _policyEntityElements;
  private GenericPolicyData _parentPolicyData;

  public GenericPolicyEntity(
    string Description,
    Guid EntityGuid,
    PolicyEntityType EntityType,
    ref GenericPolicyData ParentPolicyData)
  {
    this._description = Description;
    this._entityGuid = EntityGuid;
    this._entityType = EntityType;
    this._policyEntityElements = new BindingList<PolicyEntityElement>();
    this._parentPolicyData = ParentPolicyData;
  }

  public void AddEntityElement(
    PolicyEntityTypeElement policyEntityTypeElement,
    string policyEntityTypeElementData)
  {
    PolicyEntityElement policyEntityElement = new PolicyEntityElement(policyEntityTypeElement, policyEntityTypeElementData);
    if (this._policyEntityElements.Contains(policyEntityElement))
      return;
    this._policyEntityElements.Add(policyEntityElement);
  }

  public string Description => this._description;

  public Guid EntityGuid => this._entityGuid;

  public PolicyEntityType EntityType => this._entityType;

  public BindingList<PolicyEntityElement> PolicyEntityElements => this._policyEntityElements;
}

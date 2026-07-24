// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes.PolicyEntityElement
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;

public class PolicyEntityElement
{
  private PolicyEntityTypeElement _policyEntityType;
  private string _description;

  public PolicyEntityElement(PolicyEntityTypeElement policyEntityTypeElement, string description)
  {
    this._policyEntityType = policyEntityTypeElement;
    this._description = description;
  }

  public PolicyEntityTypeElement ElementType => this._policyEntityType;

  public string Description => this._description;
}

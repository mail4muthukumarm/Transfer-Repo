// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.CoverageTypes.CoverageElement
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures.CoverageTypes;

public class CoverageElement
{
  private CoverageTypeElement _elementType;
  private string _description;

  public CoverageElement(CoverageTypeElement coverageTypeElement, string description)
  {
    this._elementType = coverageTypeElement;
    this._description = description;
  }

  public CoverageTypeElement ElementType => this._elementType;

  public string Description => this._description;
}

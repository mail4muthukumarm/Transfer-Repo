// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.LocationInspectionCompany
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class LocationInspectionCompany
{
  private int _inspectionCompany;
  private int _locationID;
  private bool _roof;
  private bool _successSent;

  public LocationInspectionCompany(int inspectionCompanyID, int locationID, bool roof)
  {
    this._inspectionCompany = inspectionCompanyID;
    this._locationID = locationID;
    this._roof = roof;
  }

  public int InspectionCompany => this._inspectionCompany;

  public int Location => this._locationID;

  public bool Roof => this._roof;

  public bool SuccessfullySent
  {
    get => this._successSent;
    set => this._successSent = value;
  }
}

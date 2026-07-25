// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Inspectionresult
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[Serializable]
public class Inspectionresult
{
  public object Errors
  {
    get => this._Errors;
    set => this._Errors = RuntimeHelpers.GetObjectValue(value);
  }

  public object Messages
  {
    get => this._Messages;
    set => this._Messages = RuntimeHelpers.GetObjectValue(value);
  }

  public object CarrierID
  {
    get => this._CarrierID;
    set => this._CarrierID = RuntimeHelpers.GetObjectValue(value);
  }

  public string InspectionID { get; set; }

  public int InspectionNumber { get; set; }

  public bool Success { get; set; }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.LossControlResponse
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[Serializable]
public class LossControlResponse
{
  public Inspectionresult InspectionResults { get; set; }

  public object BaseImportError
  {
    get => this._BaseImportError;
    set => this._BaseImportError = RuntimeHelpers.GetObjectValue(value);
  }
}

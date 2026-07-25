// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyBusinessObjects.BindingValidationResult
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyBusinessObjects;

public class BindingValidationResult
{
  public List<string> HardStopReasons { get; }

  public List<string> SoftStopReasons { get; }

  public bool HasHardStops => this.HardStopReasons != null && this.HardStopReasons.Count > 0;

  public bool HasSoftStops => this.SoftStopReasons != null && this.SoftStopReasons.Count > 0;

  public BindingValidationResult()
  {
    this.HardStopReasons = new List<string>();
    this.SoftStopReasons = new List<string>();
  }
}

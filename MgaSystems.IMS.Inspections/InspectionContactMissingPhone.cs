// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.InspectionContactMissingPhone
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class InspectionContactMissingPhone : Exception
{
  public override string Message => "An inspection contact has no phone number.";
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.InspectionClientCodeNotFoundException
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
public class InspectionClientCodeNotFoundException : Exception
{
  public override string Message
  {
    get => "An inspection client code was not found for one or more locations on the policy.";
  }
}

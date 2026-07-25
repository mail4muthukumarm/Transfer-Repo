// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.NoInspectionCompanyEmailException
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
public class NoInspectionCompanyEmailException : Exception
{
  private string _inspectionCompanyName;

  public NoInspectionCompanyEmailException(string inspectionCompanyName)
  {
    this._inspectionCompanyName = inspectionCompanyName;
  }

  public override string Message
  {
    get => $"Unable to determine the email address for {this._inspectionCompanyName}.";
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.DefaultColumnAttribute
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public sealed class DefaultColumnAttribute : Attribute
{
  public string Column { get; private set; }

  public DefaultColumnAttribute(string column) => this.Column = column;

  public DefaultColumnAttribute(bool isRoofGeometry)
  {
    this.Column = "[RoofGeometry] Roof geometry (Note: Must be 100% \"Hip\" to be considered \"Hip\")";
  }
}

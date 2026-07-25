// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.SecureReportResourceAttribute
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using MGASystems.Common;
using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Security;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class SecureReportResourceAttribute : SecureResourceAttribute
{
  private string _reportDescription;
  private string _reportCategory;

  public string ReportDescription => this._reportDescription;

  public string ReportCategory => this._reportCategory;

  public SecureReportResourceAttribute(
    string uniqueIdentifier,
    string name,
    string reportDescription,
    string reportCategory)
    : base(uniqueIdentifier, name, $"Controls access to the {name} report.", "Reports")
  {
    this._reportDescription = reportDescription;
    this._reportCategory = reportCategory;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public SecureReportResourceAttribute()
  {
  }
}

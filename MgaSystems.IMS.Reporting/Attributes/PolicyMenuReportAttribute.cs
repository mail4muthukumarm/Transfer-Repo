// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.Attributes.PolicyMenuReportAttribute
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Reporting.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class PolicyMenuReportAttribute : Attribute
{
  private string _policyMenuReportName;

  public PolicyMenuReportAttribute(string policyMenuReportName)
  {
    this._policyMenuReportName = policyMenuReportName;
  }

  public string PolicyMenuReportName => this._policyMenuReportName;

  public override bool Match(object obj) => obj is PolicyMenuReportAttribute;
}

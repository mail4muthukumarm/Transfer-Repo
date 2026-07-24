// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolSecurity
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.IMS.Security;

#nullable disable
namespace MgaSystems.IMS.Policies;

[SecureResource("{28FFB4F9-5DD6-4505-9AEC-A215AD626DC4}", "Authority Limit Admin", "Controls the ability to access authority limit admin.", "Administration")]
[SecureResource("{12141738-9898-45DC-993C-A1203A8D030C}", "Approve Authority Limit", "Controls the ability to approve authority limit infractions.", "Policy")]
[SecureResource("{9784D2C2-E5C1-48FA-9E45-60916C002C5F}", "Create Quote", "Controls the ability to access Create Qupte menu item.", "Tools")]
[SecureResource("{86330772-9A5F-40C6-BF9E-E3EE15E07858}", "Threshold Limit Admin", "Controls the ability to access threshold limit admin.", "Administration")]
[SecureResource("{9F8BDE05-3148-4E7D-8AE5-4A3AA0B761C9}", "Approve Threshold Limit", "Controls the ability to approve threshold limit infractions.", "Policy")]
public static class PolSecurity
{
  private const string canAccessAuthorityLimitAdmin = "{28FFB4F9-5DD6-4505-9AEC-A215AD626DC4}";
  private const string canApproveAuthorityLimit = "{12141738-9898-45DC-993C-A1203A8D030C}";
  private const string canAccessCreateQuote = "{9784D2C2-E5C1-48FA-9E45-60916C002C5F}";
  private const string canAccessThresholdLimitAdmin = "{86330772-9A5F-40C6-BF9E-E3EE15E07858}";
  private const string canApproveThresholdLimit = "{9F8BDE05-3148-4E7D-8AE5-4A3AA0B761C9}";
  public static bool CanAccessAuthorityLimitAdmin = PolSecurity.Assert("{28FFB4F9-5DD6-4505-9AEC-A215AD626DC4}");
  public static bool CanApproveAuthorityLimit = PolSecurity.Assert("{12141738-9898-45DC-993C-A1203A8D030C}");
  public static bool CanAccessCreateQuote = PolSecurity.Assert("{9784D2C2-E5C1-48FA-9E45-60916C002C5F}");
  public static bool CanAccessThresholdLimitAdmin = PolSecurity.Assert("{86330772-9A5F-40C6-BF9E-E3EE15E07858}");
  public static bool CanApproveThresholdLimit = PolSecurity.Assert("{9F8BDE05-3148-4E7D-8AE5-4A3AA0B761C9}");

  private static bool Assert(string resource)
  {
    return Information.IsDesignMode || SecurityManager.Instance.AssertPermission(resource);
  }
}

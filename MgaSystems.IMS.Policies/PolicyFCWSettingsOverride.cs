// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyFCWSettingsOverride
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;

#nullable disable
namespace MGASystems.IMS.Policies;

public class PolicyFCWSettingsOverride
{
  public virtual bool ShouldShowAdditionalComments(Quote quote)
  {
    return SystemSettings.KeyExists("ShowPolicyFCWAlways") && SystemSettings.GetBoolSetting("ShowPolicyFCWAlways");
  }
}

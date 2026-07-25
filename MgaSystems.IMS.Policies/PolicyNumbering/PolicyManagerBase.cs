// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyNumbering.PolicyManagerBase
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyNumbering;

public abstract class PolicyManagerBase
{
  public abstract PolicyEngineBase GetPolicyEngine(Guid quoteGuid, Guid companyLineGuid);
}

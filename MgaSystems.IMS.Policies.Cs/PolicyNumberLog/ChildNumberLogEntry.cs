// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberLog.ChildNumberLogEntry
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;

#nullable disable
namespace MgaSystems.IMS.Policies.PolicyNumberLog;

public class ChildNumberLogEntry
{
  public int? QuoteId { get; set; }

  public string PolicyNumber { get; set; }

  public int? RuleIndex { get; set; }

  public string RuleName { get; set; }

  public string CompanyLine { get; set; }

  public string Action { get; set; }

  public DateTime ActionDate { get; set; }

  public string HostName { get; set; }
}

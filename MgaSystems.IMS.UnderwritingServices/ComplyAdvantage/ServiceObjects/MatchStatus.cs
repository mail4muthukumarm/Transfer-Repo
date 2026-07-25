// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.MatchStatus
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public static class MatchStatus
{
  public const string Unknown = "unknown";
  public const string NoMatch = "no_match";
  public const string PotentialMatch = "potential_match";
  public const string FalsePositive = "false_positive";
  public const string TruePositive = "true_positive";
  public const string TruePositiveApprove = "true_positive_approve";
  public const string TruePositiveReject = "true_positive_reject";
  public static readonly HashSet<string> GoodStatuses = new HashSet<string>()
  {
    "no_match",
    "false_positive",
    "true_positive_approve"
  };
}

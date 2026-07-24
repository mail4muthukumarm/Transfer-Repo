// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Rating.IRater
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.BusinessObjects.Rating;

public interface IRater : IDisposable
{
  void CopyQuoteData(Guid originalQuoteGuid, Guid newQuoteGuid, SqlTransaction t);

  void CopyBoundOptions(Guid originalQuoteGuid, Guid newQuoteGuid, SqlTransaction t);

  string GetOptionDescription(Guid quoteOptionGuid);

  bool HasUI { get; }

  void ShowUI();

  event EventHandler UIClosed;

  void CalculateAllOptions();

  void DoNonUIWork();

  Guid QuoteGuid { get; }

  Guid LineGuid { get; }

  string LineName { get; }

  void InitializeState(Guid quoteGuid, Guid companyLineGuid);

  void InitializeState(Quote quote, Guid companyLineGuid);

  void RateOption(Guid quoteOptionGuid);

  bool IsReadyForBind { get; }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  List<string> NotReadyToBindReason { get; }

  bool IsReadyForPolicyIssuance { get; }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  List<string> NotReadyForPolicyIssuanceReasons { get; }

  bool SupportsUnderwritingLocations { get; }

  void PreBind();

  event OptionRatedEventHandler OptionRated;

  [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "0#")]
  bool DoesConditionApply(int conditionalID, ConditionalOperators conditions, object amount);

  List<RaterConditionalElement> RaterConditionalElements(string LineCode);
}

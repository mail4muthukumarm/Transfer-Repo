// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.AccountInquiryResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Text.RegularExpressions;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public class AccountInquiryResponse : BaseResponse
{
  private static readonly Regex ParseValidRegex = new Regex("Accept:(?<ValidDays>\\d+)", RegexOptions.IgnoreCase);

  internal AccountInquiryResponse(string responseString)
    : base(responseString)
  {
    if (this.ResponseType != ReportType.Unknown)
      return;
    Match match = AccountInquiryResponse.ParseValidRegex.Match(responseString);
    if (match == null || !match.Success)
      return;
    this.ResponseType = ReportType.Accept;
    Group group = match.Groups[nameof (ValidDays)];
    int result;
    if (group == null || !group.Success || !int.TryParse(group.Value, out result))
      return;
    this.ValidDays = new int?(result);
  }

  internal AccountInquiryResponse(Exception responseException, string rawResponse)
    : this("Error:Exception encountered, " + responseException.Message)
  {
    this.RawResponse = rawResponse;
  }

  public bool IsAcceptResponse => this.ResponseType == ReportType.Accept && this.ValidDays.HasValue;

  public int? ValidDays { get; }
}

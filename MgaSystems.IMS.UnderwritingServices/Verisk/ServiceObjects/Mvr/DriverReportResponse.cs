// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.DriverReportResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Text.RegularExpressions;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public class DriverReportResponse : BaseResponse
{
  private static readonly Regex ParseAcceptRegex = new Regex("Accept:(?<AcceptID>\\d{9,})?(?<ResponseDescription>.+)", RegexOptions.IgnoreCase);

  internal DriverReportResponse(string responseString)
    : base(responseString)
  {
    if (this.ResponseType != ReportType.Unknown)
      return;
    Match match = DriverReportResponse.ParseAcceptRegex.Match(responseString);
    if (match == null || !match.Success)
      return;
    this.ResponseType = ReportType.Accept;
    this.ResponseDescription = match.Groups["ResponseDescription"].Value;
    Group group = match.Groups[nameof (AcceptID)];
    long result;
    if (group == null || !group.Success || !long.TryParse(group.Value, out result))
      return;
    this.AcceptID = new long?(result);
  }

  internal DriverReportResponse(Exception responseException, string rawResponse)
    : this("Error:Exception encountered, " + responseException.Message)
  {
    this.RawResponse = rawResponse;
  }

  public long? AcceptID { get; }

  public bool IsAcceptResponse => this.ResponseType == ReportType.Accept && this.AcceptID.HasValue;
}

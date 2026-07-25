// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.BaseResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Text.RegularExpressions;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public abstract class BaseResponse
{
  private static readonly Regex ParseErrorRegex = new Regex("Error:(?<ResponseDescription>.+)", RegexOptions.IgnoreCase);

  protected BaseResponse(string responseString)
  {
    this.RawResponse = responseString;
    Match match = BaseResponse.ParseErrorRegex.Match(responseString);
    if (match == null || !match.Success)
      return;
    this.ResponseType = ReportType.Error;
    this.ResponseDescription = match.Groups[nameof (ResponseDescription)].Value;
  }

  protected BaseResponse(Exception responseException, string rawResponse)
    : this("Error:Exception encountered, " + responseException.Message)
  {
    if (!string.IsNullOrEmpty(rawResponse))
      this.RawResponse = rawResponse;
    this.CreateException = responseException;
  }

  public string RawResponse { get; protected set; }

  public ReportType ResponseType { get; protected set; }

  public string ResponseDescription { get; protected set; }

  public Exception CreateException { get; protected set; }

  public bool IsErrorResponse
  {
    get => this.ResponseType == ReportType.Error || this.CreateException != null;
  }
}

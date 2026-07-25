// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.ReportPdfResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public class ReportPdfResponse : BaseResponse
{
  internal ReportPdfResponse(string responseString)
    : base(responseString)
  {
    if (this.ResponseType != ReportType.Unknown)
      return;
    this.ResponseType = ReportType.Pdf;
    try
    {
      this.PdfBytes = Convert.FromBase64String(responseString);
    }
    catch (Exception ex)
    {
      this.CreateException = (Exception) new InvalidOperationException("Failed to parse base64 response text as PDF; " + ex.Message, ex);
    }
  }

  internal ReportPdfResponse(Exception responseException, string rawString)
    : base(responseException, rawString)
  {
    this.ResponseType = ReportType.Pdf;
  }

  public bool IsValidReport
  {
    get
    {
      if (this.ResponseType != ReportType.Pdf)
        return false;
      byte[] pdfBytes = this.PdfBytes;
      return pdfBytes != null && pdfBytes.Length != 0;
    }
  }

  public byte[] PdfBytes { get; }
}

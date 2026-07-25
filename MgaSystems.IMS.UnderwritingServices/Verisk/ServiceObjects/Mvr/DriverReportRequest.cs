// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.DriverReportRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public class DriverReportRequest : BaseRequest
{
  public char OrderPurpose { get; set; }

  public string State { get; set; }

  public string JulianDate { get; set; }

  public string RecordSequenceNumber { get; set; }

  public string DriversLicenseNumber { get; set; }

  internal string CleanDriversLicenseNumber
  {
    get => this.DriversLicenseNumber?.Replace("-", "").Replace(" ", "").ToUpper();
  }

  public string LastName { get; set; }

  public string Suffix { get; set; }

  public string FirstName { get; set; }

  public string MiddleName { get; set; }

  public DateTime? DateOfBirth { get; set; }

  public string Gender { get; set; }

  public string ClientCode { get; set; }

  public string QuoteBack { get; set; }

  public string RequestType { get; set; }

  public string FormatID { get; set; } = "V20";

  public string RFlag { get; set; } = " ";

  public string SSN { get; set; }

  public string Extension { get; set; }
}

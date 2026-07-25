// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.DriverInfoTags
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Microsoft.VisualBasic.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

[StandardModule]
public sealed class DriverInfoTags
{
  public static readonly TagInfo LicenseNo = new TagInfo("drv-licenseno", "License No.");
  public static readonly TagInfo FirstName = new TagInfo("drv-firstname", "First Name");
  public static readonly TagInfo LastName = new TagInfo("drv-lastname", "Last Name");
  public static readonly TagInfo Comments = new TagInfo("drv-comments", nameof (Comments));
  public static readonly TagInfo DOB = new TagInfo("drv-dob", "Date of Birth");
  public static readonly TagInfo Status = new TagInfo("drv-status", nameof (Status));
  public static readonly TagInfo State = new TagInfo("drv-state", nameof (State));
  public static readonly TagInfo NoPoints = new TagInfo("drv-nopoints", "No. of Points");
  public static readonly TagInfo Deleted = new TagInfo("drv-deleted", nameof (Deleted));
  public static readonly TagInfo Added = new TagInfo("drv-added", nameof (Added));
  public static readonly TagInfo FullOrPartTime = new TagInfo("drv-fullorparttime", "Full or Part Time");
  public static readonly TagInfo LicenseExp = new TagInfo("drv-licenseexp", "License Expiration");
  public static readonly TagInfo MedicalExp = new TagInfo("drv-medexp", "Medical Expiration");
  public static readonly TagInfo RatingFactor = new TagInfo("drv-ratingfactor", "Rating Factor");
  public static readonly TagInfo LicenseClass = new TagInfo("drv-licclass", "License Class");
  public static readonly TagInfo CDL = new TagInfo("drv-cdl", nameof (CDL));
  public static readonly TagInfo MVR = new TagInfo("drv-mvr", "MVR Date");
  public static readonly TagInfo Street1 = new TagInfo("drv-street1", "Street 1");
  public static readonly TagInfo Street2 = new TagInfo("drv-street2", "Street 2");
  public static readonly TagInfo City = new TagInfo("drv-city", nameof (City));
  public static readonly TagInfo ZipCode = new TagInfo("drv-zip", "Zip Code");
  public static readonly TagInfo FurnishedCar = new TagInfo("drv-furncar", "Furnished Car");
  public static readonly TagInfo CopyRenewql = new TagInfo("drv-copyrnwl", "Copy on Renewal");
  public static readonly TagInfo NoFaultAcc = new TagInfo("drv-faultacc", "No. Fault Accident");
  public static readonly TagInfo NoOtherAcc = new TagInfo("drv-othacc", "No. Other Accident");
  public static readonly TagInfo SpeedLT10 = new TagInfo("drv-spdlt10", "Speeding < 10 MPH");
  public static readonly TagInfo SpeedGT10 = new TagInfo("drv-spdgt10", "Speeding > 10 MPH");
  public static readonly TagInfo SecViolation = new TagInfo("drv-secvio", "Sec Violation");
  public static readonly TagInfo EquipViolation = new TagInfo("drv-equipvio", "Equip Violations");
  public static readonly TagInfo OtherViolation = new TagInfo("drv-othervio", "Other Moving Violations");
  public static readonly TagInfo TotalViolations = new TagInfo("drv-ttlvio", "Total Violations");
  public static readonly TagInfo HireDate = new TagInfo("drv-hiredt", "Hire Date");
  public static readonly TagInfo OrigCDLDate = new TagInfo("drv-cdlorigdt", "Date of Orig CDL");
  public static readonly TagInfo YearsTruckExp = new TagInfo("drv-yrsexp", "Years Log Truck Exp");
  public static readonly TagInfo DriverExcluded = new TagInfo("drv-excluded", "Driver Excluded");
  public static readonly TagInfo Recipient = new TagInfo("drv-recp", nameof (Recipient));
  public static readonly TagInfo Subject = new TagInfo("drv-subj", nameof (Subject));
  public static readonly TagInfo DaysDue = new TagInfo("drv-daysdue", "Days Due");
  public static readonly TagInfo Body = new TagInfo("drv-body", nameof (Body));
}

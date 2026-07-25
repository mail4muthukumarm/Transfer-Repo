// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DriverInfo
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class DriverInfo
{
  public long DriverID { get; set; }

  public int ControlNo { get; set; }

  public Guid QuoteGuid { get; set; }

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public DateTime? DOB { get; set; }

  public string LicenseNumber { get; set; }

  public string StateID { get; set; }

  public int? StatusID { get; set; }

  public DateTime? DateAdded { get; set; }

  public DateTime? DriverDeleted { get; set; }

  public DateTime? DriverAdded { get; set; }

  public string NumberOfPoints { get; set; }

  public bool FurnishedCar { get; set; }

  public string Comments { get; set; }

  public byte? FullPartTime { get; set; }

  public bool? CopyOnRenewal { get; set; }

  public DateTime? ModifiedDate { get; set; }

  public DateTime? LicenseExpDate { get; set; }

  public string Street1 { get; set; }

  public string Street2 { get; set; }

  public string City { get; set; }

  public string ZipCode { get; set; }

  public string ZipPlus { get; set; }

  public Decimal? DriverRatingFactor { get; set; }

  public string LicenseClass { get; set; }

  public string ADRResults { get; set; }

  public string NumAtFaultAcc { get; set; }

  public string NumOtherAcc { get; set; }

  public string SpeedingLessTenMPH { get; set; }

  public string SecVltns { get; set; }

  public string EquipVltns { get; set; }

  public string OtherMovingVltns { get; set; }

  public string TotalVtlns { get; set; }

  public string SpeedingMoreTenMPH { get; set; }

  public DateTime? MedicalExpiration { get; set; }

  public Guid? NoteRecipient { get; set; }

  public string NoteSubject { get; set; }

  public string NoteBody { get; set; }

  public short? DaysDue { get; set; }

  public bool? PopUpNote { get; set; }

  public bool? DiaryNoteSent { get; set; }

  public DateTime? DateOfHire { get; set; }

  public DateTime? DateOfOrigCDL { get; set; }

  public int? YearsLogTruckExperienceNum { get; set; }

  public DateTime? MVRDate { get; set; }

  public int? CDLDriverID { get; set; }

  public string Status { get; set; }

  public string FullOrPartTimeStatus { get; set; }

  public string Recipient { get; set; }

  public DateTime? DriverExcluded { get; set; }

  public DriverInfo(long drvID)
  {
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.StoredProcedure, "spDriverInfoGet", new object[2]
    {
      (object) "@DriverID",
      (object) drvID
    });
    this.DriverID = row.Field<long>(nameof (DriverID));
    this.ControlNo = row.Field<int>(nameof (ControlNo));
    this.QuoteGuid = row.Field<Guid>(nameof (QuoteGuid));
    this.FirstName = row.Field<string>(nameof (FirstName));
    this.LastName = row.Field<string>(nameof (LastName));
    this.DOB = row.Field<DateTime?>(nameof (DOB));
    this.LicenseNumber = row.Field<string>(nameof (LicenseNumber));
    this.StateID = row.Field<string>(nameof (StateID));
    this.StatusID = row.Field<int?>(nameof (StatusID));
    this.DateAdded = row.Field<DateTime?>(nameof (DateAdded));
    this.DriverDeleted = row.Field<DateTime?>(nameof (DriverDeleted));
    this.DriverAdded = row.Field<DateTime?>(nameof (DriverAdded));
    this.NumberOfPoints = row.Field<string>(nameof (NumberOfPoints));
    this.FurnishedCar = row.Field<bool>(nameof (FurnishedCar));
    this.Comments = row.Field<string>(nameof (Comments));
    this.FullPartTime = row.Field<byte?>(nameof (FullPartTime));
    this.CopyOnRenewal = row.Field<bool?>(nameof (CopyOnRenewal));
    this.ModifiedDate = row.Field<DateTime?>(nameof (ModifiedDate));
    this.LicenseExpDate = row.Field<DateTime?>(nameof (LicenseExpDate));
    this.Street1 = row.Field<string>(nameof (Street1));
    this.Street2 = row.Field<string>(nameof (Street2));
    this.City = row.Field<string>(nameof (City));
    this.ZipCode = row.Field<string>(nameof (ZipCode));
    this.ZipPlus = row.Field<string>(nameof (ZipPlus));
    this.DriverRatingFactor = row.Field<Decimal?>(nameof (DriverRatingFactor));
    this.LicenseClass = row.Field<string>(nameof (LicenseClass));
    this.ADRResults = row.Field<string>(nameof (ADRResults));
    this.NumAtFaultAcc = row.Field<string>(nameof (NumAtFaultAcc));
    this.NumOtherAcc = row.Field<string>(nameof (NumOtherAcc));
    this.SpeedingLessTenMPH = row.Field<string>(nameof (SpeedingLessTenMPH));
    this.SecVltns = row.Field<string>(nameof (SecVltns));
    this.EquipVltns = row.Field<string>(nameof (EquipVltns));
    this.OtherMovingVltns = row.Field<string>(nameof (OtherMovingVltns));
    this.TotalVtlns = row.Field<string>(nameof (TotalVtlns));
    this.SpeedingMoreTenMPH = row.Field<string>(nameof (SpeedingMoreTenMPH));
    this.MedicalExpiration = row.Field<DateTime?>(nameof (MedicalExpiration));
    this.NoteRecipient = row.Field<Guid?>(nameof (NoteRecipient));
    this.NoteSubject = row.Field<string>(nameof (NoteSubject));
    this.NoteBody = row.Field<string>(nameof (NoteBody));
    this.DaysDue = row.Field<short?>(nameof (DaysDue));
    this.PopUpNote = row.Field<bool?>(nameof (PopUpNote));
    this.DiaryNoteSent = row.Field<bool?>(nameof (DiaryNoteSent));
    this.DateOfHire = row.Field<DateTime?>(nameof (DateOfHire));
    this.DateOfOrigCDL = row.Field<DateTime?>(nameof (DateOfOrigCDL));
    this.YearsLogTruckExperienceNum = row.Field<int?>(nameof (YearsLogTruckExperienceNum));
    this.MVRDate = row.Field<DateTime?>(nameof (MVRDate));
    this.CDLDriverID = row.Field<int?>(nameof (CDLDriverID));
    this.Status = row.Field<string>(nameof (Status));
    this.FullOrPartTimeStatus = row.Field<string>(nameof (FullOrPartTimeStatus));
    this.Recipient = row.Field<string>(nameof (Recipient));
    this.DriverExcluded = row.Field<DateTime?>(nameof (DriverExcluded));
  }
}

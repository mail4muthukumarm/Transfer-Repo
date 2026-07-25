// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.DriverInfoTagParser
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class DriverInfoTagParser : PolicyTagParser
{
  private long _driverID;

  public DriverInfoTagParser(long DriverID)
    : base(DriverInfoTagParser.GetQuoteGuid(DriverID))
  {
    this._driverID = DriverID;
  }

  private static Guid GetQuoteGuid(long driverID)
  {
    object obj = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteGuid FROM tblDriverInfo WHERE DriverID = @DriverID", new object[2]
    {
      (object) "@DriverID",
      (object) driverID
    });
    return obj == null ? new Guid() : (Guid) obj;
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID)
  {
    DriverInfo driverInfo = new DriverInfo(this._driverID);
    try
    {
      foreach (DocTag tag in tags)
      {
        string lower = tag.InnerTagName.ToLower();
        DateTime? nullable1;
        DateTime dateTime;
        int? nullable2;
        int num;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.LicenseNo.Name, false) == 0)
          tag.TagValue = driverInfo.LicenseNumber;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.FirstName.Name, false) == 0)
          tag.TagValue = driverInfo.FirstName;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.LastName.Name, false) == 0)
          tag.TagValue = driverInfo.LastName;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Comments.Name, false) == 0)
          tag.TagValue = driverInfo.Comments;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.DOB.Name, false) == 0)
        {
          nullable1 = driverInfo.DOB;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.DOB;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Status.Name, false) == 0)
          tag.TagValue = driverInfo.Status;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.State.Name, false) == 0)
          tag.TagValue = driverInfo.StateID;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.NoPoints.Name, false) == 0)
          tag.TagValue = driverInfo.NumberOfPoints;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Deleted.Name, false) == 0)
        {
          nullable1 = driverInfo.DriverDeleted;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.DriverDeleted;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Added.Name, false) == 0)
        {
          nullable1 = driverInfo.DateAdded;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.DateAdded;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.FullOrPartTime.Name, false) == 0)
          tag.TagValue = driverInfo.FullOrPartTimeStatus;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.LicenseExp.Name, false) == 0)
        {
          nullable1 = driverInfo.LicenseExpDate;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.LicenseExpDate;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.MedicalExp.Name, false) == 0)
        {
          nullable1 = driverInfo.MedicalExpiration;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.MedicalExpiration;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.RatingFactor.Name, false) == 0)
        {
          Decimal? driverRatingFactor = driverInfo.DriverRatingFactor;
          if (driverRatingFactor.HasValue)
          {
            DocTag docTag = tag;
            driverRatingFactor = driverInfo.DriverRatingFactor;
            string str = driverRatingFactor.Value.ToString();
            docTag.TagValue = str;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.LicenseClass.Name, false) == 0)
          tag.TagValue = driverInfo.LicenseClass;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.CDL.Name, false) == 0)
        {
          nullable2 = driverInfo.CDLDriverID;
          if (nullable2.HasValue)
          {
            DocTag docTag = tag;
            nullable2 = driverInfo.CDLDriverID;
            num = nullable2.Value;
            string str = num.ToString();
            docTag.TagValue = str;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.MVR.Name, false) == 0)
        {
          nullable1 = driverInfo.MVRDate;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.MVRDate;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Street1.Name, false) == 0)
          tag.TagValue = driverInfo.Street1;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Street2.Name, false) == 0)
          tag.TagValue = driverInfo.Street2;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.City.Name, false) == 0)
          tag.TagValue = driverInfo.City;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.ZipCode.Name, false) == 0)
          tag.TagValue = !string.IsNullOrEmpty(driverInfo.ZipPlus) ? driverInfo.ZipCode : $"{driverInfo.ZipCode}-{driverInfo.ZipPlus}";
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.FurnishedCar.Name, false) == 0)
          tag.TagValue = driverInfo.FurnishedCar.ToString();
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.CopyRenewql.Name, false) == 0)
          tag.TagValue = driverInfo.FurnishedCar.ToString();
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.NoFaultAcc.Name, false) == 0)
          tag.TagValue = driverInfo.NumAtFaultAcc;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.NoOtherAcc.Name, false) == 0)
          tag.TagValue = driverInfo.NumOtherAcc;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.SpeedLT10.Name, false) == 0)
          tag.TagValue = driverInfo.SpeedingLessTenMPH;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.SpeedGT10.Name, false) == 0)
          tag.TagValue = driverInfo.SpeedingMoreTenMPH;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.SecViolation.Name, false) == 0)
          tag.TagValue = driverInfo.SecVltns;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.EquipViolation.Name, false) == 0)
          tag.TagValue = driverInfo.EquipVltns;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.OtherViolation.Name, false) == 0)
          tag.TagValue = driverInfo.OtherMovingVltns;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.TotalViolations.Name, false) == 0)
          tag.TagValue = driverInfo.TotalVtlns;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.HireDate.Name, false) == 0)
        {
          nullable1 = driverInfo.DateOfHire;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.DateOfHire;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.OrigCDLDate.Name, false) == 0)
        {
          nullable1 = driverInfo.DateOfOrigCDL;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.DateOfOrigCDL;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.YearsTruckExp.Name, false) == 0)
        {
          nullable2 = driverInfo.YearsLogTruckExperienceNum;
          if (nullable2.HasValue)
          {
            DocTag docTag = tag;
            nullable2 = driverInfo.YearsLogTruckExperienceNum;
            num = nullable2.Value;
            string str = num.ToString();
            docTag.TagValue = str;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Recipient.Name, false) == 0)
          tag.TagValue = driverInfo.Recipient;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Subject.Name, false) == 0)
          tag.TagValue = driverInfo.NoteSubject;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.DaysDue.Name, false) == 0)
        {
          short? daysDue = driverInfo.DaysDue;
          if (daysDue.HasValue)
          {
            DocTag docTag = tag;
            daysDue = driverInfo.DaysDue;
            string str = daysDue.Value.ToString();
            docTag.TagValue = str;
          }
          else
            tag.TagValue = "";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.Body.Name, false) == 0)
          tag.TagValue = driverInfo.NoteBody;
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, DriverInfoTags.DriverExcluded.Name, false) == 0)
        {
          nullable1 = driverInfo.DriverExcluded;
          if (nullable1.HasValue)
          {
            DocTag docTag = tag;
            nullable1 = driverInfo.DriverExcluded;
            dateTime = nullable1.Value;
            string shortDateString = dateTime.ToShortDateString();
            docTag.TagValue = shortDateString;
          }
          else
            tag.TagValue = "";
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    tags = base.ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID);
    return tags;
  }
}

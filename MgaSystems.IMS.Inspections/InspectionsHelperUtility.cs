// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.InspectionsHelperUtility
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public sealed class InspectionsHelperUtility
{
  private InspectionsHelperUtility()
  {
  }

  public static DateTime GetInspectionLocationDueDate(int locationID, Guid quoteGuid)
  {
    Quote quote = new Quote(quoteGuid);
    DateTime inspectionLocationDueDate;
    if (!quote.UsingNetRate)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("GetInspectionDueDateVariables", new object[2]
      {
        (object) "@LocationID",
        (object) locationID
      });
      if (dataRow != null)
      {
        if (dataRow[2] != DBNull.Value)
        {
          inspectionLocationDueDate = Conversions.ToDate(dataRow[2]);
          goto label_15;
        }
        if (dataRow[0] != DBNull.Value && Conversions.ToBoolean(dataRow[0]))
        {
          inspectionLocationDueDate = CurrentUser.ServerTime.AddDays(10.0);
          goto label_15;
        }
        if (dataRow[1] != DBNull.Value && Conversions.ToBoolean(dataRow[1]))
        {
          inspectionLocationDueDate = CurrentUser.ServerTime.AddDays(15.0);
          goto label_15;
        }
      }
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetInspectionDueDateViaNetRate", new object[2]
      {
        (object) "@LocationID",
        (object) locationID
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        inspectionLocationDueDate = Conversions.ToDate(objectValue);
        goto label_15;
      }
    }
    DateTime dateTime = quote.EffectiveDate.AddDays(60.0);
    int days = dateTime.Subtract(CurrentUser.ServerTime).Days;
    if (days >= 30)
    {
      dateTime = CurrentUser.ServerTime;
      inspectionLocationDueDate = dateTime.AddDays(30.0);
    }
    else if (days < 15)
    {
      inspectionLocationDueDate = CurrentUser.ServerTime;
    }
    else
    {
      dateTime = CurrentUser.ServerTime;
      inspectionLocationDueDate = dateTime.AddDays(10.0);
    }
label_15:
    return inspectionLocationDueDate;
  }

  public static string GetCustomerReferenceIdentifier(int underWritingLocationID, Guid quoteGuid)
  {
    return new Quote(quoteGuid).ControlNo.ToString();
  }

  public static string GetShortenedInsuredName(string insuredName)
  {
    if (insuredName.Length > 100)
      insuredName = insuredName.Substring(0, 99);
    return insuredName;
  }

  public static string GetClientCode(
    int inspectionCompanyID,
    int underwritingLocationID,
    int quoteID)
  {
    string Left = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetInspectionClientCode(@quoteID, @inspectionCompanyID)", new object[4]
    {
      (object) "@quoteID",
      (object) quoteID,
      (object) "@inspectionCompanyID",
      (object) inspectionCompanyID
    }).ToString();
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) != 0 ? Left : "NONE.";
  }
}

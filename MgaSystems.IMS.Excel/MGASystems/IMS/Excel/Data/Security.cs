// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Security
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Data;

[SecureResource("{8843DB70-0BAC-40e7-A2B8-8F276F573CA0}", "Rating Data Export", "Controls the ability to export Excel Rating Data.", "Excel Rating")]
[SecureResource("{6E905CD5-C92C-40CF-A0CA-CA075873C0E4}", "Administrative Returned Premium Adjustment", "Controls the ability to edit premiums after they are returned to IMS from the rater.", "Policies")]
public static class Security
{
  private const string canExportExcelRatingData = "{8843DB70-0BAC-40e7-A2B8-8F276F573CA0}";
  private const string canEditReturnedPremiums = "{6E905CD5-C92C-40CF-A0CA-CA075873C0E4}";

  public static bool CanExportExcelRatingData
  {
    get => MGASystems.IMS.Excel.Data.Security.Assert("{8843DB70-0BAC-40e7-A2B8-8F276F573CA0}");
  }

  public static bool CanSaveSheetOnBoundQuote(int raterId)
  {
    return MGASystems.IMS.Excel.Data.Security.Assert(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT CanEditRaterPostBindResourceGuid FROM dbo.lstRatingTypes WHERE RatingTypeID = @RaterID", new object[2]
    {
      (object) "@RaterID",
      (object) raterId
    }));
  }

  public static bool CanSaveSheetOnIssuedQuote(int raterId)
  {
    return MGASystems.IMS.Excel.Data.Security.Assert(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT CanEditRaterPostIssueResourceGuid FROM dbo.lstRatingTypes WHERE RatingTypeID = @RaterID", new object[2]
    {
      (object) "@RaterID",
      (object) raterId
    }));
  }

  public static bool CanInvokeCaptureSheet(int raterID)
  {
    return MGASystems.IMS.Excel.Data.Security.Assert(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT InvokeSheetResourceGuid FROM dbo.lstDataCaptureRaters WHERE RatingTypeID = @RaterID", new object[2]
    {
      (object) "@RaterID",
      (object) raterID
    }));
  }

  public static bool CanResetCaptureSheet(int raterID)
  {
    return MGASystems.IMS.Excel.Data.Security.Assert(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT ResetSheetResourceGuid FROM dbo.lstDataCaptureRaters WHERE RatingTypeID = @RaterID", new object[2]
    {
      (object) "@RaterID",
      (object) raterID
    }));
  }

  public static bool CanEditReturnedPremiums
  {
    get => CurrentUser.IsMGADeveloper || MGASystems.IMS.Excel.Data.Security.Assert("{6E905CD5-C92C-40CF-A0CA-CA075873C0E4}");
  }

  public static bool CanViewMGAExcelOptions => CurrentUser.IsMGADeveloper;

  private static bool Assert(string resource)
  {
    return Information.IsDesignMode || SecurityManager.Instance.AssertPermission(resource);
  }

  private static bool Assert(Guid resource)
  {
    return Information.IsDesignMode || SecurityManager.Instance.AssertPermission(resource);
  }
}

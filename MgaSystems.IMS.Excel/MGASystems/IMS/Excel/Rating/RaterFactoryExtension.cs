// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.RaterFactoryExtension
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Excel.Rating;

public class RaterFactoryExtension : IRaterFactoryExtension
{
  public IRater GetRater(int raterID)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select Name from tblExcelRating_Raters where RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) raterID
    });
    if (dataTable.Rows.Count == 1)
      return ObjectFactory.Instance.CreateObject(typeof (ExcelRater), new object[2]
      {
        (object) raterID,
        (object) (string) dataTable.Rows[0]["Name"]
      }) as IRater;
    if (dataTable.Rows.Count > 1)
      throw new InvalidOperationException("Cannot have more than one rater defined for a given rating type id");
    return (IRater) null;
  }
}

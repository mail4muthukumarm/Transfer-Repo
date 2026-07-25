// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.StandardRating.ExcelStandardRatingData
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.Excel.Data.Administration2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Excel.Data.StandardRating;

public abstract class ExcelStandardRatingData : BindingObject
{
  private Guid quoteGuid;
  private int ratingTypeId;

  public string DatabaseTableName { get; }

  public bool PromptForSpreadSheet { get; }

  public List<ExcelMapping> ExcelMappings { get; }

  public ExcelFile ExcelFile { get; }

  public ExcelStandardRatingData(
    int ratingTypeId,
    Guid factorSetGuid,
    Guid quoteGuid,
    string excelFile = "")
  {
    this.ratingTypeId = ratingTypeId;
    this.quoteGuid = quoteGuid;
    if (Information.IsDesignMode)
      return;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "select DatabaseTableName, RaterDisplaysModally from tblExcelRating_Raters where RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) ratingTypeId
    });
    this.DatabaseTableName = (string) dataRow[nameof (DatabaseTableName)];
    this.PromptForSpreadSheet = (bool) dataRow["RaterDisplaysModally"];
    this.ExcelMappings = ExcelRaterFactorSet.GetMappings(quoteGuid, factorSetGuid);
    if (string.IsNullOrEmpty(excelFile))
      this.ExcelFile = (ExcelFile) ObjectFactory.Instance.CreateObject(typeof (ExcelFile), new object[3]
      {
        (object) factorSetGuid,
        (object) quoteGuid,
        (object) this.ratingTypeId
      });
    else
      this.ExcelFile = (ExcelFile) ObjectFactory.Instance.CreateObject(typeof (ExcelFile), new object[4]
      {
        (object) factorSetGuid,
        (object) quoteGuid,
        (object) this.ratingTypeId,
        (object) excelFile
      });
    this.ExcelFile.PropertyChanged += new PropertyChangedEventHandler(this.ExcelFile_PropertyChanged);
  }

  private void ExcelFile_PropertyChanged(object sender, PropertyChangedEventArgs e)
  {
    if (!(e.PropertyName == "UpdateErrors") && !(e.PropertyName == "FullPath"))
      return;
    foreach (ExcelMapping excelMapping in this.ExcelMappings)
    {
      if ("PREM".Equals(excelMapping.PremiumOption, StringComparison.OrdinalIgnoreCase))
      {
        try
        {
          this.Premium = Utility.IsNull<int>(DefaultDatabase.ExecuteScalar(CommandType.Text, string.Format((IFormatProvider) CultureInfo.InvariantCulture, "select cast({0} as int) from {1} where quoteGuid = @quoteGuid", (object) excelMapping.DatabaseField, (object) this.DatabaseTableName), new object[2]
          {
            (object) "@quoteGuid",
            (object) this.quoteGuid
          }), 0);
        }
        catch (Exception ex)
        {
          this.Premium = 0;
        }
        this.OnPropertyChanged("Premium");
        break;
      }
    }
  }

  [NotificationProperty]
  public virtual int Premium { get; protected set; }

  public static ExcelStandardRatingData Create(
    int ratingTypeId,
    Guid factorSetGuid,
    Guid quoteGuid,
    string excelFile = "")
  {
    return NotifyProxyTypeManager.Allocate<ExcelStandardRatingData>(new object[4]
    {
      (object) ratingTypeId,
      (object) factorSetGuid,
      (object) quoteGuid,
      (object) excelFile
    });
  }
}

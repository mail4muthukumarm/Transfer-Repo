// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.ScheduleChooser.ScheduleChooserDataManager
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Excel.Data.ScheduleChooser;

public class ScheduleChooserDataManager : BindingObject
{
  public BulkObservableCollection<ScheduleInfo> AvailableSchedules { get; } = new BulkObservableCollection<ScheduleInfo>();

  public int StartRowIndex { get; set; } = 1;

  public int MaxRowsToRead { get; set; } = 1000;

  public int SetinelColumnIndex { get; set; }

  public Guid RaterFactorsetGuid { get; }

  public bool IsGenerateRepeaterTagsChecked { get; set; }

  public Guid? ScheduleFactorSet { get; set; }

  public bool ShowScheduleAutoGeneration { get; set; } = SystemSettings.GetSetting<bool>("Excel.ScheduleTagAutoGenerationSupported", true);

  public ScheduleChooserDataManager(Guid raterFactorsetGuid)
  {
    this.RaterFactorsetGuid = raterFactorsetGuid;
    this.AvailableSchedules.AddRange((IEnumerable<ScheduleInfo>) DefaultDatabase.ExecuteDataTable("ExcelRating_FetchAvailableSchedules", new object[2]
    {
      (object) "@factorsetGuid",
      (object) raterFactorsetGuid
    }).AsEnumerable().Select<DataRow, ScheduleInfo>((System.Func<DataRow, ScheduleInfo>) (row => new ScheduleInfo()
    {
      Title = row.Field<string>("RatingType"),
      FactorSetGuid = row.Field<Guid>("FactorSetGUID")
    })));
  }

  public bool IsValid
  {
    get
    {
      return this.ScheduleFactorSet.HasValue && this.StartRowIndex >= 1 && this.SetinelColumnIndex >= 0 && this.MaxRowsToRead >= 0;
    }
  }
}

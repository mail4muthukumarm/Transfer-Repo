// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.RaterModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data.DataMapping;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

[TableMapping("lstRatingTypes")]
public class RaterModel
{
  [TableFieldMapping("RatingTypeId")]
  public int RatingTypeId { get; set; }

  [TableFieldMapping("RatingType")]
  public string RatingType { get; set; }

  public RaterModel(int ratingTypeId, string ratingType)
  {
    this.RatingTypeId = ratingTypeId;
    this.RatingType = ratingType;
  }

  public static RaterModel Create(DataRow dr)
  {
    return new RaterModel(dr.Field<int>("RatingTypeID"), dr.Field<string>("RatingType"));
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.QuoteDetailModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using System;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

public class QuoteDetailModel
{
  public int QuoteDetailId { get; set; }

  public Guid QuoteGuid { get; set; }

  public int ControlNumber { get; set; }

  public int RatingTypeId { get; set; }

  public string RatingType { get; set; }

  public int QuoteStatusId { get; set; }

  public string QuoteStatus { get; set; }

  public bool IsBound { get; set; }

  public QuoteDetailModel(
    int quoteDetailId,
    Guid quoteGuid,
    int controlNumber,
    int ratingTypeId,
    string ratingType,
    int quoteStatusId,
    string quoteStatus,
    bool isBound)
  {
    this.QuoteDetailId = quoteDetailId;
    this.QuoteGuid = quoteGuid;
    this.ControlNumber = controlNumber;
    this.RatingTypeId = ratingTypeId;
    this.RatingType = ratingType;
    this.QuoteStatusId = quoteStatusId;
    this.QuoteStatus = quoteStatus;
    this.IsBound = isBound;
  }
}

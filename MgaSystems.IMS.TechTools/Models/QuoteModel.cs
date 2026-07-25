// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.QuoteModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using System;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

public class QuoteModel
{
  public int QuoteId { get; set; }

  public Guid QuoteGuid { get; set; }

  public QuoteModel(int id, Guid guid)
  {
    this.QuoteId = id;
    this.QuoteGuid = guid;
  }

  public QuoteModel()
  {
  }
}

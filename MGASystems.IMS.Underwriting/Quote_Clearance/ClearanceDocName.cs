// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Quote_Clearance.ClearanceDocName
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Underwriting.Quote_Clearance;

internal class ClearanceDocName
{
  private readonly string _fileName;
  private readonly Guid _quoteGuid;

  public string FileName => this._fileName;

  public Guid AssociatedQuoteGuid => this._quoteGuid;

  internal ClearanceDocName(string docName, Guid quoteGuid)
  {
    this._fileName = docName;
    this._quoteGuid = quoteGuid;
  }
}

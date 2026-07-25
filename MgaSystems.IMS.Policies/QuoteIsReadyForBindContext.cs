// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.QuoteIsReadyForBindContext
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects.Rating;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies;

public class QuoteIsReadyForBindContext
{
  private List<string> _reasonsNotToBind;
  private IRater _rater;
  private int _raterID;

  public IRater Rater => this._rater;

  public int RaterID => this._raterID;

  public List<string> ReasonsNotToBind => this._reasonsNotToBind;

  public QuoteIsReadyForBindContext(IRater rater, int raterID)
  {
    this._reasonsNotToBind = new List<string>();
    this._rater = rater;
    this._raterID = raterID;
  }
}

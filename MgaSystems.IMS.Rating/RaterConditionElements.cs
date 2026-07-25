// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterConditionElements
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class RaterConditionElements
{
  private readonly int _raterID;
  private readonly List<RaterConditionalElement> _conditions;

  public RaterConditionElements(int raterID)
  {
    this._raterID = raterID;
    this._conditions = new List<RaterConditionalElement>();
    this._conditions = this.AddConditionElements();
  }

  protected virtual List<RaterConditionalElement> AddConditionElements()
  {
    this._conditions.Add(new RaterConditionalElement("Earthquake Coverage Exists", 900, "System.Boolean", 98));
    this._conditions.Add(new RaterConditionalElement("Flood Coverage Exists", 901, "System.Boolean", 98));
    this._conditions.Add(new RaterConditionalElement("Property Rater Limit", 902, "System.Int32", 98));
    this._conditions.Add(new RaterConditionalElement("Terrorism Declined", 903, "System.Boolean", 98));
    this._conditions.Add(new RaterConditionalElement("SIC Code", 904, "System.String", 98));
    this._conditions.Add(new RaterConditionalElement("Cause of Loss Exists", 905, "System.String", 98));
    return this._conditions;
  }

  public List<RaterConditionalElement> RaterConditionals()
  {
    return this._conditions.FindAll(new Predicate<RaterConditionalElement>(this.IsRaterCondition));
  }

  private bool IsRaterCondition(RaterConditionalElement element)
  {
    return element.RaterID == this._raterID;
  }
}

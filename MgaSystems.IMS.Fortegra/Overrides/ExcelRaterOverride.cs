// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.ExcelRaterOverride
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.IMS.Excel.Rating;
using MgaSystems.Ims.Fortegra.Rater_PolicyForms_Conditions;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides;

[Override(typeof (ExcelRater))]
internal class ExcelRaterOverride : ExcelRater
{
  private int raterID;
  public static readonly int NY_CONTRACTOR = 4000;
  public static readonly int DIRECTCREADITBOP = 4001;
  public static readonly int DIRECTCREADITBOP2 = 4003;
  private FormConditionCompare _compare;
  private RaterConditionElements _conditionElements;

  public ExcelRaterOverride(int raterID, string raterName)
    : base(raterID, raterName)
  {
    this.raterID = raterID;
  }

  public override bool DoesConditionApply(
    int conditionalID,
    ConditionalOperators conditions,
    object amount)
  {
    if (this.RaterID != ExcelRaterOverride.NY_CONTRACTOR && this.raterID != ExcelRaterOverride.DIRECTCREADITBOP && this.raterID != ExcelRaterOverride.DIRECTCREADITBOP2)
      return base.DoesConditionApply(conditionalID, conditions, amount);
    if (this._compare == null)
      this._compare = ObjectFactory.Instance.CreateObjectAs<FormConditionCompare>(typeof (FormConditionCompare));
    return this._compare.ValidateCondition(conditionalID, conditions, amount, this.Quote.QuoteGuid);
  }

  public override List<RaterConditionalElement> RaterConditionalElements(string LineCode)
  {
    if (this._conditionElements == null)
      this._conditionElements = new RaterConditionElements(this.RaterID);
    return this._conditionElements.RaterConditionals();
  }
}

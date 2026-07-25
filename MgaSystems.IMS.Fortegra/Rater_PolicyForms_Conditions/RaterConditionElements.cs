// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Rater_PolicyForms_Conditions.RaterConditionElements
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.BusinessObjects;
using MgaSystems.Ims.Fortegra.Overrides;
using System;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Rater_PolicyForms_Conditions;

public class RaterConditionElements
{
  private List<RaterConditionalElement> _conditions;
  private int _raterID;

  public RaterConditionElements(int raterID)
  {
    this._raterID = raterID;
    this._conditions = new List<RaterConditionalElement>();
    this._conditions.Add(new RaterConditionalElement("Terrorism  exists", -100, "System.Boolean", ExcelRaterOverride.NY_CONTRACTOR));
    this._conditions.Add(new RaterConditionalElement("Employee Benefit Liability Exists", -101, "System.Boolean", ExcelRaterOverride.NY_CONTRACTOR));
    this._conditions.Add(new RaterConditionalElement("Form Number Exists", -102, "System.String", ExcelRaterOverride.NY_CONTRACTOR));
    this._conditions.Add(new RaterConditionalElement("Hired and Non-Owned Auto Liability Exists", -103, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP));
    this._conditions.Add(new RaterConditionalElement("Windstorm Or Hail Percentage Deductibles Exists", -104, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP));
    this._conditions.Add(new RaterConditionalElement("Employee Related Practices Liability Endorsement Exists", -105, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP));
    this._conditions.Add(new RaterConditionalElement("Protective Safeguard Exists", -106, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP));
    this._conditions.Add(new RaterConditionalElement("Ordinance Or law Coverage Exists", -107, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP));
    this._conditions.Add(new RaterConditionalElement("Water Back-up And Sump Overflow Exists", -108, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP));
    this._conditions.Add(new RaterConditionalElement("Hired and Non-Owned Auto Liability Exists", -109, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP2));
    this._conditions.Add(new RaterConditionalElement("Windstorm Or Hail Percentage Deductibles Exists", -110, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP2));
    this._conditions.Add(new RaterConditionalElement("Employee Related Practices Liability Endorsement Exists", -111, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP2));
    this._conditions.Add(new RaterConditionalElement("Protective Safeguard Exists", -112, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP2));
    this._conditions.Add(new RaterConditionalElement("Ordinance Or law Coverage Exists", -113, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP2));
    this._conditions.Add(new RaterConditionalElement("Water Back-up And Sump Overflow Exists", -114, "System.Boolean", ExcelRaterOverride.DIRECTCREADITBOP2));
  }

  public List<RaterConditionalElement> RaterConditionals()
  {
    return this._conditions.FindAll(this.IsRaterConditionPredicate);
  }

  private Predicate<RaterConditionalElement> IsRaterConditionPredicate
  {
    get => new Predicate<RaterConditionalElement>(this.IsRaterCondition);
  }

  private bool IsRaterCondition(RaterConditionalElement element)
  {
    return element.RaterID == this._raterID;
  }
}

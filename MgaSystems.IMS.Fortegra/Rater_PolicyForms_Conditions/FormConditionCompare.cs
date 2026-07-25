// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Rater_PolicyForms_Conditions.FormConditionCompare
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.BusinessObjects;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using System;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Rater_PolicyForms_Conditions;

internal class FormConditionCompare
{
  private const int TERR_EXISTS = -100;
  private const int EMP_BEN_LIAB_EXISTS = -101;
  private const int FORMNUMBER = -102;
  private const int HIRED_NONOWNED_AUTO_LIAB_EXISTS = -103;
  private const int WINDSTORM_OR_HAIL_PERCENTAGE_DEDUCT_EXISTS = -104;
  private const int EMPLOYEE_RELATED_PRACTICES_LIABILITY_ENDORSEMENT = -105;
  private const int PROTECTIVE_SAFEGUARD_EXISTS = -106;
  private const int ORDINANCE_OR_LAW_COVERAGE_EXISTS = -107;
  private const int WATER_BACKUP_SUMPOVERFLOW_EXISTS = -108;
  private const int HIRED_NONOWNED_AUTO_LIAB_EXISTS2 = -109;
  private const int WINDSTORM_OR_HAIL_PERCENTAGE_DEDUCT_EXISTS2 = -110;
  private const int EMPLOYEE_RELATED_PRACTICES_LIABILITY_ENDORSEMENT2 = -111;
  private const int PROTECTIVE_SAFEGUARD_EXISTS2 = -112;
  private const int ORDINANCE_OR_LAW_COVERAGE_EXISTS2 = -113;
  private const int WATER_BACKUP_SUMPOVERFLOW_EXISTS2 = -114;

  public bool ValidateCondition(
    int conditionalID,
    ConditionalOperators conditions,
    object amount,
    Guid QuoteGuid)
  {
    bool flag;
    switch (conditionalID)
    {
      case -114:
      case -113:
      case -112:
      case -111:
      case -110:
      case -109:
        flag = FormConditionCompare.ConditionExistsQuerySP("Fortegra_DIRECTCREDIT_BOP2_Conditionals", conditions, QuoteGuid, "Fortegra_DirectCreditBOP_Conditionals", conditionalID, amount);
        break;
      case -108:
      case -107:
      case -106:
      case -105:
      case -104:
      case -103:
        flag = FormConditionCompare.ConditionExistsQuerySP("Fortegra_DIRECTCREDIT_BOP_Conditionals", conditions, QuoteGuid, "Fortegra_DirectCreditBOP_Conditionals", conditionalID, amount);
        break;
      case -102:
      case -101:
      case -100:
        flag = this.NY_Contractor_Conditions(conditions, QuoteGuid, conditionalID, amount);
        break;
      default:
        ErrorHandler.SilentHandleError((Exception) new ArgumentException($"The condition name supplied was not found. QuoteGuid {QuoteGuid}; ConditionalID {conditionalID}"));
        flag = false;
        break;
    }
    return flag;
  }

  protected virtual bool NY_Contractor_Conditions(
    ConditionalOperators condition,
    Guid QuoteGuid,
    int ConditionalID,
    object amount)
  {
    return FormConditionCompare.ConditionExistsQuerySP("Fortegra_NYCONTRACTOR_Conditionals", condition, QuoteGuid, "Fortegra_NYCONTRACTOR_Conditionals", ConditionalID, amount);
  }

  private static bool ConditionExistsQuerySP(
    string spName,
    ConditionalOperators conditions,
    Guid QuoteGuid,
    string query,
    int conditionalID,
    object amount)
  {
    return (bool) DefaultDatabase.ExecuteScalar(spName, new object[8]
    {
      (object) "@QuoteGuid",
      (object) QuoteGuid,
      (object) "@conditionalID",
      (object) conditionalID,
      (object) "@ConditionOperator",
      (object) Convert.ToInt32((object) conditions),
      (object) "@amount",
      amount
    });
  }
}

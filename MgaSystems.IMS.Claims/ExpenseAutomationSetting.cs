// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ExpenseAutomationSetting
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Claims;

internal class ExpenseAutomationSetting
{
  private int _expenseActionId;
  private string _automationCode;
  private string _description;
  private bool _isActive;
  private Decimal _percentage;
  private Decimal _flatAmount;
  private Decimal _hours;
  private Decimal _rate;

  internal ExpenseAutomationSetting(string automationCode)
  {
    this.LoadExpenseAutomationSetting(automationCode);
  }

  internal int ExpenseActionId => this._expenseActionId;

  internal string AutomationCode => this._automationCode;

  internal string Description => this._description;

  internal bool IsActive => this._isActive;

  internal Decimal Percentage => this._percentage;

  internal Decimal FlatAmount => this._flatAmount;

  internal Decimal Hours => this._hours;

  internal Decimal Rate => this._rate;

  private void LoadExpenseAutomationSetting(string automationCode)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaims_GetExpenseAutomationSetting", new object[2]
    {
      (object) "@AutomationCode",
      (object) automationCode
    });
    this._expenseActionId = dataRow != null ? (int) dataRow["ExpenseActionId"] : throw new AutomatedExpenseNotFoundException(Resources.EXPENSE_NOTFOUND_ERROR);
    this._automationCode = dataRow["AutomationCode"].ToString();
    this._description = dataRow["ExpenseActionDescription"].ToString();
    this._isActive = (bool) dataRow["Active"];
    this._percentage = (Decimal) dataRow["Percentage"];
    this._flatAmount = (Decimal) dataRow["FlatAmount"];
    this._hours = (Decimal) dataRow["Hours"];
    this._rate = (Decimal) dataRow["Rate"];
  }
}

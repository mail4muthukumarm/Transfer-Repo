// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.Expense
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class Expense
{
  private int expenseCode;
  private int expenseCategoryId;
  private string expenseName;
  private string expenseDescription;
  private bool isSystemsDefined;

  public Expense()
  {
  }

  public Expense(int ExpenseCode) => this.LoadExpense(ExpenseCode);

  public Expense(int ExpenseCategoryId, string ExpenseName, string ExpenseDescription)
  {
    this.expenseCategoryId = ExpenseCategoryId;
    this.expenseName = ExpenseName;
    this.expenseDescription = ExpenseDescription;
    this.isSystemsDefined = false;
  }

  public int ExpenseCode
  {
    get => this.expenseCode;
    set
    {
      this.expenseCode = value;
      this.LoadExpense(value);
    }
  }

  public int ExpenseCategoryId
  {
    get => this.expenseCategoryId;
    set => this.expenseCategoryId = value;
  }

  public string ExpenseName
  {
    get => this.expenseName;
    set => this.expenseName = value;
  }

  public string ExpenseDescription
  {
    get => this.expenseDescription;
    set => this.expenseDescription = value;
  }

  public bool IsSystemDefined => this.isSystemsDefined;

  protected void LoadExpense(int ExpenseCode)
  {
    DataTable dataTable = (DataTable) null;
    DataRow dataRow = (DataRow) null;
    try
    {
      try
      {
        dataTable = Database.Instance.QuerySP.PerformTableQuery("dbo.spFin_GetExpense", (object) "@expenseCode", (object) ExpenseCode);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      if (dataTable == null || dataTable.Rows.Count == 0)
        throw new ExpenseNotFoundException(StringResourceManager.GetString("EXPENSE_NOTFOUND_EXCEPTION"));
      dataRow = dataTable.Rows[0];
      this.expenseCode = int.Parse(dataRow["expenseCode"].ToString());
      this.expenseCategoryId = int.Parse(dataRow["expenseCategoryId"].ToString());
      this.expenseName = dataRow["expenseName"].ToString();
      this.expenseDescription = dataRow["description"].ToString();
      this.isSystemsDefined = Convert.ToBoolean(dataRow["SystemDefined"]);
    }
    finally
    {
      if (dataRow != null)
        ;
      dataTable?.Dispose();
    }
  }

  public void SaveExpense()
  {
    if (this.expenseCode == 0)
      Database.Instance.QuerySP.PerformNonQuery("spFin_AddExpense", (object) "@EXPENSECATEGORYID", (object) this.expenseCategoryId, (object) "@EXPENSENAME", (object) this.expenseName, (object) "@DESCRIPTION", (object) this.expenseDescription);
    else
      Database.Instance.QuerySP.PerformNonQuery("spFin_UpdateExpense", (object) "@EXPENSECODE", (object) this.expenseCode, (object) "@EXPENSECATEGORYID", (object) this.expenseCategoryId, (object) "@EXPENSENAME", (object) this.expenseName, (object) "@DESCRIPTION", (object) this.expenseDescription);
  }

  public void Delete()
  {
    if (this.expenseCode == 0)
      return;
    Database.Instance.QuerySP.PerformNonQuery("spFin_DeleteExpense", (object) "@expensecode", (object) this.expenseCode);
  }

  public static int GetExpenseDefaultGLAccount(int ExpenseCode, int GlCompanyId)
  {
    try
    {
      return Database.Instance.QueryText.PerformScalarQueryInt($"select dbo.GetExpenseDefaultGlAcct({ExpenseCode}, {GlCompanyId})");
    }
    catch (SqlException ex)
    {
      throw new GetExpenseDefaultGlException(StringResourceManager.GetString("GetExpenseDefaultGlException") + ex.Errors[0].Message);
    }
    catch (Exception ex)
    {
      throw new GetExpenseDefaultGlException(StringResourceManager.GetString("GetExpenseDefaultGlException") + ex.Message);
    }
  }
}

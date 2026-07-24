// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseCategory
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class ExpenseCategory
{
  private int expenseCategoryId;
  private string categoryName;
  private string categoryDescription;
  private bool systemDefined;

  public ExpenseCategory()
  {
  }

  public ExpenseCategory(int expenseCategoryId)
  {
    this.expenseCategoryId = expenseCategoryId;
    this.LoadExpenseCategory();
  }

  public ExpenseCategory(string categoryName, string categoryDescription)
  {
    this.categoryName = categoryName;
    this.categoryDescription = categoryDescription;
  }

  public int ExpenseCategoryId => this.expenseCategoryId;

  public string CategoryName
  {
    get => this.categoryName;
    set => this.categoryName = value;
  }

  public string CategoryDescription
  {
    get => this.categoryDescription;
    set => this.categoryDescription = value;
  }

  public bool SystemDefined => this.systemDefined;

  private void LoadExpenseCategory()
  {
    using (SqlCommand sqlCommand = new SqlCommand("spFin_GetExpenseCategory", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@ExpenseCategoryId", (object) this.expenseCategoryId);
      sqlCommand.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
      if (sqlDataReader.Read())
      {
        this.categoryName = sqlDataReader["categoryname"].ToString();
        this.categoryDescription = sqlDataReader["description"].ToString();
        this.systemDefined = bool.Parse(sqlDataReader["systemdefined"].ToString());
      }
      sqlDataReader.Close();
      sqlCommand.Connection.Close();
    }
  }

  public void Save()
  {
    if (this.expenseCategoryId != 0)
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_UpdateExpenseCategory", new SqlConnection(CurrentUser.Instance.ConnectionString)))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@EXPENSECATEGORYID", (object) this.expenseCategoryId);
        sqlCommand.Parameters.AddWithValue("@CATEGORYNAME", (object) this.categoryName);
        sqlCommand.Parameters.AddWithValue("@DESCRIPTION", (object) this.categoryDescription);
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
          if (ex.Number == 50000 && ex.State == (byte) 1)
            throw new ObjectCannotBeModifiedException(ex.Message);
          if (ex.Number == 50000 && ex.State == (byte) 2)
            throw new ExpenseCategoryAlreadyExistsException(ex.Message);
          throw ex;
        }
      }
    }
    else
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_AddExpenseCategory", new SqlConnection(CurrentUser.Instance.ConnectionString)))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@CATEGORYNAME", (object) this.categoryName);
        sqlCommand.Parameters.AddWithValue("@DESCRIPTION", (object) this.categoryDescription);
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
          if (ex.Number == 50000 && ex.State == (byte) 2)
            throw new ExpenseCategoryAlreadyExistsException(ex.Message);
          throw ex;
        }
      }
    }
  }

  public void Delete()
  {
    using (SqlCommand sqlCommand = new SqlCommand("spFin_DeleteExpenseCategory", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@EXPENSECATEGORYID", (object) this.expenseCategoryId);
      try
      {
        sqlCommand.Connection.Open();
        sqlCommand.ExecuteNonQuery();
      }
      catch (SqlException ex)
      {
        if (ex.Number == 50000)
          throw new CannotDeleteException(ex.Message);
        throw ex;
      }
    }
  }
}

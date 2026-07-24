// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.Methods
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Security;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared;

[SecureResource("{A6AE3580-BA84-4426-9BFF-8FE46686C639}", "View All GL Company Rights", "Users with this permission will see all GL Companies. Users that should only see the GL Company associated with the user account office location should be denied this permission.", "Accounting")]
public sealed class Methods
{
  internal const string ViewAllGlCompanies = "{A6AE3580-BA84-4426-9BFF-8FE46686C639}";

  private Methods()
  {
  }

  public static dsOfficeLocations GetOfficeLocationDataset(bool showAllOption = false)
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetOfficeLocations", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
    dsOfficeLocations officeLocationDataset = new dsOfficeLocations();
    if (SecurityManager.Instance.AssertPermission("{A6AE3580-BA84-4426-9BFF-8FE46686C639}"))
    {
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@allOption", (object) showAllOption);
      sqlDataAdapter.Fill((DataTable) officeLocationDataset.spFin_GetOfficeLocations);
    }
    else
    {
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@allOption", (object) showAllOption);
      sqlDataAdapter.Fill((DataTable) officeLocationDataset.spFin_GetOfficeLocations);
    }
    return officeLocationDataset;
  }

  public static bool IsNumericValue(object val)
  {
    try
    {
      int.Parse(val.ToString());
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
    catch (OverflowException ex)
    {
      return false;
    }
  }

  public static bool IsDecimalValue(object val)
  {
    try
    {
      Decimal.Parse(val.ToString(), NumberStyles.Any);
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
    catch (OverflowException ex)
    {
      return false;
    }
  }

  public static bool CanBankCreateChecks(int glAccountId)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.CanBankCreateChecks({glAccountId})", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        if (sqlCommand.ExecuteScalar().ToString().Equals("True"))
          return true;
        int num = (int) MessageBox.Show("The bank you have selected does not have check creation assigned. Please check the bank and try again.", "Invalid bank Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
  }

  public static dsTransactionTypes AccountingTransactionTypes()
  {
    dsTransactionTypes transactionTypes = new dsTransactionTypes();
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_getTransactionTypes", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          sqlDataAdapter.Fill((DataTable) transactionTypes.TransactionTypes);
      }
    }
    return transactionTypes;
  }
}

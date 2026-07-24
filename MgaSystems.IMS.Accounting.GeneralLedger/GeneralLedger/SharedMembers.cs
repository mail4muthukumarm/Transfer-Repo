// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.SharedMembers
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.GeneralLedger.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger;

public class SharedMembers
{
  public static string GetGLAccountFullName(int glAccountId)
  {
    SqlCommand sqlCommand = new SqlCommand($"Select dbo.GetGLAccountFullName({glAccountId})", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      sqlCommand.Connection.Open();
      sqlCommand.CommandType = CommandType.Text;
      return sqlCommand.ExecuteScalar().ToString();
    }
    catch (SqlException ex)
    {
      throw new JournalEntrySQLException($"{StringResourceManager.GetString("GLAccountFullNameRetreivalException")} {ex.Errors[0].Message}");
    }
    catch (Exception ex)
    {
      throw new JournalEntrySQLException($"{StringResourceManager.GetString("GLAccountFullNameRetreivalException")} {ex.Message}");
    }
    finally
    {
      if (sqlCommand != null)
      {
        if (sqlCommand.Connection != null)
        {
          if (sqlCommand.Connection.State != ConnectionState.Closed)
            sqlCommand.Connection.Close();
          sqlCommand.Connection.Dispose();
          sqlCommand.Connection = (SqlConnection) null;
        }
        sqlCommand.Dispose();
      }
    }
  }

  public static string GetGLAccountTypeName(int glAccountId)
  {
    SqlCommand sqlCommand = new SqlCommand($"Select dbo.GetGLAccountClassName({glAccountId})", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      sqlCommand.Connection.Open();
      sqlCommand.CommandType = CommandType.Text;
      return sqlCommand.ExecuteScalar().ToString();
    }
    catch (SqlException ex)
    {
      throw new JournalEntrySQLException($"{StringResourceManager.GetString("GLAccountTypeNameRetreivalException")} {ex.Errors[0].Message}");
    }
    catch (Exception ex)
    {
      throw new JournalEntrySQLException($"{StringResourceManager.GetString("GLAccountTypeNameRetreivalException")} {ex.Message}");
    }
    finally
    {
      if (sqlCommand != null)
      {
        if (sqlCommand.Connection != null)
        {
          if (sqlCommand.Connection.State != ConnectionState.Closed)
            sqlCommand.Connection.Close();
          sqlCommand.Connection.Dispose();
          sqlCommand.Connection = (SqlConnection) null;
        }
        sqlCommand.Dispose();
      }
    }
  }

  public enum JournalEntryType
  {
    AccountAdjustment,
    InvoiceCorrection,
    InvoiceLedgerEntry,
  }

  public enum InvoiceCorrectionType
  {
    ARAdjustmentInsured,
    ARAdjustmentProducer,
    ARAdjustmentCompany,
    APAdjustmentInsured,
    APAdjustmentProducer,
    APAdjustmentcompany,
  }
}

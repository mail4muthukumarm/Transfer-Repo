// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.ReconciliationWorkSheet
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[Serializable]
public class ReconciliationWorkSheet
{
  private DateTime _statementDate;
  private Decimal _endingBlance;
  private List<int> _selectedTransactions;

  public ReconciliationWorkSheet()
  {
  }

  public ReconciliationWorkSheet(
    DateTime statementDate,
    Decimal endingBalance,
    List<int> selectedTransactions)
  {
    this._statementDate = statementDate;
    this._endingBlance = endingBalance;
    this._selectedTransactions = selectedTransactions;
  }

  internal static ReconciliationWorkSheet GetWorksheetObject(Guid userGuid, int bankId)
  {
    SqlCommand sqlCommand = new SqlCommand();
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    MemoryStream serializationStream = new MemoryStream();
    byte[] numArray = (byte[]) null;
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    try
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      sqlCommand.Parameters.AddWithValue("@BankID", (object) bankId);
      sqlCommand.CommandText = "spfin_GetReconciliationWorksheet";
      sqlCommand.Connection.Open();
      sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
      binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
      if (!sqlDataReader.Read())
        return (ReconciliationWorkSheet) null;
      byte[] buffer = (byte[]) sqlDataReader.GetValue(0);
      serializationStream.Write(buffer, 0, buffer.Length);
      serializationStream.Position = 0L;
      return (ReconciliationWorkSheet) binaryFormatter.Deserialize((Stream) serializationStream);
    }
    finally
    {
      serializationStream.Close();
      numArray = (byte[]) null;
      sqlDataReader.Close();
      sqlCommand.Connection.Close();
      sqlCommand.Dispose();
    }
  }

  internal static void SaveWorkSheet(ReconciliationWorkSheet workSheet, int bankId)
  {
    SqlCommand sqlCommand = new SqlCommand("spFin_SaveReconciliationWorksheet", new SqlConnection(CurrentUser.Instance.ConnectionString));
    MemoryStream serializationStream = new MemoryStream();
    new BinaryFormatter()
    {
      AssemblyFormat = FormatterAssemblyStyle.Simple,
      Context = new StreamingContext(StreamingContextStates.Persistence)
    }.Serialize((Stream) serializationStream, (object) workSheet);
    serializationStream.Position = 0L;
    workSheet = (ReconciliationWorkSheet) null;
    byte[] array = serializationStream.ToArray();
    serializationStream.Close();
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    sqlCommand.Parameters.AddWithValue("@info", (object) array);
    sqlCommand.Parameters.AddWithValue("@bankId", (object) bankId);
    sqlCommand.Connection.Open();
    sqlCommand.ExecuteNonQuery();
    sqlCommand.Connection.Close();
    sqlCommand.Connection.Dispose();
    sqlCommand.Dispose();
  }

  internal static void DeleteWorkSheet(int bankId)
  {
    SqlCommand sqlCommand = new SqlCommand("spFin_DeleteReconciliationWorksheet", new SqlConnection(CurrentUser.Instance.ConnectionString));
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.AddWithValue("@bankId", (object) bankId);
    sqlCommand.Connection.Open();
    sqlCommand.ExecuteNonQuery();
    sqlCommand.Connection.Close();
    sqlCommand.Connection.Dispose();
    sqlCommand.Dispose();
  }

  public DateTime StatementDate
  {
    get => this._statementDate;
    set => this._statementDate = value;
  }

  public Decimal EndingBalance
  {
    get => this._endingBlance;
    set => this._endingBlance = value;
  }

  public List<int> SelectedTransactions
  {
    get => this._selectedTransactions;
    set => this._selectedTransactions = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.SqlDocumentProvider
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

public class SqlDocumentProvider : IDocumentRepository, IDocumentReader, IDocumentWriter
{
  private const string DocumentSystem_GetDocumentBinarySql = "SELECT TOP 1 ActualFileSize, Document FROM tblDocumentStore WHERE DocumentStoreGUID = @DocumentStoreGuid";
  private const string DocumentSystem_GetDocumentDataLengthSql = "SELECT TOP 1 DATALENGTH(Document) FROM tblDocumentStore WHERE DocumentStoreGUID = @DocumentStoreGuid";
  private const string DocumentSystem_WriteDocumentChunkSql = "UPDATE tblDocumentStore SET [Document].WRITE(@data, @offset, @len) WHERE DocumentStoreGuid = @DocumentStoreGuid";
  private const string DocumentSystem_WriteFileStreamSql = "SELECT [Document].PathName() AS PathName, GET_FILESTREAM_TRANSACTION_CONTEXT() AS serverTxn FROM tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid";
  private const string DocumentSystem_WriteToImageInitSql = "SELECT TEXTPTR(Document) FROM dbo.tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid";
  private const string DocumentSystem_WriteToImageSql = "UPDATETEXT tblDocumentStore.Document @Pointer @Offset 0 @Bytes";
  private const int BufferSize = 1024 /*0x0400*/;
  private static readonly string LogKeyDocumentManager = "DocumentStorage.SqlDocumentProvider";
  private SqlDbType? _documentColumnType;
  private bool? _documentColumnIsFileStream;

  public bool IsAccessible() => true;

  public SqlDocumentProvider() => this.CacheDocumentColumnType();

  public byte[] GetDocumentBinary(
    Guid documentStoreGuid,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Downloading from the database", nameof (GetDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 51);
    using (SqlConnection connection = DefaultDatabase.CreateConnection())
    {
      using (SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1 ActualFileSize, Document FROM tblDocumentStore WHERE DocumentStoreGUID = @DocumentStoreGuid", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.AddWithValue("@DocumentStoreGuid", (object) documentStoreGuid);
        connection.Open();
        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SequentialAccess))
        {
          sqlDataReader.Read();
          long int64 = (long) sqlDataReader["ActualFileSize"];
          int ordinal = sqlDataReader.GetOrdinal("Document");
          byte[] buffer = new byte[1024 /*0x0400*/];
          if (int64 == 0L)
          {
            int64 = Convert.ToInt64(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 DATALENGTH(Document) FROM tblDocumentStore WHERE DocumentStoreGUID = @DocumentStoreGuid", new object[2]
            {
              (object) "@DocumentStoreGuid",
              (object) documentStoreGuid
            }));
            if (int64 == 0L)
              throw new DocumentMissingException("Document field has 0 length");
          }
          using (MemoryStream memoryStream = new MemoryStream((int) int64))
          {
            long num = 0;
            do
            {
              token.ThrowIfCancellationRequested();
              long bytes = sqlDataReader.GetBytes(ordinal, num, buffer, 0, 1024 /*0x0400*/);
              num += bytes;
              if (callback != null)
                callback((int) num.PercentOf(int64));
              memoryStream.Write(buffer, 0, (int) bytes);
            }
            while (!sqlDataReader.IsClosed && num < int64);
            return memoryStream.ToArray();
          }
        }
      }
    }
  }

  public byte[] GetDocumentBinary(Metadata metadata, CancellationToken token = default (CancellationToken), Action<int> callback = null)
  {
    return this.GetDocumentBinary(metadata.DocumentStoreGuid, token, callback);
  }

  public DocumentLocation PutDocumentBinary(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog($"Uploading to the database - Document Column Type: {this._documentColumnType}", nameof (PutDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 121);
    SqlDbType? documentColumnType = this._documentColumnType;
    if (documentColumnType.HasValue)
    {
      switch (documentColumnType.GetValueOrDefault())
      {
        case SqlDbType.Image:
          this.UploadToImageColumn(documentStoreGuid, document, token, callback);
          break;
        case SqlDbType.VarBinary:
          bool? columnIsFileStream = this._documentColumnIsFileStream;
          bool flag = true;
          if (columnIsFileStream.GetValueOrDefault() == flag & columnIsFileStream.HasValue)
          {
            this.UploadToVarbinaryFileStreamColumn(documentStoreGuid, document, token, callback);
            break;
          }
          this.UploadToVarbinaryColumn(documentStoreGuid, document, token, callback);
          break;
        default:
          goto label_6;
      }
      return DocumentLocation.SQL;
    }
label_6:
    throw new InvalidOperationException($"DocumentStoreBinarySerializationType {this._documentColumnType} is not supported");
  }

  private void UploadToVarbinaryFileStreamColumn(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    ProviderLogging.WriteLog("Uploading to the database", nameof (UploadToVarbinaryFileStreamColumn), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 154);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT [Document].PathName() AS PathName, GET_FILESTREAM_TRANSACTION_CONTEXT() AS serverTxn FROM tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid
    });
    string path = ExtensionsMethods.FieldAs<string>(dataRow, "PathName", DataRowVersion.Current);
    if (string.IsNullOrWhiteSpace(path))
      throw new FileNotFoundException("SQL Server did not return the file stream path name.");
    byte[] transactionContext = ExtensionsMethods.FieldAs<byte[]>(dataRow, "serverTxn", DataRowVersion.Current);
    if (string.IsNullOrWhiteSpace(path))
      throw new FileNotFoundException("SQL Server did not return the file stream transaction context.");
    byte[] buffer = new byte[SqlDocumentProvider.GetBufferLength(document.Length)];
    int numerator = 0;
    using (MemoryStream memoryStream = new MemoryStream(document))
    {
      using (SqlFileStream sqlFileStream = new SqlFileStream(path, transactionContext, FileAccess.Write))
      {
        int count;
        while ((count = memoryStream.Read(buffer, 0, buffer.Length)) > 0)
        {
          token.ThrowIfCancellationRequested();
          sqlFileStream.Write(buffer, 0, count);
          sqlFileStream.Flush();
          numerator += count;
          if (callback != null)
            callback(numerator.PercentOf(document.Length));
          memoryStream.Write(buffer, 0, buffer.Length);
        }
      }
    }
  }

  private void UploadToVarbinaryColumn(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    ProviderLogging.WriteLog("Uploading to the database", nameof (UploadToVarbinaryColumn), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 201);
    int bufferLength = SqlDocumentProvider.GetBufferLength(document.Length);
    byte[] buffer = new byte[bufferLength];
    int numerator = 0;
    using (MemoryStream memoryStream = new MemoryStream(document))
    {
      int num;
      while ((num = memoryStream.Read(buffer, 0, bufferLength)) > 0)
      {
        token.ThrowIfCancellationRequested();
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDocumentStore SET [Document].WRITE(@data, @offset, @len) WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[8]
        {
          (object) "@DocumentStoreGuid",
          (object) documentStoreGuid,
          (object) "@data",
          (object) buffer,
          (object) "@offset",
          (object) numerator,
          (object) "@len",
          (object) num
        });
        numerator += num;
        if (callback != null)
          callback(numerator.PercentOf(document.Length));
      }
    }
  }

  private void UploadToImageColumn(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    ProviderLogging.WriteLog("Uploading to the database", nameof (UploadToImageColumn), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 227);
    int bufferLength = SqlDocumentProvider.GetBufferLength(document.Length);
    byte[] buffer = new byte[bufferLength];
    int numerator = 0;
    byte[] numArray = DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT TEXTPTR(Document) FROM dbo.tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid
    });
    using (MemoryStream memoryStream = new MemoryStream(document))
    {
      int num;
      while ((num = memoryStream.Read(buffer, 0, bufferLength)) > 0)
      {
        token.ThrowIfCancellationRequested();
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATETEXT tblDocumentStore.Document @Pointer @Offset 0 @Bytes", new object[6]
        {
          (object) "@Pointer",
          (object) numArray,
          (object) "@Offset",
          (object) numerator,
          (object) "@Bytes",
          (object) buffer
        });
        numerator += num;
        if (callback != null)
          callback(numerator.PercentOf(document.Length));
      }
    }
  }

  public async Task<DocumentLocation> PutDocumentBinaryAsync(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog($"Uploading to the database - Document Column Type: {this._documentColumnType}", nameof (PutDocumentBinaryAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 266);
    SqlDbType? documentColumnType = this._documentColumnType;
    if (documentColumnType.HasValue)
    {
      switch (documentColumnType.GetValueOrDefault())
      {
        case SqlDbType.Image:
          await this.UploadToImageColumnAsync(documentStoreGuid, document, token, callback);
          break;
        case SqlDbType.VarBinary:
          bool? columnIsFileStream = this._documentColumnIsFileStream;
          bool flag = true;
          if (columnIsFileStream.GetValueOrDefault() == flag & columnIsFileStream.HasValue)
          {
            await this.UploadToVarbinaryFileStreamColumnAsync(documentStoreGuid, document, token, callback);
            break;
          }
          await this.UploadToVarbinaryColumnAsync(documentStoreGuid, document, token, callback);
          break;
        default:
          goto label_6;
      }
      return DocumentLocation.SQL;
    }
label_6:
    throw new InvalidOperationException($"DocumentStoreBinarySerializationType {this._documentColumnType} is not supported");
  }

  private async Task UploadToVarbinaryFileStreamColumnAsync(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    ProviderLogging.WriteLog("Uploading to the database", nameof (UploadToVarbinaryFileStreamColumnAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 299);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT [Document].PathName() AS PathName, GET_FILESTREAM_TRANSACTION_CONTEXT() AS serverTxn FROM tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid
    });
    string path = ExtensionsMethods.FieldAs<string>(dataRow, "PathName", DataRowVersion.Current);
    if (string.IsNullOrWhiteSpace(path))
      throw new FileNotFoundException("SQL Server did not return the file stream path name.");
    byte[] transactionContext = ExtensionsMethods.FieldAs<byte[]>(dataRow, "serverTxn", DataRowVersion.Current);
    if (string.IsNullOrWhiteSpace(path))
      throw new FileNotFoundException("SQL Server did not return the file stream transaction context.");
    byte[] buffer = new byte[SqlDocumentProvider.GetBufferLength(document.Length)];
    int offset = 0;
    int read = 0;
    MemoryStream src = new MemoryStream(document);
    SqlFileStream dst;
    try
    {
      dst = new SqlFileStream(path, transactionContext, FileAccess.Write);
      try
      {
        while (true)
        {
          if ((read = await src.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
          {
            token.ThrowIfCancellationRequested();
            await dst.WriteAsync(buffer, 0, read, token);
            dst.Flush();
            offset += read;
            Action<int> action = callback;
            if (action != null)
              action(offset.PercentOf(document.Length));
            await src.WriteAsync(buffer, 0, buffer.Length, token);
          }
          else
            break;
        }
      }
      finally
      {
        dst?.Dispose();
      }
    }
    finally
    {
      src?.Dispose();
    }
    buffer = (byte[]) null;
    src = (MemoryStream) null;
    dst = (SqlFileStream) null;
  }

  private async Task UploadToVarbinaryColumnAsync(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    ProviderLogging.WriteLog("Uploading to the database", nameof (UploadToVarbinaryColumnAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 346);
    int bufferLength = SqlDocumentProvider.GetBufferLength(document.Length);
    byte[] buffer = new byte[bufferLength];
    int offset = 0;
    MemoryStream memoryStream = new MemoryStream(document);
    try
    {
      while (true)
      {
        Action<int> action;
        do
        {
          int num;
          if ((num = await memoryStream.ReadAsync(buffer, 0, bufferLength, token)) > 0)
          {
            token.ThrowIfCancellationRequested();
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDocumentStore SET [Document].WRITE(@data, @offset, @len) WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[8]
            {
              (object) "@DocumentStoreGuid",
              (object) documentStoreGuid,
              (object) "@data",
              (object) buffer,
              (object) "@offset",
              (object) offset,
              (object) "@len",
              (object) num
            });
            offset += num;
            action = callback;
          }
          else
            goto label_9;
        }
        while (action == null);
        action(offset.PercentOf(document.Length));
      }
    }
    finally
    {
      memoryStream?.Dispose();
    }
label_9:
    buffer = (byte[]) null;
    memoryStream = (MemoryStream) null;
  }

  private async Task UploadToImageColumnAsync(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    ProviderLogging.WriteLog("Uploading to the database", nameof (UploadToImageColumnAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 372);
    int bufferLength = SqlDocumentProvider.GetBufferLength(document.Length);
    byte[] buffer = new byte[bufferLength];
    int offset = 0;
    byte[] textPtr = DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT TEXTPTR(Document) FROM dbo.tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid
    });
    MemoryStream memoryStream = new MemoryStream(document);
    try
    {
      while (true)
      {
        Action<int> action;
        do
        {
          int num;
          if ((num = await memoryStream.ReadAsync(buffer, 0, bufferLength, token)) > 0)
          {
            token.ThrowIfCancellationRequested();
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATETEXT tblDocumentStore.Document @Pointer @Offset 0 @Bytes", new object[6]
            {
              (object) "@Pointer",
              (object) textPtr,
              (object) "@Offset",
              (object) offset,
              (object) "@Bytes",
              (object) buffer
            });
            offset += num;
            action = callback;
          }
          else
            goto label_9;
        }
        while (action == null);
        action(offset.PercentOf(document.Length));
      }
    }
    finally
    {
      memoryStream?.Dispose();
    }
label_9:
    buffer = (byte[]) null;
    textPtr = (byte[]) null;
    memoryStream = (MemoryStream) null;
  }

  private void CacheDocumentColumnType()
  {
    ProviderLogging.WriteLog("Cache document store document data type.", nameof (CacheDocumentColumnType), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\SqlDocumentProvider.cs", 406);
    if (this._documentColumnType.HasValue && this._documentColumnIsFileStream.HasValue)
      return;
    SqlDbType? nullable1;
    bool? nullable2;
    try
    {
      (SqlDbType, bool) tuple = this.FetchColumnDataType("tblDocumentStore", "Document");
      nullable1 = new SqlDbType?(tuple.Item1);
      nullable2 = new bool?(tuple.Item2);
      this._documentColumnType = nullable1;
      this._documentColumnIsFileStream = nullable2;
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      nullable1 = new SqlDbType?(SqlDbType.Image);
      nullable2 = new bool?(false);
      this._documentColumnType = nullable1;
      this._documentColumnIsFileStream = nullable2;
    }
  }

  private (SqlDbType, bool) FetchColumnDataType(string tableName, string columnName)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("FetchColumnInformation", new object[4]
    {
      (object) "@tableName",
      (object) tableName,
      (object) "@columnName",
      (object) columnName
    });
    bool flag = dataRow != null && ExtensionsMethods.FieldAs<bool>(dataRow, "is_filestream", DataRowVersion.Current);
    string str = (dataRow != null ? ExtensionsMethods.FieldAs<string>(dataRow, "data_Type", DataRowVersion.Current) : (string) null) ?? "image";
    SqlDbType result;
    if (!Enum.TryParse<SqlDbType>(str, true, out result))
      throw new SqlTypeException($"Unable to determine column type for table {tableName}, column {columnName}. Invalid column type: {str}");
    return (result, flag);
  }

  private static int GetBufferLength(int documentLength)
  {
    int bufferLength = ExtensionsMethods.FieldAs<int>(DefaultDatabase.ExecuteDataRow(CommandType.StoredProcedure, "spUploadPacketSizeGet", new object[2]
    {
      (object) "@DocLength",
      (object) documentLength
    }), "BufferLength", DataRowVersion.Current);
    if (bufferLength == 0)
      bufferLength = documentLength;
    return bufferLength;
  }
}

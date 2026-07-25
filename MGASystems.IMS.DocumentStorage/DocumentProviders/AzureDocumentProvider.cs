// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.AzureDocumentProvider
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

public class AzureDocumentProvider : IDocumentRepository, IDocumentReader, IDocumentWriter
{
  private readonly CloudBlobClient _client;
  private readonly string _containerName;
  private bool? _isAccessible;

  public AzureDocumentProvider(CloudBlobClient client, string containerName)
  {
    if (client == null)
      throw new ArgumentNullException(nameof (client));
    if (containerName == null)
      throw new ArgumentNullException(nameof (containerName));
    if (!Regex.IsMatch(containerName, "^(([\\da-z]-?[\\da-z])|[\\da-z])+$"))
      throw new ArgumentException($"Bucket name '{containerName}' doesn't match regex");
    if (containerName.Length < 3)
      throw new ArgumentException($"Bucket name '{containerName}' is too short ({containerName.Length} characters)");
    if (containerName.Length > 63 /*0x3F*/)
      throw new ArgumentException($"Bucket name '{containerName}' is too long ({containerName.Length} characters)");
    if (Uri.CheckHostName(containerName) != UriHostNameType.Dns)
      throw new ArgumentException($"Bucket name '{containerName}' is not DNS compliant");
    this._client = client;
    this._containerName = containerName;
  }

  public AzureDocumentProvider(
    StorageUri uri,
    StorageCredentials credentials,
    string containerName)
    : this(new CloudBlobClient(uri, credentials), containerName)
  {
  }

  public AzureDocumentProvider(
    Uri primaryUri,
    string accountName,
    string keyValue,
    string containerName)
    : this(new StorageUri(primaryUri), new StorageCredentials(accountName, keyValue), containerName)
  {
  }

  public AzureDocumentProvider(
    Uri primaryUri,
    Uri secondaryUri,
    string accountName,
    string keyValue,
    string containerName)
    : this(new StorageUri(primaryUri, secondaryUri), new StorageCredentials(accountName, keyValue), containerName)
  {
  }

  public bool IsAccessible()
  {
    bool valueOrDefault = this._isAccessible.GetValueOrDefault();
    if (this._isAccessible.HasValue)
      return valueOrDefault;
    bool flag = this._client.GetContainerReference(this._containerName).Exists((BlobRequestOptions) null, (OperationContext) null);
    this._isAccessible = new bool?(flag);
    return flag;
  }

  public byte[] GetDocumentBinary(
    Guid documentStoreGuid,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Downloading from Azure", nameof (GetDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\AzureDocumentProvider.cs", 99);
    CloudBlobContainer containerReference = this._client.GetContainerReference(this._containerName);
    CloudBlockBlob blockBlobReference = containerReference.GetBlockBlobReference(documentStoreGuid.ToString());
    if (!((CloudBlob) blockBlobReference).Exists((BlobRequestOptions) null, (OperationContext) null))
      throw new DocumentMissingException($"Document {documentStoreGuid} does not exist in Azure container {containerReference.Name}");
    if (((CloudBlob) blockBlobReference).Properties.Length < 1L)
      return Array.Empty<byte>();
    long length = ((CloudBlob) blockBlobReference).Properties.Length;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (ProgressStream progressStream = new ProgressStream((Stream) memoryStream, token))
      {
        progressStream.ProgressChanged += (EventHandler<int>) ((o, e) =>
        {
          Action<int> action = callback;
          if (action == null)
            return;
          action(e.PercentOf((int) length));
        });
        AzureDocumentProvider.ExecuteAzureOperation(token, (Action) (() => ((CloudBlob) blockBlobReference).DownloadToStream((Stream) progressStream, (AccessCondition) null, (BlobRequestOptions) null, (OperationContext) null)));
        return memoryStream.ToArray();
      }
    }
  }

  public byte[] GetDocumentBinary(Metadata metadata, CancellationToken token = default (CancellationToken), Action<int> callback = null)
  {
    return this.GetDocumentBinary(metadata.DocumentStoreGuid, token, callback);
  }

  public DocumentLocation PutDocumentBinary(
    Guid documentStoreGuid,
    byte[] documentBytes,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Uploading to Azure", nameof (PutDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\AzureDocumentProvider.cs", 151);
    CloudBlockBlob blockBlobReference = this._client.GetContainerReference(this._containerName).GetBlockBlobReference(documentStoreGuid.ToString());
    using (MemoryStream memoryStream = new MemoryStream(documentBytes))
    {
      using (ProgressStream progressStream = new ProgressStream((Stream) memoryStream, token))
      {
        progressStream.ProgressChanged += (EventHandler<int>) ((o, e) =>
        {
          Action<int> action = callback;
          if (action == null)
            return;
          action(e.PercentOf(documentBytes.Length));
        });
        AzureDocumentProvider.ExecuteAzureOperation(token, (Action) (() => blockBlobReference.UploadFromStream((Stream) progressStream, (AccessCondition) null, (BlobRequestOptions) null, (OperationContext) null)));
        return DocumentLocation.Azure;
      }
    }
  }

  public async Task<DocumentLocation> PutDocumentBinaryAsync(
    Guid documentStoreGuid,
    byte[] documentBytes,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Uploading to Azure", nameof (PutDocumentBinaryAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\AzureDocumentProvider.cs", 177);
    CloudBlockBlob blockBlobReference = this._client.GetContainerReference(this._containerName).GetBlockBlobReference(documentStoreGuid.ToString());
    ProgressStream progressStream;
    DocumentLocation documentLocation;
    using (MemoryStream memoryStream = new MemoryStream(documentBytes))
    {
      progressStream = new ProgressStream((Stream) memoryStream, token);
      try
      {
        progressStream.ProgressChanged += (EventHandler<int>) ((o, e) =>
        {
          Action<int> action = callback;
          if (action == null)
            return;
          action(e.PercentOf(documentBytes.Length));
        });
        try
        {
          await blockBlobReference.UploadFromStreamAsync((Stream) progressStream, token);
        }
        catch (Exception ex) when (ex.InnerException is ArgumentException)
        {
          token.ThrowIfCancellationRequested();
          throw;
        }
        documentLocation = DocumentLocation.Azure;
      }
      finally
      {
        progressStream?.Dispose();
      }
    }
    progressStream = (ProgressStream) null;
    return documentLocation;
  }

  private static void ExecuteAzureOperation(CancellationToken token, Action operation)
  {
    try
    {
      operation();
    }
    catch (Exception ex) when (ex.InnerException is ArgumentException)
    {
      token.ThrowIfCancellationRequested();
      throw;
    }
  }
}

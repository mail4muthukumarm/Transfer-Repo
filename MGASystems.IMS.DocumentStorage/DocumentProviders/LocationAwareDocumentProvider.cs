// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.LocationAwareDocumentProvider
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.IMS.DocumentStorage.MetadataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

public class LocationAwareDocumentProvider : IDocumentRepository, IDocumentReader, IDocumentWriter
{
  private readonly Dictionary<DocumentLocation, IDocumentRepository> _documentProviders;
  private readonly IMetadataProvider _metadataProvider;

  public LocationAwareDocumentProvider(
    Dictionary<DocumentLocation, IDocumentRepository> providers,
    IMetadataProvider metadataProvider)
  {
    this._documentProviders = providers;
    this._metadataProvider = metadataProvider;
  }

  public bool IsAccessible()
  {
    return this._documentProviders.Any<KeyValuePair<DocumentLocation, IDocumentRepository>>((Func<KeyValuePair<DocumentLocation, IDocumentRepository>, bool>) (p => p.Value.IsAccessible()));
  }

  public byte[] GetDocumentBinary(
    Guid documentStoreGuid,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    return this.GetDocumentBinary(this._metadataProvider.GetMetadata(documentStoreGuid), token, callback);
  }

  public byte[] GetDocumentBinary(Metadata metadata, CancellationToken token = default (CancellationToken), Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Downloading document.", nameof (GetDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\LocationAwareDocumentProvider.cs", 65);
    List<Exception> exceptionList = new List<Exception>();
    foreach (DocumentLocation key in (IEnumerable<DocumentLocation>) Enum.GetValues(typeof (DocumentLocation)).Cast<DocumentLocation>().Where<DocumentLocation>((Func<DocumentLocation, bool>) (location => metadata.DocumentLocation.HasFlag((Enum) location) && this._documentProviders.ContainsKey(location))).OrderByDescending<DocumentLocation, DocumentLocation>((Func<DocumentLocation, DocumentLocation>) (location => location)))
    {
      IDocumentRepository documentProvider = this._documentProviders[key];
      if (documentProvider.IsAccessible())
      {
        try
        {
          return documentProvider.GetDocumentBinary(metadata.DocumentStoreGuid, token, callback);
        }
        catch (OperationCanceledException ex)
        {
          throw;
        }
        catch (Exception ex)
        {
          ErrorHandler.SilentHandleError(ex);
          exceptionList.Add((Exception) new DocumentMissingException($"Error getting document from '{documentProvider.GetType().Name}': '{ex.Message}'", ex));
        }
      }
    }
    Exception innerException = exceptionList.Count > 1 ? (Exception) new AggregateException((IEnumerable<Exception>) exceptionList) : exceptionList.First<Exception>();
    throw new DocumentMissingException($"Unable to find a document provider for {metadata.DocumentStoreGuid}", innerException);
  }

  public DocumentLocation PutDocumentBinary(
    Guid documentStoreGuid,
    byte[] documentBytes,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Uploading document.", nameof (PutDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\LocationAwareDocumentProvider.cs", 114);
    Metadata metadata = this._metadataProvider.GetMetadata(documentStoreGuid);
    List<Exception> exceptionList = new List<Exception>();
    foreach (IDocumentRepository documentRepository in this.GetOrderedDocumentRepositories())
    {
      token.ThrowIfCancellationRequested();
      try
      {
        if (documentRepository.IsAccessible())
        {
          DocumentLocation documentLocation = documentRepository.PutDocumentBinary(metadata.DocumentStoreGuid, documentBytes, token, callback);
          if (!metadata.DocumentLocation.HasFlag((Enum) documentLocation))
          {
            ProviderLogging.WriteLog("Updating document location.", nameof (PutDocumentBinary), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\LocationAwareDocumentProvider.cs", 131);
            this._metadataProvider.AddDocumentLocation(metadata.DocumentStoreGuid, documentLocation);
          }
          return documentLocation;
        }
      }
      catch (OperationCanceledException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        ErrorHandler.SilentHandleError(ex);
        exceptionList.Add((Exception) new RepositoryWriterException($"Error writing document to '{documentRepository.GetType().Name}': '{ex.Message}'", ex));
      }
    }
    Exception innerException = exceptionList.Count > 1 ? (Exception) new AggregateException((IEnumerable<Exception>) exceptionList) : exceptionList.First<Exception>();
    throw new RepositoryWriterException($"Unable to find a document provider for {metadata.DocumentStoreGuid}", innerException);
  }

  public async Task<DocumentLocation> PutDocumentBinaryAsync(
    Guid documentStoreGuid,
    byte[] documentBytes,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null)
  {
    token.ThrowIfCancellationRequested();
    ProviderLogging.WriteLog("Uploading document.", nameof (PutDocumentBinaryAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\LocationAwareDocumentProvider.cs", 170);
    Metadata metadata = this._metadataProvider.GetMetadata(documentStoreGuid);
    List<Exception> exceptions = new List<Exception>();
    DocumentLocation documentLocation1;
    using (IEnumerator<IDocumentRepository> enumerator = this.GetOrderedDocumentRepositories().GetEnumerator())
    {
      while (true)
      {
        if (enumerator.MoveNext())
        {
          IDocumentRepository documentProvider = enumerator.Current;
          token.ThrowIfCancellationRequested();
          if (documentProvider.IsAccessible())
          {
            try
            {
              DocumentLocation documentLocation2 = await documentProvider.PutDocumentBinaryAsync(metadata.DocumentStoreGuid, documentBytes, token, callback);
              if (!metadata.DocumentLocation.HasFlag((Enum) documentLocation2))
              {
                ProviderLogging.WriteLog("Updating document location.", nameof (PutDocumentBinaryAsync), "c:\\BuildAgent\\_work\\3835\\s\\MGASystems.IMS.DocumentStorage\\DocumentProviders\\LocationAwareDocumentProvider.cs", 187);
                this._metadataProvider.AddDocumentLocation(metadata.DocumentStoreGuid, documentLocation2);
              }
              documentLocation1 = documentLocation2;
              goto label_15;
            }
            catch (OperationCanceledException ex)
            {
              throw;
            }
            catch (Exception ex)
            {
              ErrorHandler.SilentHandleError(ex);
              exceptions.Add((Exception) new RepositoryWriterException($"Error writing document to '{documentProvider.GetType().Name}': '{ex.Message}'", ex));
            }
          }
          documentProvider = (IDocumentRepository) null;
        }
        else
          break;
      }
    }
    Exception innerException = exceptions.Count > 1 ? (Exception) new AggregateException((IEnumerable<Exception>) exceptions) : exceptions.First<Exception>();
    throw new RepositoryWriterException($"Unable to find a document provider for {metadata.DocumentStoreGuid}", innerException);
label_15:
    metadata = (Metadata) null;
    exceptions = (List<Exception>) null;
    return documentLocation1;
  }

  private IEnumerable<IDocumentRepository> GetOrderedDocumentRepositories()
  {
    DocumentLocation preferredDocumentLocation;
    if (!Enum.TryParse<DocumentLocation>(SystemSettings.GetSetting<string>("DocStore.PreferredLocation", "SQL"), out preferredDocumentLocation))
      preferredDocumentLocation = DocumentLocation.SQL;
    if (preferredDocumentLocation != DocumentLocation.SQL)
      return this._documentProviders.Where<KeyValuePair<DocumentLocation, IDocumentRepository>>((Func<KeyValuePair<DocumentLocation, IDocumentRepository>, bool>) (kvp => kvp.Key == preferredDocumentLocation)).Concat<KeyValuePair<DocumentLocation, IDocumentRepository>>(this._documentProviders.Where<KeyValuePair<DocumentLocation, IDocumentRepository>>((Func<KeyValuePair<DocumentLocation, IDocumentRepository>, bool>) (kvp => kvp.Key != preferredDocumentLocation))).Select<KeyValuePair<DocumentLocation, IDocumentRepository>, IDocumentRepository>((Func<KeyValuePair<DocumentLocation, IDocumentRepository>, IDocumentRepository>) (kvp => kvp.Value));
    return (IEnumerable<IDocumentRepository>) new \u003C\u003Ez__ReadOnlyArray<IDocumentRepository>(new IDocumentRepository[1]
    {
      this._documentProviders[DocumentLocation.SQL]
    });
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.Controller.FilingController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.Controller;

public class FilingController(
  string applicationUri,
  string apiKey,
  IProgress<string> logAction,
  IProgress<Exception> errorHandlingAction) : BaseController<FilingController>(applicationUri, apiKey, logAction, errorHandlingAction)
{
  public async Task<FilingResponse> FileInvoice(FilingRequest request)
  {
    FilingResponse filingResponse = await this.ApiCall<FilingTransaction[]>(request.Transactions, HttpMethod.Post, this.BaseUri.AppendUrlParts("transaction.json"), nameof (FileInvoice)).ConfigureAwait(false);
    int num;
    if (filingResponse == null)
    {
      num = 1;
    }
    else
    {
      ResponseTransaction[] transactions = filingResponse.Transactions;
      bool? nullable = transactions != null ? new bool?(((IEnumerable<ResponseTransaction>) transactions).Any<ResponseTransaction>()) : new bool?();
      bool flag = true;
      num = !(nullable.GetValueOrDefault() == flag & nullable.HasValue) ? 1 : 0;
    }
    if (num != 0)
      return filingResponse;
    Dictionary<string, FilingTransaction> dictionary = ((IEnumerable<FilingTransaction>) request.Transactions).ToDictionary<FilingTransaction, string>((Func<FilingTransaction, string>) (trans => trans.UniqueID));
    foreach (ResponseTransaction transaction in filingResponse.Transactions)
    {
      FilingTransaction filingTransaction;
      if (!string.IsNullOrEmpty(transaction.ID) && dictionary.TryGetValue(transaction.ID, out filingTransaction))
        transaction.RequestTransaction = filingTransaction;
    }
    return filingResponse;
  }

  public async Task<FilingResponse> GetBatchInformation(string BatchID)
  {
    return await this.ApiCall<IgnoreType>(IgnoreType.Instance, HttpMethod.Get, this.BaseUri.AppendUrlParts("transaction-import-results.json").AddQueryParameter("batch_id", BatchID), nameof (GetBatchInformation)).ConfigureAwait(false);
  }

  public async Task<FilingResponse> UploadInvoiceDocuments(
    UploadRequest request,
    string InvoiceNumber)
  {
    return await this.ApiCall<TransactionDocument[]>(request.Documents, HttpMethod.Post, this.BaseUri.AppendUrlParts("transaction", InvoiceNumber, "documents.json").AddQueryParameter("useInvoiceNumber", "1"), nameof (UploadInvoiceDocuments)).ConfigureAwait(false);
  }

  public async Task<FilingResponse> UploadTransactionDocuments(
    UploadRequest request,
    string TransactionID)
  {
    return await this.ApiCall<TransactionDocument[]>(request.Documents, HttpMethod.Post, this.BaseUri.AppendUrlParts("transaction", TransactionID, "documents.json"), nameof (UploadTransactionDocuments)).ConfigureAwait(false);
  }

  private async Task<FilingResponse> ApiCall<T>(
    T request,
    HttpMethod method,
    Uri endpointUrl,
    [CallerMemberName] string operation = null)
  {
    return await this.CallController<T, FilingResponse>(request, method, endpointUrl, (Func<Exception, FilingResponse>) (ex =>
    {
      return new FilingResponse()
      {
        Status = "APIError",
        Transactions = new ResponseTransaction[1]
        {
          new ResponseTransaction() { StatusMessage = ex.Message }
        }
      };
    }), operation).ConfigureAwait(false);
  }
}

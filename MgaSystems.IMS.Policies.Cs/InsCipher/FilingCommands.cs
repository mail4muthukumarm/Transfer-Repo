// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.InsCipher.FilingCommands
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using MgaSystems.IMS.UnderwritingServices.InsCipher.Controller;
using MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.Policies.InsCipher;

[LogCategory("SurplusLines.InsCipher.FilingCommands", "InsCipher")]
public class FilingCommands
{
  internal const string LogDestination = "SurplusLines.InsCipher.FilingCommands";

  public static void WriteLog(string logText)
  {
    Log.Write(logText, "SurplusLines.InsCipher.FilingCommands");
  }

  public FilingCommands(IProgress<string> actionLog = null, IProgress<Exception> errorLog = null)
  {
    IProgress<string> progress1 = actionLog;
    IProgress<Exception> progress2 = errorLog;
    this.ActionProgress = progress1;
    this.ErrorProgress = progress2;
  }

  private IProgress<string> ActionProgress { get; }

  private IProgress<Exception> ErrorProgress { get; }

  private FilingTransaction[] GetFilingTransactions(Guid quoteGuid, int? invoiceNumber = null)
  {
    return NewObject<FilingTransaction>.FromDataTable(DefaultDatabase.ExecuteDataTable("dbo.InsCipher_GetQuoteFilingData", new object[4]
    {
      (object) "@quoteGuid",
      (object) quoteGuid,
      (object) "@invoiceNumber",
      (object) invoiceNumber
    })).ToArray<FilingTransaction>();
  }

  public async Task<FilingResponse> FilePendingInvoices(Guid quoteGuid)
  {
    this.ActionProgress?.Report("Retrieving pending invoices.");
    DataTable pendingQuotes = DefaultDatabase.ExecuteDataTable("dbo.InsCipher_GetPendingTransactions", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    });
    if (pendingQuotes != null && pendingQuotes.Rows.Count == 0)
      return (FilingResponse) null;
    this.ActionProgress?.Report($"Found {pendingQuotes.Rows.Count} pending invoice transactions.");
    return await this.FilePendingInvoices(pendingQuotes, quoteGuid).ConfigureAwait(false);
  }

  public async Task<FilingResponse> FilePendingInvoices(DataTable pendingQuotes, Guid quoteGuid)
  {
    DataTable dataTable1 = pendingQuotes;
    if ((dataTable1 != null ? (!dataTable1.Columns.Contains("QuoteGUID") ? 1 : 0) : 1) == 0)
    {
      DataTable dataTable2 = pendingQuotes;
      if ((dataTable2 != null ? (!dataTable2.Columns.Contains("DateBound") ? 1 : 0) : 1) == 0)
      {
        this.ActionProgress?.Report("Compiling filing request...");
        FilingTransaction[] array = pendingQuotes.AsEnumerable().OrderBy<DataRow, DateTime>((System.Func<DataRow, DateTime>) (dr => dr.Field<DateTime>("DateBound"))).SelectMany<DataRow, FilingTransaction>((System.Func<DataRow, IEnumerable<FilingTransaction>>) (dr => (IEnumerable<FilingTransaction>) this.GetFilingTransactions(dr.Field<Guid>("QuoteGUID")))).ToArray<FilingTransaction>();
        return await this.SubmitRequest(new FilingRequest()
        {
          Transactions = array
        }, quoteGuid, callingMethod: nameof (FilePendingInvoices)).ConfigureAwait(false);
      }
    }
    throw new ArgumentException("Supplied table must have QuoteGUID and DateBound columns.", nameof (pendingQuotes));
  }

  public async Task<FilingResponse> FileQuoteInvoice(Quote quote)
  {
    return await this.FileQuoteInvoice(quote.QuoteGuid).ConfigureAwait(false);
  }

  public async Task<FilingResponse> FileQuoteInvoice(Guid quoteGuid)
  {
    return await this.SubmitRequest(new FilingRequest()
    {
      Transactions = this.GetFilingTransactions(quoteGuid)
    }, quoteGuid, callingMethod: nameof (FileQuoteInvoice)).ConfigureAwait(false);
  }

  public async Task<FilingResponse> FileInvoice(int invoiceNumber)
  {
    this.ActionProgress?.Report($"Retrieving invoice {invoiceNumber}");
    Quote quote = new Invoice(invoiceNumber).Quote;
    this.ActionProgress?.Report($"Resolved Quote, Control #{quote.ControlNo} (QuoteID: {quote.QuoteID})");
    return await this.SubmitRequest(new FilingRequest()
    {
      Transactions = this.GetFilingTransactions(quote.QuoteGuid)
    }, quote.QuoteGuid, new int?(invoiceNumber), nameof (FileInvoice));
  }

  private async Task<FilingResponse> SubmitRequest(
    FilingRequest request,
    Guid quoteGuid,
    int? invoiceNumber = null,
    [CallerMemberName] string callingMethod = "SubmitRequest")
  {
    FilingRequest filingRequest = request;
    int num;
    if (filingRequest == null)
    {
      num = 1;
    }
    else
    {
      FilingTransaction[] transactions = filingRequest.Transactions;
      num = !(transactions != null ? new bool?(((IEnumerable<FilingTransaction>) transactions).Any<FilingTransaction>()) : new bool?()).GetValueOrDefault() ? 1 : 0;
    }
    if (num != 0)
      return new FilingResponse()
      {
        Status = "No transactions to import."
      };
    FilingResponse filingResponse = await this.CallService<FilingResponse>(quoteGuid, invoiceNumber, (System.Func<FilingController, Task<FilingResponse>>) (api => api.FileInvoice(request)), callingMethod: callingMethod).ConfigureAwait(false);
    foreach (ResponseTransaction responseTransaction in filingResponse != null ? ((IEnumerable<ResponseTransaction>) filingResponse.Transactions).DefaultIfEmpty<ResponseTransaction>() : (IEnumerable<ResponseTransaction>) null)
    {
      FilingTransaction requestTransaction = responseTransaction.RequestTransaction;
      if (requestTransaction != null)
      {
        try
        {
          DefaultDatabase.ExecuteNonQuery("dbo.InsCipher_LogInvoiceFiling", new object[8]
          {
            (object) "@invNumber",
            (object) requestTransaction.InvoiceNumber,
            (object) "@batchID",
            (object) filingResponse.BatchID,
            (object) "@transactionID",
            (object) responseTransaction.TransactionID,
            (object) "@filingStatus",
            (object) responseTransaction.StatusMessage
          });
        }
        catch (Exception ex)
        {
          this.ErrorProgress?.Report(ex);
        }
      }
    }
    return filingResponse;
  }

  private string ModifyDocumentRequestJson(string requestJson)
  {
    if (string.IsNullOrWhiteSpace(requestJson))
      return requestJson;
    JObject jobject = JObject.Parse(requestJson);
    foreach (JProperty jproperty in ((JContainer) jobject).Descendants().OfType<JProperty>().Where<JProperty>((System.Func<JProperty, bool>) (jprop => jprop.Name.EqualsNoCase("file"))))
      jproperty.Value = !(jproperty.Value is JValue jvalue) || !(jvalue.Value is byte[] numArray) ? (JToken) null : JToken.op_Implicit($"Length: {numArray.Length}");
    return ((JToken) jobject).ToString((Formatting) 0, Array.Empty<JsonConverter>());
  }

  private async Task<TResponse> CallService<TResponse>(
    Guid quoteGuid,
    int? invoiceNumber,
    System.Func<FilingController, Task<TResponse>> apiCommand,
    System.Func<string, string> onRequestJson = null,
    System.Func<string, string> onResponseJson = null,
    [CallerMemberName] string callingMethod = "CallService")
  {
    TResponse retVal = default (TResponse);
    string reqJson = (string) null;
    string reqUrl = (string) null;
    string respJson = (string) null;
    try
    {
      FilingController filingController = new FilingController(MGASystems.Common.Settings.SystemSettings.GetSetting<string>("InsCipher.Filing.Url"), MGASystems.Common.Settings.SystemSettings.GetEncryptedSetting("InsCipher.Filing.ApiKey"), this.ActionProgress, this.ErrorProgress);
      filingController.SetUrlListener((Action<string>) (url => reqUrl = url)).SetRequestJsonlListener((Action<string>) (req =>
      {
        System.Func<string, string> func = onRequestJson;
        reqJson = (func != null ? func(req) : (string) null) ?? req;
      })).SetResponseJsonListener((Action<string>) (resp =>
      {
        System.Func<string, string> func = onResponseJson;
        respJson = (func != null ? func(resp) : (string) null) ?? resp;
      }));
      retVal = await apiCommand(filingController).ConfigureAwait(false);
    }
    catch (Exception ex)
    {
      this.ErrorProgress?.Report(ex);
    }
    finally
    {
      int num;
      if (num < 0 && !string.IsNullOrEmpty(reqUrl) && (!string.IsNullOrEmpty(reqJson) || !string.IsNullOrEmpty(respJson)))
        DefaultDatabase.ExecuteNonQuery("dbo.InsCipher_LogAPICall", new object[14]
        {
          (object) "@quoteGuid",
          (object) quoteGuid,
          (object) "@invoiceNum",
          (object) invoiceNumber,
          (object) "@operation",
          (object) callingMethod,
          (object) "@url",
          (object) reqUrl,
          (object) "@requestJson",
          (object) reqJson,
          (object) "@responseJson",
          (object) respJson,
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID
        });
    }
    TResponse response = retVal;
    retVal = default (TResponse);
    return response;
  }
}

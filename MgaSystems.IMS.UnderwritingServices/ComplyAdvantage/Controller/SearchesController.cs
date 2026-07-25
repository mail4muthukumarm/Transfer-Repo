// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller.SearchesController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller;

public class SearchesController : RestServiceBase<SearchesController>
{
  private const string SearchesEndpoint = "searches";

  private string SearchesUri { get; }

  private string ApiKey { get; }

  public SearchesController(
    string applicationUri,
    string apiKey,
    IProgress<string> logAction = null,
    IProgress<Exception> errorHandlingAction = null)
    : base(applicationUri, logAction, errorHandlingAction)
  {
    if (string.IsNullOrWhiteSpace(apiKey))
      throw new ArgumentException("API key required", nameof (apiKey));
    if (this.BaseUri.Scheme != Uri.UriSchemeHttps)
      throw new ArgumentException($"Application URI scheme must be \"{Uri.UriSchemeHttps}\"", nameof (applicationUri));
    this.ApiKey = apiKey;
    RestServiceBase<SearchesController>.ServiceClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse("Token " + this.ApiKey);
    this.SearchesUri = applicationUri.AppendUrlParts("searches");
  }

  public async Task<SearchResult> Search(string searchTerm, Decimal fuzziness = 0M)
  {
    return await this.Search(new SearchRequest()
    {
      SearchTerm = searchTerm,
      Fuzziness = new Decimal?(fuzziness),
      Filters = SearchFilters.DefaultFilters,
      ShareUrl = true
    }).ConfigureAwait(false);
  }

  public async Task<SearchResult> Search(SearchRequest request)
  {
    return await this.Call<SearchRequest, SearchResult>(request, HttpMethod.Post, this.SearchesUri, operation: nameof (Search)).ConfigureAwait(false);
  }

  public async Task<SearchResult> GetSearch(string id, bool share_url = true)
  {
    return await this.Call<IgnoreType, SearchResult>(IgnoreType.Instance, HttpMethod.Get, this.SearchesUri.AppendUrlParts(id).AddQueryParameter(nameof (share_url), $"{Convert.ToInt32(share_url)}").ToString(), operation: nameof (GetSearch)).ConfigureAwait(false);
  }

  public async Task<CertificateResult> GetSearchCertificate(string id)
  {
    CertificateResult result = new CertificateResult();
    IgnoreType instance = IgnoreType.Instance;
    HttpMethod get = HttpMethod.Get;
    string endpointUrl = this.SearchesUri.AppendUrlParts(id ?? "", "certificate");
    Action<HttpResponseMessage> onResponse = (Action<HttpResponseMessage>) (resp => result.Filename = resp.Content?.Headers?.ContentDisposition?.FileName);
    result.Data = Encoding.UTF8.GetBytes(await this.Call<IgnoreType>(instance, get, endpointUrl, onResponse: onResponse, operation: nameof (GetSearchCertificate)).ConfigureAwait(false));
    return result;
  }

  public async Task<UpdateResult> UpdateSearch(string id, MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.UpdateSearch update)
  {
    return await this.Call<MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.UpdateSearch, UpdateResult>(update, new HttpMethod("PATCH"), this.SearchesUri.AppendUrlParts(id), operation: nameof (UpdateSearch)).ConfigureAwait(false);
  }
}

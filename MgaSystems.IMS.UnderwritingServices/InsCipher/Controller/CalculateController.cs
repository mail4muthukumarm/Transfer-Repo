// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.Controller.CalculateController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Extensions;
using MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.Controller;

public class CalculateController : BaseController<CalculateController>
{
  public CalculateController(
    string applicationUri,
    string apiKey,
    IProgress<string> logAction,
    IProgress<Exception> errorHandlingAction)
    : base(applicationUri, apiKey, logAction, errorHandlingAction)
  {
    this.JsonSettings.NullValueHandling = (NullValueHandling) 1;
  }

  public async Task<CalculateResponse> Calculate(CalculateRequest request)
  {
    return await this.ApiCall<CalculateRequest>(request, HttpMethod.Post, this.BaseUri.AppendUrlParts("calculate-general-taxes.json"), nameof (Calculate)).ConfigureAwait(false);
  }

  private async Task<CalculateResponse> ApiCall<T>(
    T request,
    HttpMethod method,
    Uri endpointUrl,
    [CallerMemberName] string operation = null)
  {
    return await this.CallController<T, CalculateResponse>(request, method, endpointUrl, new Func<Exception, CalculateResponse>(this.ParseErrorResponse), operation).ConfigureAwait(false);
  }

  private CalculateResponse ParseErrorResponse(Exception apiException)
  {
    CalculateResponse errorResponse = (CalculateResponse) null;
    string dataValue;
    if (apiException.TryGetDataValue<string>((object) "BaseController.ResponseContent", out dataValue))
    {
      try
      {
        errorResponse = JsonConvert.DeserializeObject<CalculateResponse>(dataValue);
      }
      catch
      {
      }
    }
    (errorResponse ?? (errorResponse = new CalculateResponse())).ApiException = apiException;
    return errorResponse;
  }
}

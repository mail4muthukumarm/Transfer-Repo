// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.GeoCode.Controller.DistanceToWater
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.GeoCode.ServiceObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.GeoCode.Controller;

public class DistanceToWater
{
  private static readonly HttpClient ServiceClient = new HttpClient();

  private string ApplicationUrl { get; }

  private string ApiKey { get; }

  public DistanceToWater(string applicationUri, string apiKey)
  {
    this.ApplicationUrl = applicationUri;
    this.ApiKey = apiKey;
  }

  public async Task<DistanceResult> GetDistance(
    string buildingNumber = null,
    string address = null,
    string city = null,
    string state = null,
    string zipCode = null)
  {
    string rawResponse = (string) null;
    try
    {
      using (HttpRequestMessage distanceRequest = new HttpRequestMessage(HttpMethod.Get, this.ApplicationUrl))
      {
        IEnumerable<string> values = ((IEnumerable<string>) new string[5]
        {
          buildingNumber,
          address,
          city,
          state,
          zipCode
        }).Where<string>((Func<string, bool>) (f => !string.IsNullOrEmpty(f)));
        distanceRequest.Content = (HttpContent) new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>) new Dictionary<string, string>()
        {
          {
            "Token",
            this.ApiKey
          },
          {
            "Type",
            "json"
          },
          {
            "Address",
            string.Join(" ", values)
          }
        });
        using (HttpResponseMessage response = await DistanceToWater.ServiceClient.SendAsync(distanceRequest).ConfigureAwait(false))
        {
          response.EnsureSuccessStatusCode();
          rawResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
          return JsonConvert.DeserializeObject<DistanceResult>(rawResponse);
        }
      }
    }
    catch (Exception ex)
    {
      return new DistanceResult()
      {
        Status = ex.Message,
        Error = ex,
        RawResponse = rawResponse
      };
    }
  }
}

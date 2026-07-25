// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.WebService
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge;

public class WebService
{
  public XNamespace NameSpace { get; set; }

  public string BaseUrl { get; set; } = string.Empty;

  public string Url { get; set; } = string.Empty;

  public string MethodName { get; set; } = string.Empty;

  public string UserAgent { get; set; } = string.Empty;

  public string Email { get; set; } = string.Empty;

  public string Password { get; set; } = string.Empty;

  public string Token { get; set; } = string.Empty;

  public string ContentType { get; set; } = string.Empty;

  public string Payload { get; set; } = string.Empty;

  public HttpResponseMessage LastResponse { get; private set; }

  public string ExceptionMessage { get; set; }

  public WebService()
  {
  }

  public WebService(string url, string methodName, XNamespace ns)
  {
    this.Url = url;
    this.MethodName = methodName;
    this.NameSpace = ns;
  }

  public async Task<string> InvokeAsync()
  {
    try
    {
      using (HttpClient client = new HttpClient())
      {
        if (this.BaseUrl.Length > 0)
          client.BaseAddress = new Uri(this.BaseUrl);
        if (this.ContentType.Length > 0)
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(this.ContentType));
        HttpRequestMessage request = new HttpRequestMessage(this.GetHttpMethod(), this.Url);
        if (this.UserAgent.Length > 0)
        {
          ProductInfoHeaderValue productInfoHeaderValue = new ProductInfoHeaderValue(this.UserAgent, "1.0");
          request.Headers.UserAgent.Add(productInfoHeaderValue);
        }
        if (this.Email.Length > 0)
          client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(new UTF8Encoding().GetBytes($"{this.Email}:{this.Password}")));
        if (this.Token.Length > 0)
          request.Headers.Add("Authorization", "Bearer " + this.Token);
        if (this.Payload.Length > 0)
        {
          request.Content = (HttpContent) new StringContent(this.Payload, Encoding.UTF8, this.ContentType);
          request.Content.Headers.ContentType = new MediaTypeHeaderValue(this.ContentType);
        }
        this.LastResponse = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, CancellationToken.None).ConfigureAwait(false);
        if (this.LastResponse.IsSuccessStatusCode)
          return this.LastResponse.Content.ReadAsStringAsync().Result;
        if (this.LastResponse.StatusCode == HttpStatusCode.BadRequest)
          return this.LastResponse.Content.ReadAsStringAsync().Result;
      }
    }
    catch (Exception ex)
    {
      this.ExceptionMessage = ex.ToString();
    }
    return (string) null;
  }

  private HttpMethod GetHttpMethod()
  {
    HttpMethod httpMethod = HttpMethod.Get;
    switch (this.MethodName.ToUpper())
    {
      case "POST":
        httpMethod = HttpMethod.Post;
        break;
      case "PATCH":
        httpMethod = new HttpMethod("PATCH");
        break;
    }
    return httpMethod;
  }
}

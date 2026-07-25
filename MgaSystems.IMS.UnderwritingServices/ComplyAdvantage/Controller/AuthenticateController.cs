// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller.AuthenticateController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;
using MgaSystems.IMS.UnderwritingServices.Extensions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller;

public class AuthenticateController : 
  RestServiceBase<AuthenticateController>,
  IAuthenticateService<Token>,
  IAuthenticateRequest
{
  private string Username { get; }

  private string Password { get; }

  private string Realm { get; }

  internal static Token AuthToken { get; set; }

  public AuthenticateController(
    string applicationUri,
    string username,
    string password,
    string realm,
    IProgress<string> logAction = null,
    IProgress<Exception> errorHandlingAction = null)
    : base(applicationUri, logAction, errorHandlingAction)
  {
    username.ThrowIfNullOrWhitespace(nameof (username));
    password.ThrowIfNullOrWhitespace(nameof (password));
    realm.ThrowIfNullOrWhitespace(nameof (realm));
    string str1 = username;
    string str2 = password;
    string str3 = realm;
    this.Username = str1;
    this.Password = str2;
    this.Realm = str3;
  }

  public Token Authenticate()
  {
    return this.AuthenticateAsync(CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
  }

  public async Task<Token> AuthenticateAsync(CancellationToken cancellationToken)
  {
    Token authToken = AuthenticateController.AuthToken;
    if ((authToken != null ? (authToken.Initialized ? 1 : 0) : 1) != 0)
    {
      this.LogProgress?.Report("The current authorization token has not been properly initialized.");
    }
    else
    {
      DateTime now = DateTime.Now;
      DateTime? expiry = AuthenticateController.AuthToken?.Expiry;
      if ((expiry.HasValue ? (now < expiry.GetValueOrDefault() ? 1 : 0) : 0) != 0)
      {
        this.LogProgress?.Report("Token has not expired. Continuing with active token...");
        return AuthenticateController.AuthToken;
      }
    }
    this.LogProgress?.Report("Executing authentication service for new token...");
    string jsonResponse = (string) null;
    Token token;
    try
    {
      RestServiceBase<AuthenticateController>.ServiceClient.DefaultRequestHeaders.Clear();
      RestServiceBase<AuthenticateController>.ServiceClient.DefaultRequestHeaders.ConnectionClose = new bool?(true);
      using (HttpRequestMessage authRequest = new HttpRequestMessage(HttpMethod.Post, this.BaseUri))
      {
        authRequest.Content = (HttpContent) new StringContent(JsonConvert.SerializeObject((object) new TokenRequest(this.Username, this.Password, this.Realm)), Encoding.UTF8, "application/json");
        cancellationToken.ThrowIfCancellationRequested();
        using (HttpResponseMessage response = await RestServiceBase<AuthenticateController>.ServiceClient.SendAsync(authRequest).ConfigureAwait(false))
        {
          jsonResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
          response.EnsureSuccessStatusCode();
          token = JsonConvert.DeserializeObject<Token>(jsonResponse);
          token.Initialized = true;
          token.Expiry = DateTime.Now.AddSeconds((double) token.ExpiresIn);
        }
      }
    }
    catch (HttpRequestException ex)
    {
      this.LogProgress?.Report("Authorization service returned a non-success status code. " + ex.Message);
      ex.Data.Add((object) "RawResponse", (object) jsonResponse);
      this.ErrorProgress?.Report((Exception) ex);
      token = new Token();
    }
    catch (TaskCanceledException ex)
    {
      this.LogProgress?.Report("Cancellation requested. Aborting authentication attempt.");
      this.ErrorProgress?.Report((Exception) ex);
      token = new Token();
    }
    catch (Exception ex)
    {
      this.LogProgress?.Report("Error occurred executing authenticate service. " + ex.Message);
      this.ErrorProgress?.Report(ex);
      token = new Token();
    }
    return AuthenticateController.AuthToken = token;
  }

  public void AuthenticateRequest(HttpRequestMessage httpRequest)
  {
    Token token = this.Authenticate();
    httpRequest.Headers.Authorization = AuthenticationHeaderValue.Parse($"{token.TokenType} {token.AccessToken}");
  }

  public async Task AuthenticateRequestAsync(
    HttpRequestMessage httpRequest,
    CancellationToken cancellationToken)
  {
    Token token = await this.AuthenticateAsync(cancellationToken);
    httpRequest.Headers.Authorization = AuthenticationHeaderValue.Parse($"{token.TokenType} {token.AccessToken}");
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.AuthenticatingServiceBase`1
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public abstract class AuthenticatingServiceBase<TIn> : RestServiceBase<TIn> where TIn : AuthenticatingServiceBase<TIn>
{
  protected IAuthenticateRequest AuthenticationService { get; private set; }

  public TIn SetAuthenticationService(IAuthenticateRequest authService)
  {
    this.AuthenticationService = authService;
    return (TIn) this;
  }

  protected override async Task AuthenticateRequest(
    HttpRequestMessage message,
    CancellationToken cancellationToken = default (CancellationToken))
  {
    await this.AuthenticationService.AuthenticateRequestAsync(message, cancellationToken).ConfigureAwait(false);
  }

  protected AuthenticatingServiceBase(
    string applicationUri,
    IAuthenticateRequest authenticatingService = null,
    IProgress<string> logAction = null,
    IProgress<Exception> errorHandlingAction = null)
    : base(applicationUri, logAction, errorHandlingAction)
  {
    this.AuthenticationService = authenticatingService;
  }
}

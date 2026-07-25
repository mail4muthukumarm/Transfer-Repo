// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.AuthenticatingServiceBase`2
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public abstract class AuthenticatingServiceBase<TIn, TAuth> : RestServiceBase<TIn> where TIn : AuthenticatingServiceBase<TIn, TAuth>
{
  protected IAuthenticateService<TAuth> AuthenticationService { get; private set; }

  public TIn SetAuthenticationService(IAuthenticateService<TAuth> authService)
  {
    this.AuthenticationService = authService;
    return (TIn) this;
  }

  protected AuthenticatingServiceBase(
    string applicationUri,
    IAuthenticateService<TAuth> authenticatingService = null,
    IProgress<string> logAction = null,
    IProgress<Exception> errorHandlingAction = null)
    : base(applicationUri, logAction, errorHandlingAction)
  {
    this.AuthenticationService = authenticatingService;
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller.MeshScreeningController
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;
using System;
using System.Net.Http;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.Controller;

public class MeshScreeningController(
  string applicationUri,
  IAuthenticateService<Token> authenticateService,
  IProgress<string> logAction = null,
  IProgress<Exception> errorHandlingAction = null) : 
  AuthenticatingServiceBase<MeshScreeningController, Token>(UrlExtensions.AppendUrlParts(applicationUri, "v2/workflows"), authenticateService, logAction, errorHandlingAction)
{
  public async Task<ScreenResponse> CreateAndScreen(CreateAndScreenRequest request)
  {
    return await this.Call<CreateAndScreenRequest, ScreenResponse>(request, HttpMethod.Post, this.ApplicationUri.AppendUrlParts("sync/create-and-screen"), false, operation: nameof (CreateAndScreen)).ConfigureAwait(false);
  }

  public async Task<ScreenAsyncResponse> CreateAndScreenAsync(CreateAndScreenRequest request)
  {
    return await this.Call<CreateAndScreenRequest, ScreenAsyncResponse>(request, HttpMethod.Post, this.ApplicationUri.AppendUrlParts("create-and-screen"), false, operation: nameof (CreateAndScreenAsync)).ConfigureAwait(false);
  }

  public async Task<ScreenResponse> GetScreeningStatus(ScreenAsyncResponse request)
  {
    return await this.Get<ScreenResponse>(this.ApplicationUri.AppendUrlParts(request.WorkflowInstanceIdentifier), false, operation: nameof (GetScreeningStatus)).ConfigureAwait(false);
  }

  public async Task<ScreenResponse> GetScreeningStatus(string workflowIdentifier)
  {
    return await this.Get<ScreenResponse>(this.ApplicationUri.AppendUrlParts(workflowIdentifier), false, operation: nameof (GetScreeningStatus)).ConfigureAwait(false);
  }

  public async Task<ScreenResponse> CreateAndScreenPerson(
    Guid searchConfiguration,
    string entityIdentifier,
    string firstName,
    string lastName,
    string middleName = null,
    DateTime? dateOfBirth = null,
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    return await this.CreateAndScreen(new CreateAndScreenRequest(searchConfiguration, entityIdentifier, firstName, lastName, middleName, dateOfBirth, address1, address2, city, country, postal, addressType)).ConfigureAwait(false);
  }

  public async Task<ScreenAsyncResponse> CreateAndScreenPersonAsync(
    Guid searchConfiguration,
    string entityIdentifier,
    string firstName,
    string lastName,
    string middleName = null,
    DateTime? dateOfBirth = null,
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    return await this.CreateAndScreenAsync(new CreateAndScreenRequest(searchConfiguration, entityIdentifier, firstName, lastName, middleName, dateOfBirth, address1, address2, city, country, postal, addressType)).ConfigureAwait(false);
  }

  public async Task<ScreenResponse> CreateAndScreenCompany(
    Guid searchConfiguration,
    string entityIdentifier,
    string legalName,
    string[] aliases = null,
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    return await this.CreateAndScreen(new CreateAndScreenRequest(searchConfiguration, entityIdentifier, legalName, aliases, address1, address2, city, country, postal, addressType)).ConfigureAwait(false);
  }

  public async Task<ScreenAsyncResponse> CreateAndScreenCompanyAsync(
    Guid searchConfiguration,
    string entityIdentifier,
    string legalName,
    string[] aliases = null,
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    return await this.CreateAndScreenAsync(new CreateAndScreenRequest(searchConfiguration, entityIdentifier, legalName, aliases, address1, address2, city, country, postal, addressType)).ConfigureAwait(false);
  }
}

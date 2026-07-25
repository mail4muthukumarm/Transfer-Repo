// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.IAuthenticateRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public interface IAuthenticateRequest
{
  void AuthenticateRequest(HttpRequestMessage httpRequest);

  Task AuthenticateRequestAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken);
}

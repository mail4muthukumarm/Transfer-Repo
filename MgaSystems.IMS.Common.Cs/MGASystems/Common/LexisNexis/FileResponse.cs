// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.FileResponse
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v11.0.0.0))")]
public class FileResponse : IDisposable
{
  private IDisposable _client;
  private IDisposable _response;

  public int StatusCode { get; private set; }

  public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

  public Stream Stream { get; private set; }

  public bool IsPartial => this.StatusCode == 206;

  public FileResponse(
    int statusCode,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    Stream stream,
    IDisposable client,
    IDisposable response)
  {
    this.StatusCode = statusCode;
    this.Headers = headers;
    this.Stream = stream;
    this._client = client;
    this._response = response;
  }

  public void Dispose()
  {
    this.Stream.Dispose();
    if (this._response != null)
      this._response.Dispose();
    if (this._client == null)
      return;
    this._client.Dispose();
  }
}

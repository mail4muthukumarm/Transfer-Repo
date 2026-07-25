// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ApiException
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v11.0.0.0))")]
public class ApiException : Exception
{
  public int StatusCode { get; private set; }

  public string Response { get; private set; }

  public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

  public ApiException(
    string message,
    int statusCode,
    string response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    Exception innerException)
    : base($"{message}\n\nStatus: {statusCode.ToString()}\nResponse: \n{(response == null ? "(null)" : response.Substring(0, response.Length >= 512 /*0x0200*/ ? 512 /*0x0200*/ : response.Length))}", innerException)
  {
    this.StatusCode = statusCode;
    this.Response = response;
    this.Headers = headers;
  }

  public override string ToString() => $"HTTP Response: \n\n{this.Response}\n\n{base.ToString()}";
}

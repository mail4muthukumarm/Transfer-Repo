// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.ApiException`1
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v11.0.0.0))")]
public class ApiException<TResult> : ApiException
{
  public TResult Result { get; private set; }

  public ApiException(
    string message,
    int statusCode,
    string response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    TResult result,
    Exception innerException)
    : base(message, statusCode, response, headers, innerException)
  {
    this.Result = result;
  }
}

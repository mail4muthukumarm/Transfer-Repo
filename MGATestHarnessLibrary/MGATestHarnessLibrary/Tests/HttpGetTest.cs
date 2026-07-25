// Decompiled with JetBrains decompiler
// Type: MGATestHarnessLibrary.Tests.HttpGetTest
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using MGASystems.MGATestHarness.MGATestHarnessLibrary;
using System;
using System.Collections.Generic;
using System.Net.Http;

#nullable enable
namespace MGATestHarnessLibrary.Tests;

public class HttpGetTest : ITestable
{
  private static readonly HttpClient httpClient = new HttpClient();
  private readonly Uri _uri;
  private TestResult result;
  private readonly ICollection<string> explanation = (ICollection<string>) new List<string>();

  public HttpGetTest(string url)
    : this(new Uri(url))
  {
  }

  public HttpGetTest(Uri uri) => this._uri = uri;

  public void RunTest()
  {
    try
    {
      this.explanation.Clear();
      HttpResponseMessage result = HttpGetTest.httpClient.GetAsync(this._uri).Result;
      this.result = result.IsSuccessStatusCode ? TestResult.Success : TestResult.Failure;
      this.explanation.Add(result.StatusCode.ToString());
    }
    catch (Exception ex)
    {
      this.result = TestResult.Failure;
      this.explanation.Add(ex.Message);
    }
  }

  public TestResult GetTestResult() => this.result;

  public IEnumerable<string> GetResultExplanation() => (IEnumerable<string>) this.explanation;

  public string GetDisplayName() => $"{this.GetType().Name} {this._uri}";
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests.DnsResolutionTest
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System;
using System.Collections.Generic;
using System.Net;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests;

public class DnsResolutionTest : ITestable
{
  private readonly string _hostName;
  private readonly IList<string> explanation = (IList<string>) new List<string>();
  private TestResult result;

  public DnsResolutionTest(string hostName) => this._hostName = hostName;

  public void RunTest()
  {
    try
    {
      this.explanation.Clear();
      IPHostEntry hostEntry = Dns.GetHostEntry(this._hostName);
      this.result = TestResult.Success;
      this.explanation.Add("HostName: " + hostEntry.HostName);
      foreach (object address in hostEntry.AddressList)
        this.explanation.Add($"AddressList: {address}");
    }
    catch (Exception ex)
    {
      this.explanation.Add(ex.Message);
      this.result = TestResult.Failure;
    }
  }

  public TestResult GetTestResult() => this.result;

  public IEnumerable<string> GetResultExplanation() => (IEnumerable<string>) this.explanation;

  public string GetDisplayName() => $"{this.GetType().Name} {this._hostName}";
}

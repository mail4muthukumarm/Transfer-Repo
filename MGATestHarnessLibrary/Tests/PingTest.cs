// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests.PingTest
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System;
using System.Collections.Generic;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests;

public class PingTest : ITestable
{
  private readonly string _hostname;
  private TestResult _tr;
  private IEnumerable<string> output = (IEnumerable<string>) Array.Empty<string>();

  public PingTest(string hostname) => this._hostname = hostname;

  public TestResult GetTestResult() => this._tr;

  public IEnumerable<string> GetResultExplanation() => this.output;

  public void RunTest() => (this._tr, this.output) = CommandLine.Execute("ping", this._hostname);

  public string GetDisplayName() => this.GetType().Name ?? "";
}

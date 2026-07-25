// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests.EnvironmentSettingsTest
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System;
using System.Collections.Generic;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests;

internal class EnvironmentSettingsTest : ITestable
{
  private TestResult _tr;
  private IEnumerable<string> _output = (IEnumerable<string>) new string[0];

  public string GetDisplayName() => this.GetType().Name ?? "";

  public IEnumerable<string> GetResultExplanation() => this._output;

  public TestResult GetTestResult() => this._tr;

  public void RunTest()
  {
    this._output = (IEnumerable<string>) new string[8]
    {
      "Current Directory = " + Environment.CurrentDirectory,
      "Machine Name      = " + Environment.MachineName,
      $"OS Version        = {Environment.OSVersion}",
      $"Is 64-bit OS      = {Environment.Is64BitOperatingSystem}",
      $"Processor Count   = {Environment.ProcessorCount}",
      $"Version           = {Environment.Version}",
      "User Name         = " + Environment.UserName,
      "User Domain Name  = " + Environment.UserDomainName
    };
    this._tr = TestResult.Success;
  }
}

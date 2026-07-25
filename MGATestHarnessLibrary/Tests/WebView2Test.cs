// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests.WebView2Test
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests;

public class WebView2Test : ITestable
{
  private TestResult _tr;
  private ICollection<string> _output = (ICollection<string>) new List<string>();

  public string GetDisplayName() => this.GetType().Name ?? "";

  public IEnumerable<string> GetResultExplanation() => (IEnumerable<string>) this._output;

  public TestResult GetTestResult() => this._tr;

  public void RunTest()
  {
    try
    {
      this._output = (ICollection<string>) new string[1]
      {
        "WebView2 version  = " + CoreWebView2Environment.GetAvailableBrowserVersionString((string) null)
      };
      this._tr = TestResult.Success;
    }
    catch (Exception ex)
    {
      this._tr = TestResult.Failure;
      this._output = (ICollection<string>) new string[1]
      {
        ex.Message
      };
    }
  }
}

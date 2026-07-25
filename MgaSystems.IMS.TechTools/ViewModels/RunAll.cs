// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.ViewModels.RunAll
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.MGATestHarness.MGATestHarnessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.TechTools.ViewModels;

public class RunAll : ITestable
{
  private readonly ICollection<ITestable> tests;

  public RunAll(ICollection<ITestable> tests) => this.tests = tests;

  public string GetDisplayName() => "Run All";

  public IEnumerable<string> GetResultExplanation()
  {
    foreach (ITestable test in (IEnumerable<ITestable>) this.tests)
    {
      yield return $"\n{test.GetDisplayName()}{" : "}{test.GetTestResult()}";
      yield return "\t" + string.Join("\n\t", test.GetResultExplanation().ToArray<string>());
    }
  }

  public TestResult GetTestResult()
  {
    return this.tests.Max<ITestable, TestResult>((Func<ITestable, TestResult>) (t => t.GetTestResult()));
  }

  public void RunTest()
  {
    foreach (ITestable test in (IEnumerable<ITestable>) this.tests)
      test.RunTest();
  }
}

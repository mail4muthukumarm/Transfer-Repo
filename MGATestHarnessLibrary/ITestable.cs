// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.ITestable
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System.Collections.Generic;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary;

public interface ITestable
{
  void RunTest();

  TestResult GetTestResult();

  IEnumerable<string> GetResultExplanation();

  string GetDisplayName();
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.ReadTextFile
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System.Collections.Generic;
using System.IO;
using System.Linq;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary;

internal class ReadTextFile
{
  public static (TestResult, string[]) Execute(string fileName)
  {
    string[] source = new string[0];
    TestResult testResult;
    if (File.Exists(fileName))
    {
      source = File.ReadAllLines(fileName);
      testResult = TestResult.Success;
    }
    else
    {
      testResult = TestResult.Failure;
      ((IEnumerable<string>) source).Append<string>(fileName + " does not exist.");
    }
    return (testResult, source);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.CommandLine
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary;

internal class CommandLine
{
  public static (TestResult, IEnumerable<string>) Execute(string cmd, string arguments)
  {
    List<string> output = new List<string>();
    TestResult testResult1 = TestResult.Unknown;
    Process process = new Process()
    {
      StartInfo = new ProcessStartInfo()
      {
        FileName = cmd,
        Arguments = arguments,
        UseShellExecute = false,
        RedirectStandardError = true,
        RedirectStandardOutput = true,
        CreateNoWindow = true,
        WindowStyle = ProcessWindowStyle.Hidden
      }
    };
    process.OutputDataReceived += (DataReceivedEventHandler) ((sender, e) => output.Add(e.Data));
    string str = string.Empty;
    try
    {
      process.Start();
      process.BeginOutputReadLine();
      str = process.StandardError.ReadToEnd();
      process.WaitForExit();
    }
    catch (Exception ex)
    {
      testResult1 = TestResult.Failure;
      output.Add($"OS error while executing ping www.google.com with exception {ex.Message}{Environment.NewLine}");
    }
    TestResult testResult2;
    if (process.ExitCode == 0)
    {
      testResult2 = TestResult.Success;
    }
    else
    {
      testResult2 = TestResult.Failure;
      if (!string.IsNullOrEmpty(str))
      {
        testResult2 = TestResult.PartialSuccessFailure;
        output.Add(str + Environment.NewLine);
      }
    }
    return (testResult2, (IEnumerable<string>) output);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests.AsposeTest
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests;

public class AsposeTest : ITestable
{
  private TestResult _tr;
  private ICollection<string> _output = (ICollection<string>) new List<string>();
  private readonly string _testFolderName;
  private const string cellsV1 = "8.8.2.0";
  private const string cellsV3 = "8.8.2.0";
  private const string cellsV4 = "19.4.0.0";
  private const string emailV1 = "6.6.0.0";
  private const string emailV3 = "6.6.0.0";
  private const string emailV4 = "19.3.0.0";
  private const string pdfV1 = "3.7.0.0";
  private const string pdfV3 = "11.7.0.0";
  private const string pdfV4 = "19.4.0.0";
  private const string wordsV1 = "5.2.1.0";
  private const string wordsV3 = "16.4.0.0";
  private const string wordsV4 = "19.4.0.0";

  public AsposeTest(string testFolderName) => this._testFolderName = testFolderName;

  public string GetDisplayName() => $"{this.GetType().Name} {this._testFolderName}";

  public IEnumerable<string> GetResultExplanation() => (IEnumerable<string>) this._output;

  public TestResult GetTestResult() => this._tr;

  public void RunTest()
  {
    try
    {
      this._output.Clear();
      IEnumerable<AssemblyName> source = ((IEnumerable<string>) Directory.GetFiles(this._testFolderName, "*aspose*.dll")).Select<string, AssemblyName>((Func<string, AssemblyName>) (s => AssemblyName.GetAssemblyName(s)));
      if (source.Any<AssemblyName>())
      {
        string str1 = source.First<AssemblyName>((Func<AssemblyName, bool>) (an => an.Name.Equals("Aspose.Cells", StringComparison.CurrentCultureIgnoreCase))).Version.ToString();
        string str2 = source.First<AssemblyName>((Func<AssemblyName, bool>) (an => an.Name.Equals("Aspose.Email", StringComparison.CurrentCultureIgnoreCase))).Version.ToString();
        string str3 = source.First<AssemblyName>((Func<AssemblyName, bool>) (an => an.Name.Equals("Aspose.Pdf", StringComparison.CurrentCultureIgnoreCase))).Version.ToString();
        string str4 = source.First<AssemblyName>((Func<AssemblyName, bool>) (an => an.Name.Equals("Aspose.Words", StringComparison.CurrentCultureIgnoreCase))).Version.ToString();
        if ("8.8.2.0" == str1 && "6.6.0.0" == str2 && "3.7.0.0" == str3 && "5.2.1.0" == str4)
          this._output.Add("AsposeFacade: V1");
        else if ("8.8.2.0" == str1 && "6.6.0.0" == str2 && "11.7.0.0" == str3 && "16.4.0.0" == str4)
          this._output.Add("AsposeFacade: V3");
        else if ("19.4.0.0" == str1 && "19.3.0.0" == str2 && "19.4.0.0" == str3 && "19.4.0.0" == str4)
          this._output.Add("AsposeFacade: V4");
        foreach (AssemblyName assemblyName in source)
          this._output.Add($"{assemblyName.Name} {assemblyName.Version}");
        this._tr = TestResult.Success;
      }
      else
      {
        this._tr = TestResult.Failure;
        this._output.Add("No Aspose dlls found");
      }
    }
    catch (Exception ex)
    {
      this._output.Add("Exception thrown for file " + ex.Message);
      this._tr = TestResult.Failure;
    }
  }
}

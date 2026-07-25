// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests.MSOfficeTest
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary.Tests;

public class MSOfficeTest : ITestable
{
  private TestResult _tr;
  private ICollection<string> _output = (ICollection<string>) new List<string>();

  public string GetDisplayName() => this.GetType().Name ?? "";

  public IEnumerable<string> GetResultExplanation() => (IEnumerable<string>) this._output;

  public TestResult GetTestResult() => this._tr;

  public void RunTest()
  {
    this._output.Clear();
    this._tr = TestResult.Failure;
    int version = 7;
    if (this.KeyExists(version))
      this._output.Add("Office 97");
    int num1;
    if (this.KeyExists(num1 = version + 1))
      this._output.Add("Office 98");
    int num2;
    if (this.KeyExists(num2 = num1 + 1))
      this._output.Add("Office 2000");
    int num3;
    if (this.KeyExists(num3 = num2 + 1))
      this._output.Add("Office XP");
    int num4;
    if (this.KeyExists(num4 = num3 + 1))
      this._output.Add("Office 2003");
    int num5;
    if (this.KeyExists(num5 = num4 + 1))
      this._output.Add("Office 2007");
    int num6;
    if (this.KeyExists(num6 = num5 + 1 + 1))
      this._output.Add("Office 2010");
    int num7;
    if (this.KeyExists(num7 = num6 + 1))
      this._output.Add("Office 2013");
    using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
    {
      using (RegistryKey registryKey2 = registryKey1.OpenSubKey("Software\\Microsoft\\Office\\16.0\\Common\\Licensing"))
      {
        if (!((IEnumerable<string>) registryKey2.GetValueNames()).Any<string>())
          this._output.Add("Office 2016");
        using (RegistryKey registryKey3 = registryKey2.OpenSubKey("LicensingNext"))
        {
          string[] valueNames = registryKey3.GetValueNames();
          if (((IEnumerable<string>) valueNames).Any<string>((Func<string, bool>) (name => name.Contains("2019"))))
            this._output.Add("Office 2019");
          if (((IEnumerable<string>) valueNames).Any<string>((Func<string, bool>) (name => name.Contains("365"))))
            this._output.Add("Office 365");
        }
      }
    }
    this._tr = TestResult.Success;
  }

  private bool KeyExists(int version)
  {
    string empty = string.Empty;
    try
    {
      using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
      {
        using (RegistryKey registryKey2 = registryKey1.OpenSubKey($"SOFTWARE\\Microsoft\\Office\\{version}.0\\Word\\InstallRoot", false))
        {
          if (registryKey2 != null)
            empty = registryKey2.GetValue("Path").ToString();
        }
      }
    }
    catch (Exception ex)
    {
      this._output.Add($"Failed in KeyExists for version {version} {ex.Message}");
    }
    return empty.Length > 0;
  }
}

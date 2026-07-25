// Decompiled with JetBrains decompiler
// Type: MGASystems.MGATestHarness.MGATestHarnessLibrary.TestRunner
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

#nullable enable
namespace MGASystems.MGATestHarness.MGATestHarnessLibrary;

public class TestRunner
{
  private const string _assemblyNameSpace = "MGASystems.MGATestHarness";
  private const string _assemblyLocation = "MGASystems.MGATestHarness.Tests.";
  private readonly Dictionary<string, ICollection<string>> _parameters;

  public TestRunner()
  {
    this._parameters = new Dictionary<string, ICollection<string>>()
    {
      {
        "hostname",
        (ICollection<string>) new List<string>()
        {
          "google.com",
          "mgasystems.com"
        }
      }
    };
  }

  public TestRunner(Dictionary<string, ICollection<string>> parameters)
  {
    this._parameters = parameters;
  }

  public IEnumerable<ITestable> GetAllTestables()
  {
    Type myType = typeof (ITestable);
    IEnumerable<Type> withParameterCount1 = TestRunner.GetAssembliesWithParameterCount(myType, 0);
    IEnumerable<Type> withParameterCount2 = TestRunner.GetAssembliesWithParameterCount(myType, 1);
    List<ITestable> allTestables = new List<ITestable>();
    foreach (Type type in withParameterCount1)
    {
      try
      {
        if (type != (Type) null)
        {
          ITestable instance = (ITestable) Activator.CreateInstance(type);
          allTestables.Add(instance);
        }
      }
      catch (Exception ex)
      {
      }
    }
    foreach (Type type in withParameterCount2)
    {
      try
      {
        if (type != (Type) null)
        {
          foreach (string str in (IEnumerable<string>) this.GetParametersForType(type))
          {
            ITestable instance = (ITestable) Activator.CreateInstance(type, (object) str);
            allTestables.Add(instance);
          }
        }
      }
      catch (Exception ex)
      {
      }
    }
    return (IEnumerable<ITestable>) allTestables;
  }

  public IEnumerable<ITestable> GetNamedTests(IEnumerable<string> testNames)
  {
    List<ITestable> namedTests = new List<ITestable>();
    try
    {
      foreach (string testName in testNames)
      {
        if (!string.IsNullOrEmpty(testName))
        {
          (string method, string parameter) = TestRunner.ParseTestName(testName);
          if (parameter.Length == 0)
            namedTests.Add((ITestable) Activator.CreateInstance("MGASystems.MGATestHarness", "MGASystems.MGATestHarness.Tests." + testName).Unwrap());
          else
            namedTests.Add((ITestable) Activator.CreateInstance(Type.GetType("MGASystems.MGATestHarness.Tests." + method), (object) parameter));
        }
      }
    }
    catch (Exception ex)
    {
    }
    return (IEnumerable<ITestable>) namedTests;
  }

  private static (string method, string parameter) ParseTestName(string testName)
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    if (!string.IsNullOrEmpty(testName))
    {
      int length = testName.IndexOf('(');
      int num = testName.LastIndexOf(')');
      if (length != -1 && num != -1)
      {
        str1 = testName.Substring(0, length);
        str2 = testName.Substring(length + 1, num - length - 1);
      }
    }
    return (str1, str2);
  }

  private ICollection<string> GetParametersForType(Type type)
  {
    List<string> parametersForType = new List<string>();
    switch (type.Name)
    {
      case "DnsResolutionTest":
      case "PingTest":
        if (this._parameters.ContainsKey("hostname"))
          return this._parameters["hostname"];
        break;
      case "AsposeTest":
        if (this._parameters.ContainsKey("ims.exe.config"))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          return (ICollection<string>) this._parameters["ims.exe.config"].Select<string, string>(TestRunner.\u003C\u003EO.\u003C0\u003E__GetDirectoryName ?? (TestRunner.\u003C\u003EO.\u003C0\u003E__GetDirectoryName = new Func<string, string>(Path.GetDirectoryName))).ToList<string>();
        }
        break;
      case "HttpGetTest":
        if (this._parameters.ContainsKey("url"))
          return this._parameters["url"];
        break;
    }
    return (ICollection<string>) parametersForType;
  }

  private static IEnumerable<Type> GetAssembliesWithParameterCount(Type myType, int count)
  {
    return ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).SelectMany<Assembly, Type>((Func<Assembly, IEnumerable<Type>>) (x => (IEnumerable<Type>) x.GetTypes())).Where<Type>((Func<Type, bool>) (p => myType.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract && ((IEnumerable<ConstructorInfo>) p.GetConstructors()).Any<ConstructorInfo>((Func<ConstructorInfo, bool>) (z => ((IEnumerable<ParameterInfo>) z.GetParameters()).Count<ParameterInfo>() == count))));
  }
}

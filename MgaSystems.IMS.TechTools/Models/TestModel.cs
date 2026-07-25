// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.TestModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.MGATestHarness.MGATestHarnessLibrary;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

public class TestModel
{
  public string TestName { get; set; }

  public ITestable Test { get; set; }

  public TestModel(string testName, ITestable test)
  {
    this.TestName = testName;
    this.Test = test;
  }

  public TestModel()
  {
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.ReportModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using System;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

public class ReportModel
{
  public string TestName { get; set; }

  public Type TypeOfReport { get; set; }

  public ReportModel(string testName, Type test)
  {
    this.TestName = testName;
    this.TypeOfReport = test;
  }

  public ReportModel()
  {
  }
}

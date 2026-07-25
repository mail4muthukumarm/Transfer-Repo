// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Data.ScheduleChooser.ScheduleInfo
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data.Binding;
using System;

#nullable disable
namespace MgaSystems.IMS.Excel.Data.ScheduleChooser;

public class ScheduleInfo : BindingObject
{
  public Guid FactorSetGuid { get; set; }

  public string Title { get; set; }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.BindingDisplayOptions
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

internal class BindingDisplayOptions : Attribute
{
  private BindingDisplayOptions.GridDisplayOption displayOptions;

  public BindingDisplayOptions(
    BindingDisplayOptions.GridDisplayOption DisplayOptions)
  {
    this.displayOptions = DisplayOptions;
  }

  public BindingDisplayOptions.GridDisplayOption DisplayOptions => this.displayOptions;

  [Flags]
  public enum GridDisplayOption
  {
    Hidden = 0,
    NotHidden = 1,
    Currency = NotHidden, // 0x00000001
  }
}

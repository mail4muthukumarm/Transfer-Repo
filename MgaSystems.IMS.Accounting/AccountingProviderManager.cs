// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingProviderManager
// Assembly: MgaSystems.IMS.Accounting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 118B765D-C703-4927-A662-CA3DF0A8B869
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting;

public class AccountingProviderManager
{
  private AccountingProviderManager()
  {
  }

  public static object CreateType(Type t) => Activator.CreateInstance(t, new object[0]);
}

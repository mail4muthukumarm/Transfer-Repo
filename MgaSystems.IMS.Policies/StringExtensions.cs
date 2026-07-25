// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.StringExtensions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.Policies;

[StandardModule]
public sealed class StringExtensions
{
  public static string RemoveAfterLastDash(this string input)
  {
    int length = input != null ? input.LastIndexOf('-') : throw new ArgumentNullException(nameof (input));
    return length < 0 ? input : input.Substring(0, length);
  }
}

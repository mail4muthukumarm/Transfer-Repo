// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.ProgressCalculationExtensions
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using System;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

public static class ProgressCalculationExtensions
{
  public static int PercentOf(this int numerator, int denominator)
  {
    return (int) Math.Max(Math.Min(100f, (float) (100.0 * ((double) numerator / (double) denominator))), 0.0f);
  }

  public static long PercentOf(this long numerator, long denominator)
  {
    return Math.Max(Math.Min(100L, 100L * numerator / denominator), 0L);
  }
}

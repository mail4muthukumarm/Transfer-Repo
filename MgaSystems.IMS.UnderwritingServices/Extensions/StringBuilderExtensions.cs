// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Extensions.StringBuilderExtensions
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.Text;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Extensions;

public static class StringBuilderExtensions
{
  public static StringBuilder AppendPad(
    this StringBuilder builder,
    string appendString,
    int padLength)
  {
    return builder.AppendPadWith(appendString, padLength);
  }

  public static StringBuilder AppendPadWith(
    this StringBuilder builder,
    string appendString,
    int padLength,
    char padChar = ' ')
  {
    return builder.Append((appendString ?? string.Empty).PadRight(padLength, padChar));
  }
}

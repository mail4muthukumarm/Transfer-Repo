// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FontResource
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.Common;

public sealed class FontResource
{
  private static Dictionary<string, PrivateFontCollection> _fontFamCollections = new Dictionary<string, PrivateFontCollection>();

  private FontResource()
  {
  }

  public static void Add(string fontResourceName, string fontAccessName, Assembly resourceAssembly)
  {
    if (FontResource._fontFamCollections.ContainsKey(fontAccessName))
      return;
    Stream manifestResourceStream = resourceAssembly.GetManifestResourceStream(fontResourceName);
    int num1 = manifestResourceStream != null ? (int) manifestResourceStream.Length : throw new InvalidOperationException($"Font not found in resources {fontResourceName}");
    IntPtr num2;
    try
    {
      num2 = Marshal.AllocCoTaskMem(num1);
      byte[] numArray = new byte[num1 - 1 + 1];
      manifestResourceStream.Read(numArray, 0, num1);
      Marshal.Copy(numArray, 0, num2, num1);
      PrivateFontCollection privateFontCollection = new PrivateFontCollection();
      privateFontCollection.AddMemoryFont(num2, num1);
      FontResource._fontFamCollections.Add(fontAccessName, privateFontCollection);
      manifestResourceStream.Close();
    }
    finally
    {
      if (!num2.Equals((object) IntPtr.Zero))
        Marshal.FreeCoTaskMem(num2);
    }
  }

  public static Font CreateFont(string fontAccessName, int size)
  {
    return FontResource.CreateFont(fontAccessName, size, FontStyle.Regular);
  }

  public static Font CreateFont(string fontAccessName, int size, FontStyle style)
  {
    return !FontResource._fontFamCollections.ContainsKey(fontAccessName) ? (Font) null : new Font(FontResource._fontFamCollections[fontAccessName].Families[0], (float) size, style);
  }
}

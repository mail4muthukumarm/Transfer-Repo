// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.IO
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class IO
{
  public static string StripInvalidPathChars(string path)
  {
    if (path == null)
      throw new ArgumentNullException(nameof (path));
    for (int index1 = path.Length - 1; index1 >= 0; index1 += -1)
    {
      char ch1 = path[index1];
      char[] invalidPathChars = Path.GetInvalidPathChars();
      int index2 = 0;
      while (index2 < invalidPathChars.Length)
      {
        char ch2 = invalidPathChars[index2];
        if ((int) ch1 == (int) ch2)
          path = path.Remove(index1, 1);
        checked { ++index2; }
      }
    }
    return path;
  }
}

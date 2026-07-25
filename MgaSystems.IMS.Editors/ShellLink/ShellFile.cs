// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ShellLink.ShellFile
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using MGASystems.ExtendedEditors.ComTypes;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

#nullable disable
namespace MGASystems.ExtendedEditors.ShellLink;

public static class ShellFile
{
  public const int MaxPath = 260;

  public static string ResolveLink(string fileName)
  {
    if (string.IsNullOrEmpty(fileName))
      throw new ArgumentNullException(nameof (fileName));
    if (!ShellFile.IsLink(fileName))
      throw new ArgumentException("not a valid link file", nameof (fileName));
    IShellLinkW o1 = (IShellLinkW) null;
    try
    {
      o1 = new MGASystems.ExtendedEditors.ShellLink.ShellLink() as IShellLinkW;
      IPersistFile o2 = (IPersistFile) null;
      try
      {
        o2 = o1 as IPersistFile;
        o2.Load(fileName, 0);
        StringBuilder pszFile = new StringBuilder(260);
        o1.GetPath(pszFile, pszFile.Capacity, 0, STGM.STGM_DIRECT);
        string str = pszFile.ToString();
        return !string.IsNullOrEmpty(str) ? str : throw new InvalidOperationException("The link could not be resolved.");
      }
      finally
      {
        if (o2 != null)
          Marshal.FinalReleaseComObject((object) o2);
      }
    }
    finally
    {
      if (o1 != null)
        Marshal.FinalReleaseComObject((object) o1);
    }
  }

  public static bool IsLink(string fileName)
  {
    return !string.IsNullOrEmpty(fileName) ? fileName.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase) : throw new ArgumentNullException(nameof (fileName));
  }
}

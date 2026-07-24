// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.FolderAssist
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class FolderAssist
{
  public static string GetFolderPath(string folderName)
  {
    for (DirectoryInfo parent = Directory.GetParent(Application.StartupPath); parent.Parent != null; parent = parent.Parent)
    {
      DirectoryInfo[] directories = parent.GetDirectories();
      int index = 0;
      while (index < directories.Length)
      {
        DirectoryInfo directoryInfo = FolderAssist.CheckSubDirs(directories[index], folderName);
        if (directoryInfo != null)
          return directoryInfo.FullName;
        checked { ++index; }
      }
    }
    throw new InvalidOperationException("Could not locate the specified  directory");
  }

  private static DirectoryInfo CheckSubDirs(DirectoryInfo di, string folderName)
  {
    DirectoryInfo directoryInfo1;
    if (Operators.CompareString(di.Name, folderName, false) == 0)
    {
      directoryInfo1 = di;
    }
    else
    {
      DirectoryInfo[] directories = di.GetDirectories();
      int index = 0;
      while (index < directories.Length)
      {
        DirectoryInfo directoryInfo2 = FolderAssist.CheckSubDirs(directories[index], folderName);
        if (directoryInfo2 != null)
        {
          directoryInfo1 = directoryInfo2;
          goto label_8;
        }
        checked { ++index; }
      }
      directoryInfo1 = (DirectoryInfo) null;
    }
label_8:
    return directoryInfo1;
  }
}

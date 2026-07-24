// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MGATempFolder
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class MGATempFolder
{
  private const string MGA_TEMP_FOLDER = "MGA Temp";
  private static string _folderPath = string.Empty;

  public static string MGATempPath
  {
    get
    {
      if (!Directory.Exists(MGATempFolder.TempFolderPath))
        Directory.CreateDirectory(MGATempFolder.TempFolderPath);
      return MGATempFolder.TempFolderPath;
    }
  }

  public static string MGATempRandomFolderPath
  {
    get
    {
      string path = $"{MGATempFolder.TempFolderPath}{Guid.NewGuid().ToString()}\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      return path;
    }
  }

  public static string MGATempRandomWatchedFilesPath
  {
    get
    {
      string path = $"{MGATempFolder.TempFolderPath}Watched Files\\{Guid.NewGuid().ToString()}\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      return path;
    }
  }

  public static string CreateTempSubdirectory()
  {
    string path = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}{1}\\", (object) MGATempFolder.MGATempPath, (object) Guid.NewGuid().ToString());
    Directory.CreateDirectory(path);
    return path;
  }

  private static string TempFolderPath
  {
    get
    {
      if (Operators.CompareString(MGATempFolder._folderPath, string.Empty, false) == 0)
        MGATempFolder._folderPath = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}{1}\\", (object) Path.GetTempPath(), (object) "MGA Temp");
      return MGATempFolder._folderPath;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public static void Delete()
  {
    MGATempFolder.DeleteFolderAndContents(MGATempFolder.TempFolderPath);
  }

  private static void DeleteFolderAndContents(string folderPath)
  {
    if (!Directory.Exists(folderPath))
      return;
    string[] files;
    try
    {
      files = Directory.GetFiles(folderPath);
    }
    catch (UnauthorizedAccessException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    string[] strArray = files;
    int index1 = 0;
    while (index1 < strArray.Length)
    {
      string path = strArray[index1];
      try
      {
        File.Delete(path);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      checked { ++index1; }
    }
    string[] directories = Directory.GetDirectories(folderPath);
    int index2 = 0;
    while (index2 < directories.Length)
    {
      MGATempFolder.DeleteFolderAndContents(directories[index2]);
      checked { ++index2; }
    }
    if (Directory.GetFiles(folderPath).Length != 0)
      return;
    if (Directory.GetDirectories(folderPath).Length != 0)
      return;
    try
    {
      Directory.Delete(folderPath, true);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (UnauthorizedAccessException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ZipUtility
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.Tools;

public sealed class ZipUtility
{
  private const string WINRARPATH = "C:\\Program Files\\WinRAR\\WinRAR.exe";
  private const int MAX_PATH = 260;
  private const int MAX_DIRECTORY_PATH = 248;
  private const int MAX_PADDING = 12;

  public void CompressFilesToNewZipArchive(string[] files, string zipFileName)
  {
    if (files == null)
      throw new ArgumentNullException(nameof (files));
    using (ZipArchive destination = ZipFile.Open(zipFileName, ZipArchiveMode.Create))
    {
      string[] strArray = files;
      int index = 0;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        destination.CreateEntryFromFile(str, Path.GetFileName(str), CompressionLevel.Optimal);
        checked { ++index; }
      }
    }
  }

  public void CompressFilesToNewZipArchive(string sourceDirectory, string zipFileName)
  {
    this.CompressFilesToNewZipArchive(Directory.GetFiles(sourceDirectory), zipFileName);
  }

  public void CompressFileToNewZipArchive(string sourceFile, string zipFileName)
  {
    this.CompressFilesToNewZipArchive(new string[1]
    {
      sourceFile
    }, zipFileName);
  }

  public byte[] CompressStreamsToNewZipStream(byte[][] fileData, string[] fileNames)
  {
    if (fileData == null)
      throw new ArgumentNullException(nameof (fileData));
    if (fileNames == null)
      throw new ArgumentNullException(nameof (fileNames));
    MemoryStream memoryStream1 = new MemoryStream();
    using (ZipArchive zipArchive = new ZipArchive((Stream) memoryStream1, ZipArchiveMode.Create))
    {
      int num = fileData.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        ZipArchiveEntry entry = zipArchive.CreateEntry(fileNames[index], CompressionLevel.Optimal);
        using (MemoryStream memoryStream2 = new MemoryStream(fileData[index]))
        {
          using (Stream destination = entry.Open())
            memoryStream2.CopyTo(destination);
        }
      }
    }
    return memoryStream1.ToArray();
  }

  public byte[] CompressStreamToNewZipStream(byte[] fileData, string fileName)
  {
    return this.CompressStreamsToNewZipStream(new byte[1][]
    {
      fileData
    }, new string[1]{ fileName });
  }

  public void ExtractFilesFromZipArchive(
    byte[] zipArchiveBytes,
    out string[] fileNames,
    out byte[][] fileStreams)
  {
    List<string> stringList = new List<string>();
    List<byte[]> numArrayList = new List<byte[]>();
    using (ZipArchive zipArchive = new ZipArchive((Stream) new MemoryStream(zipArchiveBytes), ZipArchiveMode.Read))
    {
      try
      {
        foreach (ZipArchiveEntry entry in zipArchive.Entries)
        {
          using (Stream stream = entry.Open())
          {
            using (MemoryStream destination = new MemoryStream())
            {
              stream.CopyTo((Stream) destination);
              stringList.Add(entry.Name);
              numArrayList.Add(destination.ToArray());
            }
          }
        }
      }
      finally
      {
        IEnumerator<ZipArchiveEntry> enumerator;
        enumerator?.Dispose();
      }
    }
    fileNames = stringList.ToArray();
    fileStreams = numArrayList.ToArray();
  }

  public void ExtractFilesFromZipArchive(string zipFileName, string destinationDirectory)
  {
    if (string.IsNullOrWhiteSpace(destinationDirectory))
      throw new ArgumentNullException(nameof (destinationDirectory));
    if (string.IsNullOrWhiteSpace(zipFileName))
      throw new ArgumentNullException(nameof (zipFileName));
    if (!destinationDirectory.EndsWith("\\", StringComparison.OrdinalIgnoreCase))
      destinationDirectory += "\\";
    using (FileStream fileStream = new FileStream(zipFileName, FileMode.Open))
    {
      using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Update))
      {
        try
        {
          foreach (ZipArchiveEntry entry in zipArchive.Entries)
          {
            string destinationFileName = ZipUtility.Resolve(destinationDirectory + entry.Name);
            entry.ExtractToFile(destinationFileName, true);
          }
        }
        finally
        {
          IEnumerator<ZipArchiveEntry> enumerator;
          enumerator?.Dispose();
        }
      }
    }
  }

  public static void ExtractAndMoveFile(string compressedFileName, string destinationFileName)
  {
    if (string.IsNullOrWhiteSpace(compressedFileName))
      throw new ArgumentNullException(nameof (compressedFileName));
    if (string.IsNullOrWhiteSpace(destinationFileName))
      throw new ArgumentNullException(nameof (destinationFileName));
    using (FileStream fileStream = new FileStream(compressedFileName, FileMode.Open))
    {
      using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Update))
        zipArchive.Entries.Single<ZipArchiveEntry>().ExtractToFile(destinationFileName);
    }
    File.Delete(compressedFileName);
  }

  public static bool IsArchive(string fileName)
  {
    bool flag;
    try
    {
      using (ZipFile.OpenRead(fileName))
        ;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public static bool CanTryRepairArchive(Exception exception)
  {
    return exception != null && (object) exception.TargetSite != null && Operators.CompareString(exception.TargetSite.Name, "ReadCentralDirectory", false) == 0 && exception.Message.StartsWith("Number of entries expected in End Of Central Directory") || exception.Message.StartsWith("End of Central Directory record could not be found");
  }

  public static bool CheckWinRarInstalled() => File.Exists("C:\\Program Files\\WinRAR\\WinRAR.exe");

  public static void RepairArchive(string fileName)
  {
    File.WriteAllBytes(fileName, ZipUtility.RepairArchive(File.ReadAllBytes(fileName)));
  }

  public static byte[] RepairArchive(byte[] compressedBytes)
  {
    if (compressedBytes == null || compressedBytes.Length == 0)
      throw new ArgumentNullException(nameof (compressedBytes));
    if (!File.Exists("C:\\Program Files\\WinRAR\\WinRAR.exe"))
      throw new InvalidOperationException("WinRar must be installed in C:\\Program Files\\WinRAR\\");
    string path1 = "";
    try
    {
      path1 = ZipUtility.GetMGATempRandomFolderPath();
      string path2 = path1 + "corrupt.zip";
      File.WriteAllBytes(path2, compressedBytes);
      using (Process process = new Process())
      {
        process.StartInfo.FileName = "C:\\Program Files\\WinRAR\\WinRAR.exe";
        process.StartInfo.Arguments = $"r -y \"{path2}\" \"{path1}\"";
        process.Start();
        process.WaitForExit(30000);
      }
      return File.Exists(path1 + "rebuilt.corrupt.zip") ? File.ReadAllBytes(path1 + "rebuilt.corrupt.zip") : throw new InvalidOperationException("Unable to repair archive");
    }
    finally
    {
      if (Directory.Exists(path1))
        Directory.Delete(path1, true);
    }
  }

  private static string GetMGATempRandomFolderPath()
  {
    string path = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}MGA Temp\\{1}\\", (object) Path.GetTempPath(), (object) Guid.NewGuid().ToString());
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    return path;
  }

  private static string Resolve(string proposedFileName)
  {
    string fileName = Path.GetFileName(proposedFileName);
    return ZipUtility.Resolve(Path.GetDirectoryName(proposedFileName), fileName);
  }

  private static string Resolve(string targetDirectory, string fileName)
  {
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    string seed = fileName;
    Func<string, char, string> func;
    // ISSUE: reference to a compiler-generated field
    if (ZipUtility._Closure\u0024__.\u0024I20\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      func = ZipUtility._Closure\u0024__.\u0024I20\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ZipUtility._Closure\u0024__.\u0024I20\u002D0 = func = (Func<string, char, string>) ([SpecialName] (current, c) => current.Replace(c.ToString(), string.Empty));
    }
    fileName = ((IEnumerable<char>) invalidFileNameChars).Aggregate<char, string>(seed, func);
    fileName = Regex.Replace(fileName, "\\u200B", "");
    targetDirectory = Path.GetFullPath(targetDirectory);
    string fileName1 = targetDirectory.Length < 248 ? Path.Combine(targetDirectory, fileName) : throw new PathTooLongException($"targetDirectory {targetDirectory.Length} characters long, max is {248}");
    if (fileName1.Length + 12 > 260)
      fileName1 = Path.Combine(targetDirectory, Path.GetFileNameWithoutExtension(fileName).Substring(0, 260 - targetDirectory.Length - Path.GetExtension(fileName).Length - 12) + Path.GetExtension(fileName));
    return ZipUtility.ResolveDuplicateFileName(fileName1);
  }

  private static string ResolveDuplicateFileName(string fileName)
  {
    if (string.IsNullOrWhiteSpace(fileName))
      throw new ArgumentNullException(nameof (fileName));
    string str1;
    if (!File.Exists(fileName))
    {
      str1 = fileName;
    }
    else
    {
      string directoryName = Path.GetDirectoryName(fileName);
      string withoutExtension = Path.GetFileNameWithoutExtension(fileName);
      string str = Path.GetExtension(fileName);
      IEnumerable<string> source = Enumerable.Range(1, int.MaxValue).Select<int, string>((Func<int, string>) ([SpecialName] (e) => Path.Combine(directoryName, $"{withoutExtension}({e}){str}")));
      Func<string, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (ZipUtility._Closure\u0024__.\u0024I21\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = ZipUtility._Closure\u0024__.\u0024I21\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        ZipUtility._Closure\u0024__.\u0024I21\u002D1 = predicate = (Func<string, bool>) ([SpecialName] (e) => !File.Exists(e));
      }
      str1 = source.FirstOrDefault<string>(predicate);
    }
    return str1;
  }
}

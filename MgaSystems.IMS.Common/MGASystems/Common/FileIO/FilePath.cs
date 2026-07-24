// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileIO.FilePath
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.Common.FileIO;

public class FilePath
{
  private const int MAX_PATH = 260;
  private const int MAX_DIRECTORY_PATH = 248;
  private const int MAX_PADDING = 12;

  public static void Extract(string compressedFileName)
  {
    if (string.IsNullOrWhiteSpace(compressedFileName))
      throw new ArgumentNullException(nameof (compressedFileName));
    string str = compressedFileName + ".tmp";
    try
    {
      File.Move(compressedFileName, str);
      FilePath.ExtractAndMoveFile(str, compressedFileName);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      File.Move(str, compressedFileName);
      throw;
    }
    finally
    {
      if (File.Exists(str))
        File.Delete(str);
    }
  }

  public static void ExtractAndMoveFile(string compressedFileName, string destinationFileName)
  {
    if (string.IsNullOrWhiteSpace(compressedFileName))
      throw new ArgumentNullException(nameof (compressedFileName));
    if (string.IsNullOrWhiteSpace(destinationFileName))
      throw new ArgumentNullException(nameof (destinationFileName));
    ZipUtility.ExtractAndMoveFile(compressedFileName, destinationFileName);
  }

  public static string Resolve(string proposedFileName)
  {
    string fileName = Path.GetFileName(proposedFileName);
    return FilePath.Resolve(Path.GetDirectoryName(proposedFileName), fileName);
  }

  public static string Resolve(string targetDirectory, string fileName)
  {
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    string seed = fileName;
    Func<string, char, string> func;
    // ISSUE: reference to a compiler-generated field
    if (FilePath._Closure\u0024__.\u0024I7\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      func = FilePath._Closure\u0024__.\u0024I7\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      FilePath._Closure\u0024__.\u0024I7\u002D0 = func = (Func<string, char, string>) ([SpecialName] (current, c) => current.Replace(c.ToString(), string.Empty));
    }
    fileName = ((IEnumerable<char>) invalidFileNameChars).Aggregate<char, string>(seed, func);
    fileName = Regex.Replace(fileName, "\\u200B", "");
    targetDirectory = Path.GetFullPath(targetDirectory);
    string fileName1 = targetDirectory.Length < 248 ? Path.Combine(targetDirectory, fileName) : throw new PathTooLongException($"targetDirectory {targetDirectory.Length} characters long, max is {248}");
    if (fileName1.Length + 12 > 260)
      fileName1 = Path.Combine(targetDirectory, Path.GetFileNameWithoutExtension(fileName).Substring(0, 260 - targetDirectory.Length - Path.GetExtension(fileName).Length - 12) + Path.GetExtension(fileName));
    return FilePath.ResolveDuplicateFileName(fileName1);
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
      if (FilePath._Closure\u0024__.\u0024I8\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = FilePath._Closure\u0024__.\u0024I8\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        FilePath._Closure\u0024__.\u0024I8\u002D1 = predicate = (Func<string, bool>) ([SpecialName] (e) => !File.Exists(e));
      }
      str1 = source.FirstOrDefault<string>(predicate);
    }
    return str1;
  }
}

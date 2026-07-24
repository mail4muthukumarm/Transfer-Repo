// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DependencyResolver
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

#nullable disable
namespace MGASystems.Common;

public sealed class DependencyResolver
{
  private static Dictionary<string, string> _gacHash;

  private DependencyResolver()
  {
  }

  public static List<string> ResolveMissingDependencies(string fileToResolve)
  {
    List<string> stringList = new List<string>();
    if (File.Exists(fileToResolve))
    {
      AssemblyName[] referencedAssemblies = Assembly.LoadFile(fileToResolve).GetReferencedAssemblies();
      int index = 0;
      while (index < referencedAssemblies.Length)
      {
        AssemblyName assemblyName = referencedAssemblies[index];
        if (Operators.CompareString(assemblyName.Name, "mscorlib", false) != 0 && !DependencyResolver.FindInCurrentDir(new FileInfo(fileToResolve).DirectoryName, assemblyName.Name) && !DependencyResolver.FindInGac(assemblyName.Name))
          stringList.Add(assemblyName.Name);
        checked { ++index; }
      }
    }
    return stringList;
  }

  private static Dictionary<string, string> GacHash
  {
    get
    {
      if (DependencyResolver._gacHash == null)
      {
        DependencyResolver._gacHash = new Dictionary<string, string>();
        string path = $"{Environment.GetEnvironmentVariable("systemroot")}\\Assembly\\GAC\\";
        if (Directory.Exists(path))
        {
          string[] directories = Directory.GetDirectories(path);
          int index = 0;
          while (index < directories.Length)
          {
            string str = directories[index];
            string key = str.Substring(str.LastIndexOf("\\") + 1);
            DependencyResolver._gacHash.Add(key, key);
            checked { ++index; }
          }
        }
      }
      return DependencyResolver._gacHash;
    }
  }

  private static bool FindInCurrentDir(string searchDir, string name)
  {
    bool inCurrentDir;
    if (Directory.Exists(searchDir))
    {
      string[] files = Directory.GetFiles(searchDir);
      int index = 0;
      while (index < files.Length)
      {
        FileInfo fileInfo = new FileInfo(files[index]);
        if (Operators.CompareString(fileInfo.Name.Replace(fileInfo.Extension, string.Empty), name, false) == 0)
        {
          inCurrentDir = true;
          goto label_8;
        }
        checked { ++index; }
      }
      inCurrentDir = false;
    }
    else
      inCurrentDir = false;
label_8:
    return inCurrentDir;
  }

  private static bool FindInGac(string name) => DependencyResolver.GacHash.ContainsKey(name);
}

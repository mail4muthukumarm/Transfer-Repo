// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DotnetEnvironment
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.NativeWindowMethods.SafeAPICalls;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class DotnetEnvironment
{
  private static string NetFx10RegKeyName = "Software\\Microsoft\\.NETFramework\\Policy\\v1.0";
  private static string NetFx10RegKeyValue = "3705";
  private static string NetFx10SPxMSIRegKeyName = "Software\\Microsoft\\Active Setup\\Installed Components\\{78705f0d-e8db-4b2d-8193-982bdda15ecd}";
  private static string NetFx10SPxOCMRegKeyName = "Software\\Microsoft\\Active Setup\\Installed Components\\{FDC11A6F-17D1-48f9-9EA3-9051954BAA24}";
  private static string NetFx11RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v1.1.4322";
  private static string NetFx20RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v2.0.50727";
  private static string NetFx30RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v3.0\\Setup";
  private static string NetFx30SpRegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v3.0";
  private static string NetFx30RegValueName = "InstallSuccess";
  private static string NetFx35RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v3.5";
  private static string NetFx40ClientRegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v4\\Client";
  private static string NetFx40FullRegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full";
  private static string NetFx40SPxRegValueName = "Servicing";
  private static string NetFxStandardRegValueName = "Install";
  private static string NetFxStandardSPxRegValueName = "SP";
  private static string NetFxStandardVersionRegValueName = "Version";
  private static int NetFx30VersionMajor = 3;
  private static int NetFx30VersionMinor = 0;
  private static int NetFx30VersionBuild = 4506;
  private static int NetFx30VersionRevision = 26;
  private static int NetFx35VersionMajor = 3;
  private static int NetFx35VersionMinor = 5;
  private static int NetFx35VersionBuild = 21022;
  private static int NetFx35VersionRevision = 8;

  public static bool IsNetFx10Installed()
  {
    return DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx10RegKeyName, DotnetEnvironment.NetFx10RegKeyValue) != null;
  }

  public static bool IsNetFx11Installed()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx11RegKeyName, DotnetEnvironment.NetFxStandardRegValueName));
    return objectValue != null && Conversions.ToInteger(objectValue) == 1;
  }

  public static bool IsNetFx20Installed()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx20RegKeyName, DotnetEnvironment.NetFxStandardRegValueName));
    return objectValue != null && Conversions.ToInteger(objectValue) == 1;
  }

  public static bool IsNetFx30Installed()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx30RegKeyName, DotnetEnvironment.NetFx30RegValueName));
    return (objectValue == null ? 0 : (Conversions.ToInteger(objectValue) == 1 ? 1 : 0)) != 0 && DotnetEnvironment.CheckNetFxBuildNumber(DotnetEnvironment.NetFx30RegKeyName, DotnetEnvironment.NetFxStandardVersionRegValueName, DotnetEnvironment.NetFx30VersionMajor, DotnetEnvironment.NetFx30VersionMinor, DotnetEnvironment.NetFx30VersionBuild, DotnetEnvironment.NetFx30VersionRevision);
  }

  public static bool IsNetFx35Sp1Installed()
  {
    return DotnetEnvironment.IsNetFx35Installed() && DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx35RegKeyName, DotnetEnvironment.NetFxStandardSPxRegValueName) >= 1;
  }

  public static bool IsNetFx35Installed()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx35RegKeyName, DotnetEnvironment.NetFxStandardRegValueName));
    return (objectValue == null ? 0 : (Conversions.ToInteger(objectValue) == 1 ? 1 : 0)) != 0 && DotnetEnvironment.CheckNetFxBuildNumber(DotnetEnvironment.NetFx35RegKeyName, DotnetEnvironment.NetFxStandardVersionRegValueName, DotnetEnvironment.NetFx35VersionMajor, DotnetEnvironment.NetFx35VersionMinor, DotnetEnvironment.NetFx35VersionBuild, DotnetEnvironment.NetFx35VersionRevision);
  }

  public static bool IsNetFx40ClientInstalled()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx40ClientRegKeyName, DotnetEnvironment.NetFxStandardRegValueName));
    return objectValue != null && Conversions.ToInteger(objectValue) == 1;
  }

  public static bool IsNetFx40FullInstalled()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx40FullRegKeyName, DotnetEnvironment.NetFxStandardRegValueName));
    return objectValue != null && Conversions.ToInteger(objectValue) == 1;
  }

  private static int GetNetFx10SPLevel()
  {
    int netFx10SpLevel = -1;
    string str = !DotnetEnvironment.IsCurrentOSTabletMedCenter() ? DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx10SPxMSIRegKeyName, DotnetEnvironment.NetFxStandardVersionRegValueName) as string : DotnetEnvironment.RegistryGetValue(DotnetEnvironment.NetFx10SPxOCMRegKeyName, DotnetEnvironment.NetFxStandardVersionRegValueName) as string;
    if (!string.IsNullOrEmpty(str))
    {
      int num = str.LastIndexOf(',');
      if (num != -1)
      {
        int startIndex = num + 1;
        netFx10SpLevel = int.Parse(str.Substring(startIndex), (IFormatProvider) CultureInfo.InvariantCulture);
      }
    }
    return netFx10SpLevel;
  }

  private static int GetNetFxSPLevel(string NetFxRegKeyName, string NetFxRegValueName)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DotnetEnvironment.RegistryGetValue(NetFxRegKeyName, NetFxRegValueName));
    return objectValue == null ? -1 : Conversions.ToInteger(objectValue);
  }

  private static bool CheckNetFxBuildNumber(
    string regKeyName,
    string regKeyValue,
    int requestedVersionMajor,
    int requestedVersionMinor,
    int requestedVersionBuild,
    int requestedVersionRevision)
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 0;
    string str = DotnetEnvironment.RegistryGetValue(regKeyName, regKeyValue) as string;
    if (!string.IsNullOrEmpty(str))
    {
      string[] strArray = str.Split('.');
      if (strArray != null && strArray.Length > 0)
      {
        int num6 = strArray.Length - 1;
        for (int index = 0; index <= num6; ++index)
        {
          ++num1;
          switch (num1)
          {
            case 1:
              num2 = int.Parse(strArray[index], (IFormatProvider) CultureInfo.InvariantCulture);
              break;
            case 2:
              num3 = int.Parse(strArray[index], (IFormatProvider) CultureInfo.InvariantCulture);
              break;
            case 3:
              num4 = int.Parse(strArray[index], (IFormatProvider) CultureInfo.InvariantCulture);
              break;
            case 4:
              num5 = int.Parse(strArray[index], (IFormatProvider) CultureInfo.InvariantCulture);
              break;
          }
        }
      }
    }
    bool flag;
    if (num2 > requestedVersionMajor)
    {
      flag = true;
    }
    else
    {
      if (num2 == requestedVersionMajor)
      {
        if (num3 > requestedVersionMinor)
        {
          flag = true;
          goto label_21;
        }
        if (num3 == requestedVersionMinor)
        {
          if (num4 > requestedVersionBuild)
          {
            flag = true;
            goto label_21;
          }
          if (num4 == requestedVersionBuild && num5 >= requestedVersionRevision)
          {
            flag = true;
            goto label_21;
          }
        }
      }
      flag = false;
    }
label_21:
    return flag;
  }

  private static bool IsCurrentOSTabletMedCenter()
  {
    return SafeAPI.GetSystemMetrics(86) != 0 || SafeAPI.GetSystemMetrics(87) != 0;
  }

  private static object RegistryGetValue(string key, string value)
  {
    RegistryKey registryKey = (RegistryKey) null;
    object obj;
    try
    {
      registryKey = Registry.LocalMachine.OpenSubKey(key);
      if (registryKey != null)
      {
        obj = registryKey.GetValue(value, (object) null);
        goto label_8;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      registryKey?.Close();
    }
    obj = (object) null;
label_8:
    return obj;
  }

  public static List<string> DetectInstalledDotnetVersions()
  {
    List<string> stringList = new List<string>();
    bool flag1 = DotnetEnvironment.IsNetFx10Installed();
    bool flag2 = DotnetEnvironment.IsNetFx11Installed();
    bool flag3 = DotnetEnvironment.IsNetFx20Installed();
    bool flag4 = DotnetEnvironment.IsNetFx20Installed() && DotnetEnvironment.IsNetFx30Installed();
    bool flag5 = DotnetEnvironment.IsNetFx20Installed() && DotnetEnvironment.IsNetFx30Installed() && DotnetEnvironment.IsNetFx35Installed();
    bool flag6 = DotnetEnvironment.IsNetFx40ClientInstalled();
    int num = DotnetEnvironment.IsNetFx40FullInstalled() ? 1 : 0;
    if (flag1)
    {
      int netFx10SpLevel = DotnetEnvironment.GetNetFx10SPLevel();
      if (netFx10SpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 1.0 service pack {0} is installed.", (object) netFx10SpLevel));
      else
        stringList.Add(".NET Framework 1.0 is installed with no service packs.");
    }
    if (flag2)
    {
      int netFxSpLevel = DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx11RegKeyName, DotnetEnvironment.NetFxStandardSPxRegValueName);
      if (netFxSpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 1.1 service pack {0} is installed.", (object) netFxSpLevel));
      else
        stringList.Add(".NET Framework 1.1 is installed with no service packs.");
    }
    if (flag3)
    {
      int netFxSpLevel = DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx20RegKeyName, DotnetEnvironment.NetFxStandardSPxRegValueName);
      if (netFxSpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 2.0 service pack {0} is installed.", (object) netFxSpLevel));
      else
        stringList.Add(".NET Framework 2.0 is installed with no service packs.");
    }
    if (flag4)
    {
      int netFxSpLevel = DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx30SpRegKeyName, DotnetEnvironment.NetFxStandardSPxRegValueName);
      if (netFxSpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 3.0 service pack {0} is installed.", (object) netFxSpLevel));
      else
        stringList.Add(".NET Framework 3.0 is installed with no service packs.");
    }
    if (flag5)
    {
      int netFxSpLevel = DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx35RegKeyName, DotnetEnvironment.NetFxStandardSPxRegValueName);
      if (netFxSpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 3.5 service pack {0} is installed.", (object) netFxSpLevel));
      else
        stringList.Add(".NET Framework 3.5 is installed with no service packs.");
    }
    if (flag6)
    {
      int netFxSpLevel = DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx40ClientRegKeyName, DotnetEnvironment.NetFx40SPxRegValueName);
      if (netFxSpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 4 client service pack {0} is installed.", (object) netFxSpLevel));
      else
        stringList.Add(".NET Framework 4 client is installed with no service packs.");
    }
    if (num != 0)
    {
      int netFxSpLevel = DotnetEnvironment.GetNetFxSPLevel(DotnetEnvironment.NetFx40FullRegKeyName, DotnetEnvironment.NetFx40SPxRegValueName);
      if (netFxSpLevel > 0)
        stringList.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, ".NET Framework 4 full service pack {0} is installed.", (object) netFxSpLevel));
      else
        stringList.Add(".NET Framework 4 full is installed with no service packs.");
    }
    return stringList;
  }
}

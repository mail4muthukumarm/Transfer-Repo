// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SystemInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.NativeWindowMethods;
using MGASystems.Common.NativeWindowMethods.SafeAPICalls;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
[Preference("Office.Version.Access.Override", -1)]
[Preference("Office.Version.Excel.Override", -1)]
[Preference("Office.Version.PowerPoint.Override", -1)]
[Preference("Office.Version.Word.Override", -1)]
[Preference("Office.Version.Outlook.Override", -1)]
public sealed class SystemInfo
{
  public const string PREFERENCE_OfficeVersion_Access = "Office.Version.Access.Override";
  public const string PREFERENCE_OfficeVersion_Excel = "Office.Version.Excel.Override";
  public const string PREFERENCE_OfficeVersion_PowerPoint = "Office.Version.PowerPoint.Override";
  public const string PREFERENCE_OfficeVersion_Word = "Office.Version.Word.Override";
  public const string PREFERENCE_OfficeVersion_Outlook = "Office.Version.Outlook.Override";
  private static IPreferenceManager _preferenceManager;
  private static string _defaultMailClient = string.Empty;

  private static bool IsWindowSizable(int handle)
  {
    return ((ulong) SafeAPI.GetWindowLong(handle, API.GWL_FLAGS.GWL_STYLE) & 262144UL /*0x040000*/ & 262144UL /*0x040000*/) > 0UL;
  }

  private static bool IsWindowSizable(Form frm) => frm.FormBorderStyle == FormBorderStyle.Sizable;

  public static void MoveWindowToSecondaryMonitorRestored(Form frm)
  {
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    if (Screen.AllScreens.Length <= 1)
      return;
    Screen[] allScreens = Screen.AllScreens;
    int index = 0;
    while (index < allScreens.Length)
    {
      Screen screen = allScreens[index];
      if (screen != Screen.PrimaryScreen)
      {
        Rectangle workingArea = screen.WorkingArea;
        if (SystemInfo.IsWindowSizable(frm))
        {
          frm.DesktopBounds = screen.Bounds;
          break;
        }
        frm.Location = new Point(workingArea.Left + (int) Math.Round((double) workingArea.Width / 2.0), workingArea.Top + (int) Math.Round((double) workingArea.Height / 2.0));
        break;
      }
      checked { ++index; }
    }
  }

  public static int MoveWindowToSecondaryMonitorRestored(int windowHandle)
  {
    int secondaryMonitorRestored;
    if (Screen.AllScreens.Length > 1)
    {
      Screen[] allScreens = Screen.AllScreens;
      int index = 0;
      while (index < allScreens.Length)
      {
        Screen screen = allScreens[index];
        if (screen != Screen.PrimaryScreen)
        {
          Rectangle workingArea = screen.WorkingArea;
          if (SystemInfo.IsWindowSizable(windowHandle))
          {
            secondaryMonitorRestored = SafeAPI.MoveWindow(windowHandle, workingArea.Left, workingArea.Top, workingArea.Width, workingArea.Height, 1);
            goto label_9;
          }
          Rectangle windowRect = SafeAPI.GetWindowRect(windowHandle);
          secondaryMonitorRestored = SafeAPI.MoveWindow(windowHandle, workingArea.Left + (int) Math.Round((double) workingArea.Width / 2.0), workingArea.Top + (int) Math.Round((double) workingArea.Height / 2.0), windowRect.Width, windowRect.Height, 1);
          goto label_9;
        }
        checked { ++index; }
      }
    }
    secondaryMonitorRestored = 0;
label_9:
    return secondaryMonitorRestored;
  }

  private static IPreferenceManager PreferenceManager
  {
    get
    {
      if (SystemInfo._preferenceManager == null)
        SystemInfo._preferenceManager = ObjectFactory.Instance.CreateObject(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.NoteDocuments.Serialization.Preferences")) as IPreferenceManager;
      return SystemInfo._preferenceManager;
    }
  }

  private static int GetApplicationPreferenceVersion(SystemInfo.OfficeApps application)
  {
    int preferenceInt;
    switch (application)
    {
      case SystemInfo.OfficeApps.Access:
        preferenceInt = SystemInfo.PreferenceManager.GetPreferenceInt("Office.Version.Access.Override");
        break;
      case SystemInfo.OfficeApps.Excel:
        preferenceInt = SystemInfo.PreferenceManager.GetPreferenceInt("Office.Version.Excel.Override");
        break;
      case SystemInfo.OfficeApps.PowerPoint:
        preferenceInt = SystemInfo.PreferenceManager.GetPreferenceInt("Office.Version.PowerPoint.Override");
        break;
      case SystemInfo.OfficeApps.Word:
        preferenceInt = SystemInfo.PreferenceManager.GetPreferenceInt("Office.Version.Word.Override");
        break;
      case SystemInfo.OfficeApps.Outlook:
        preferenceInt = SystemInfo.PreferenceManager.GetPreferenceInt("Office.Version.Outlook.Override");
        break;
    }
    return preferenceInt;
  }

  public static RegistryKey OpenLocalMachine()
  {
    return !Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32) : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
  }

  public static bool IsOfficeAppAvailable(
    SystemInfo.OfficeApps application,
    SystemInfo.WordVersion minimumVersion)
  {
    string errorMessage = $"In: application {Enum.GetName(typeof (SystemInfo.OfficeApps), (object) application)}, minimumVersion {Enum.GetName(typeof (SystemInfo.WordVersion), (object) minimumVersion)}. ";
    bool flag;
    if (CurrentUser.Instance.UserID != 0 && (SystemInfo.WordVersion) SystemInfo.GetApplicationPreferenceVersion(application) >= minimumVersion)
    {
      flag = true;
    }
    else
    {
      try
      {
        using (RegistryKey registryKey1 = SystemInfo.OpenLocalMachine())
        {
          if (registryKey1 != null)
          {
            using (RegistryKey registryKey2 = registryKey1.OpenSubKey("SOFTWARE", false))
            {
              if (registryKey2 != null)
              {
                using (RegistryKey registryKey3 = registryKey2.OpenSubKey("Microsoft", false))
                {
                  if (registryKey3 != null)
                  {
                    using (RegistryKey officeKey = registryKey3.OpenSubKey("Office", false))
                    {
                      if (officeKey != null)
                      {
                        flag = SystemInfo.ProcessOfficeKey(officeKey, errorMessage, application, minimumVersion);
                        goto label_29;
                      }
                      errorMessage += "Office key NOT FOUND (null). ";
                    }
                  }
                  else
                    errorMessage += "Microsoft key NOT FOUND (null). ";
                }
              }
              else
                errorMessage += "Processing: SOFTWARE key NOT FOUND (null). ";
            }
          }
          else
            errorMessage += "Processing: Local Machine key NOT FOUND (null). ";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception innerException = ex;
        throw new InvalidOperationException($"Problem occurred while scanning. Info: {errorMessage} (see inner exception for more detail).", innerException);
      }
      flag = false;
    }
label_29:
    return flag;
  }

  private static bool ProcessOfficeKey(
    RegistryKey officeKey,
    string errorMessage,
    SystemInfo.OfficeApps application,
    SystemInfo.WordVersion minimumVersion)
  {
    string name1 = Enum.GetName(typeof (SystemInfo.OfficeApps), (object) application);
    string[] subKeyNames1 = officeKey.GetSubKeyNames();
    bool flag;
    if (subKeyNames1 != null)
    {
      errorMessage += $"Office key sub keys FOUND. ({string.Join(",", subKeyNames1)}). ";
      List<string> stringList = new List<string>();
      string[] strArray1 = subKeyNames1;
      int index1 = 0;
      while (index1 < strArray1.Length)
      {
        string Expression = strArray1[index1];
        if (Versioned.IsNumeric((object) Expression) && (SystemInfo.WordVersion) Conversions.ToInteger(Expression) >= minimumVersion)
          stringList.Add(Expression);
        checked { ++index1; }
      }
      errorMessage += $"Valid Versions Determined. ({string.Join(",", stringList.ToArray())}). ";
      if (stringList.Count > 0)
      {
        try
        {
          foreach (string name2 in stringList)
          {
            using (RegistryKey registryKey = officeKey.OpenSubKey(name2, false))
            {
              if (registryKey != null)
              {
                string[] subKeyNames2 = registryKey.GetSubKeyNames();
                errorMessage = subKeyNames2 == null ? errorMessage + "Version key has NO sub keys! " : errorMessage + $"Version key sub keys FOUND. ({string.Join(",", subKeyNames2)}). ";
                string[] strArray2 = subKeyNames2;
                int index2 = 0;
                while (index2 < strArray2.Length)
                {
                  string Left = strArray2[index2];
                  if (Operators.CompareString(Left, name1, false) == 0)
                  {
                    errorMessage += $"Valid Match Found! Success! (matched {Left} to {name1})";
                    flag = true;
                    goto label_24;
                  }
                  checked { ++index2; }
                }
              }
              else
                errorMessage += $"Version {name2} key NOT FOUND (null). ";
            }
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      else
        errorMessage += "No Valid Versions. ";
    }
    else
      errorMessage += "Office key has NO sub keys! ";
    flag = false;
label_24:
    return flag;
  }

  public static string DefaultMailClient
  {
    get
    {
      if (SystemInfo._defaultMailClient.Length == 0)
      {
        RegistryKey registryKey1 = (RegistryKey) null;
        RegistryKey registryKey2 = (RegistryKey) null;
        RegistryKey registryKey3 = (RegistryKey) null;
        try
        {
          registryKey1 = Registry.LocalMachine.OpenSubKey("SOFTWARE", false);
          registryKey2 = registryKey1.OpenSubKey("Clients", false);
          registryKey3 = registryKey2.OpenSubKey("Mail", false);
          SystemInfo._defaultMailClient = Conversions.ToString(registryKey3.GetValue((string) null, (object) "Unavailable"));
        }
        finally
        {
          registryKey1?.Close();
          registryKey2?.Close();
          registryKey3?.Close();
        }
      }
      return SystemInfo._defaultMailClient;
    }
  }

  public enum OfficeApps
  {
    Access,
    Excel,
    PowerPoint,
    Word,
    Outlook,
  }

  public enum WordVersion
  {
    None = 0,
    Office2000 = 9,
    OfficeXP = 10, // 0x0000000A
    Office2003 = 11, // 0x0000000B
    Office2007 = 12, // 0x0000000C
    Office2010 = 14, // 0x0000000E
    Office2013 = 15, // 0x0000000F
    Office2016 = 16, // 0x00000010
  }
}

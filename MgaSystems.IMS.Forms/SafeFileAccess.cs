// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.SafeFileAccess
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[StandardModule]
public sealed class SafeFileAccess
{
  private static bool _inAccess;

  public static void BeginDirectoryAccess(string dirPath)
  {
    SafeFileAccess.BeginDirectoryAccess(dirPath, false);
  }

  public static void BeginDirectoryAccess(string dirPath, bool forceCredentialGet)
  {
    SafeFileAccess._inAccess = !SafeFileAccess._inAccess ? true : throw new InvalidOperationException("No need to begin another SafeAccess when you already have permission to access this resource");
    if (Environment.OSVersion.Platform != PlatformID.Win32NT)
      return;
    bool flag1;
    if (!forceCredentialGet)
      flag1 = SafeFileAccess.TestDirectoryReadWriteAccess(dirPath);
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    bool flag2 = false;
    while (!flag1)
    {
      if (!forceCredentialGet && (flag2 || UserImpersonationManager.LoadUserCredentialsFromRegistry(ref empty1, ref empty2, ref empty3)) && UserImpersonationManager.AuthenticateUser(empty3, empty1, empty2) && UserImpersonationManager.Instance.ImpersonateUser(empty3, empty1, empty2))
      {
        UserImpersonationManager.SaveUserCredentialsToRegistry(empty1, empty2, empty3);
        if (SafeFileAccess.TestDirectoryReadWriteAccess(dirPath))
          break;
        UserImpersonationManager.Instance.RevertImpersonation();
      }
      forceCredentialGet = false;
      flag2 = true;
      if (!SafeFileAccess.GetInteractiveUserInfo(ref empty3, ref empty1, ref empty2, dirPath))
        throw new SafeFileAccessException();
    }
  }

  private static bool GetInteractiveUserInfo(
    ref string logonMachine,
    ref string userName,
    ref string passWord,
    string resource)
  {
    Cursor.Current = Cursors.WaitCursor;
    frmSafeFileAccessGetLoginInfo accessGetLoginInfo = new frmSafeFileAccessGetLoginInfo(resource);
    bool interactiveUserInfo;
    try
    {
      switch (accessGetLoginInfo.ShowDialog())
      {
        case DialogResult.OK:
          logonMachine = accessGetLoginInfo.LogonMachine;
          userName = accessGetLoginInfo.UserName;
          passWord = accessGetLoginInfo.PassWord;
          interactiveUserInfo = true;
          goto label_6;
        case DialogResult.Cancel:
          interactiveUserInfo = false;
          goto label_6;
      }
    }
    finally
    {
      accessGetLoginInfo.Dispose();
    }
    Cursor.Current = Cursors.Default;
label_6:
    return interactiveUserInfo;
  }

  public static void EndFileAccess()
  {
    if (UserImpersonationManager.Instance.IsImpersonating)
      UserImpersonationManager.Instance.RevertImpersonation();
    SafeFileAccess._inAccess = SafeFileAccess._inAccess ? false : throw new InvalidOperationException("You must be in a safe access prior to ending a safe access");
  }

  public static void EndDirectoryAccess()
  {
    if (UserImpersonationManager.Instance.IsImpersonating)
      UserImpersonationManager.Instance.RevertImpersonation();
    SafeFileAccess._inAccess = SafeFileAccess._inAccess ? false : throw new InvalidOperationException("You must be in a safe access prior to ending a safe access");
  }

  public static bool TestDirectoryReadWriteAccess(string dirPath)
  {
    bool flag = true;
    if (Directory.Exists(dirPath))
    {
      FileStream fileStream = (FileStream) null;
      try
      {
        fileStream = new FileStream($"{dirPath}\\test.xyz", FileMode.OpenOrCreate);
        if (fileStream != null)
        {
          fileStream.Close();
          File.Delete($"{dirPath}\\test.xyz");
        }
        else
          flag = false;
        if (flag)
        {
          string[] files = Directory.GetFiles(dirPath);
          if (files.Length > 0)
          {
            fileStream = new FileStream(files[0], FileMode.Open, FileAccess.Read);
            if (fileStream != null)
              fileStream.Close();
            else
              flag = false;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        fileStream?.Close();
      }
    }
    else
      flag = false;
    return flag;
  }
}

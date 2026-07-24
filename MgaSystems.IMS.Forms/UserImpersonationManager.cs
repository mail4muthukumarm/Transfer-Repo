// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.UserImpersonationManager
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class UserImpersonationManager : IDisposable
{
  private IntPtr _tokenHandle;
  private IntPtr _dupeTokenHandle;
  private bool _isImpersonating;
  private WindowsImpersonationContext _impersonatedUser;
  private static UserImpersonationManager _userImpersonationManager;
  private const int LOGON32_PROVIDER_DEFAULT = 0;
  private const int LOGON32_LOGON_INTERACTIVE = 2;
  private const int SecurityImpersonation = 2;
  private static readonly Guid _guidKey = new Guid("CF3B29C6-54C8-47c2-B2A5-DCF4E2E71940");

  private UserImpersonationManager()
  {
    this._tokenHandle = new IntPtr(0);
    this._dupeTokenHandle = new IntPtr(0);
  }

  [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern bool LogonUser(
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszUsername,
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszDomain,
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszPassword,
    int dwLogonType,
    int dwLogonProvider,
    ref IntPtr phToken);

  [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern bool CloseHandle(IntPtr handle);

  [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern bool DuplicateToken(
    IntPtr ExistingTokenHandle,
    int SECURITY_IMPERSONATION_LEVEL,
    ref IntPtr DuplicateTokenHandle);

  public bool IsImpersonating => this._isImpersonating;

  public void RevertImpersonation()
  {
    if (!this._isImpersonating)
      return;
    this._impersonatedUser.Undo();
    if (!(this._tokenHandle == IntPtr.Zero))
      UserImpersonationManager.CloseHandle(this._tokenHandle);
    if (!(this._dupeTokenHandle == IntPtr.Zero))
      UserImpersonationManager.CloseHandle(this._dupeTokenHandle);
    this._isImpersonating = false;
  }

  public bool ImpersonateUser(string logonMachine, string userName, string passWord)
  {
    return this.ImpersonateUser(logonMachine, userName, passWord, true);
  }

  public bool ImpersonateUser(
    string logonMachine,
    string userName,
    string passWord,
    bool autoRevertPreviousImpersonation)
  {
    if (autoRevertPreviousImpersonation && this._isImpersonating)
      this.RevertImpersonation();
    else if (this._isImpersonating)
      throw new InvalidOperationException("Cannot Impersonate a user without ending the current impersonation first");
    bool flag;
    if (!UserImpersonationManager.LogonUser(ref userName, ref logonMachine, ref passWord, 2, 0, ref this._tokenHandle))
      flag = false;
    else if (!UserImpersonationManager.DuplicateToken(this._tokenHandle, 2, ref this._dupeTokenHandle))
    {
      UserImpersonationManager.CloseHandle(this._tokenHandle);
      flag = false;
    }
    else
    {
      this._impersonatedUser = new WindowsIdentity(this._dupeTokenHandle).Impersonate();
      this._isImpersonating = true;
      flag = true;
    }
    return flag;
  }

  public static bool AuthenticateUser(string logonMachine, string userName, string passWord)
  {
    IntPtr phToken = new IntPtr(0);
    int num = UserImpersonationManager.LogonUser(ref userName, ref logonMachine, ref passWord, 2, 0, ref phToken) ? 1 : 0;
    if (num == 0)
      return num != 0;
    UserImpersonationManager.CloseHandle(phToken);
    return num != 0;
  }

  ~UserImpersonationManager()
  {
    UserImpersonationManager._userImpersonationManager.Dispose();
    // ISSUE: explicit finalizer call
    base.Finalize();
  }

  public void Dispose()
  {
    GC.SuppressFinalize((object) this);
    this.RevertImpersonation();
  }

  public static UserImpersonationManager Instance
  {
    get
    {
      if (UserImpersonationManager._userImpersonationManager == null)
        UserImpersonationManager._userImpersonationManager = new UserImpersonationManager();
      return UserImpersonationManager._userImpersonationManager;
    }
  }

  public static bool SaveUserCredentialsToRegistry(
    string userName,
    string passWord,
    string logonMachine)
  {
    if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord) || string.IsNullOrEmpty(logonMachine))
      throw new InvalidOperationException("All credentials must be complete!");
    string Plaintext1 = $"{userName},{logonMachine}";
    string Plaintext2 = passWord;
    string guidKey = UserImpersonationManager.GUIDKey;
    UserImpersonationManager.SaveUserInfo(UserImpersonationManager.EncryptTripleDES(Plaintext1, guidKey), UserImpersonationManager.EncryptTripleDES(Plaintext2, UserImpersonationManager.GUIDKey));
    bool registry;
    return registry;
  }

  public static bool LoadUserCredentialsFromRegistry(
    ref string userName,
    ref string passWord,
    ref string logonMachine)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    bool flag;
    if (UserImpersonationManager.GetUserInfo(ref empty1, ref empty2))
    {
      string Left = UserImpersonationManager.DecryptTripleDES(empty1, UserImpersonationManager.GUIDKey);
      string str = UserImpersonationManager.DecryptTripleDES(empty2, UserImpersonationManager.GUIDKey);
      if (Operators.CompareString(Left, string.Empty, false) != 0)
      {
        userName = Left.Split(",".ToCharArray())[0];
        logonMachine = Left.Split(",".ToCharArray())[1];
        flag = true;
      }
      passWord = str;
    }
    return flag;
  }

  public static void DeleteUserInfo()
  {
    RegistryKey registryKey1 = (RegistryKey) null;
    RegistryKey registryKey2 = (RegistryKey) null;
    RegistryKey registryKey3 = (RegistryKey) null;
    try
    {
      registryKey1 = Registry.LocalMachine;
      try
      {
        registryKey2 = registryKey1.OpenSubKey("Software", true);
        try
        {
          registryKey3 = registryKey2.OpenSubKey("MGA Systems IMS", true);
          if (registryKey3 != null)
            return;
          registryKey3 = registryKey2.CreateSubKey("MGA Systems IMS");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          if (registryKey3 == null)
            registryKey3 = registryKey2.CreateSubKey("MGA Systems IMS");
          ProjectData.ClearProjectError();
        }
        finally
        {
          if (registryKey3 != null)
          {
            try
            {
              registryKey3.DeleteValue("UserSetting1");
              registryKey3.DeleteValue("UserSetting2");
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            registryKey3.Close();
          }
        }
      }
      finally
      {
        registryKey2?.Close();
      }
    }
    finally
    {
      registryKey1?.Close();
    }
  }

  private static bool SaveUserInfo(string usernameDomainHash, string pwdHash)
  {
    RegistryKey registryKey1 = (RegistryKey) null;
    RegistryKey registryKey2 = (RegistryKey) null;
    RegistryKey registryKey3 = (RegistryKey) null;
    try
    {
      registryKey1 = Registry.LocalMachine;
      try
      {
        registryKey2 = registryKey1.OpenSubKey("Software", true);
        try
        {
          registryKey3 = registryKey2.OpenSubKey("MGA Systems IMS", true) ?? registryKey2.CreateSubKey("MGA Systems IMS");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          if (registryKey3 == null)
            registryKey3 = registryKey2.CreateSubKey("MGA Systems IMS");
          ProjectData.ClearProjectError();
        }
        finally
        {
          if (registryKey3 != null)
          {
            try
            {
              registryKey3.SetValue("UserSetting1", (object) usernameDomainHash);
              registryKey3.SetValue("UserSetting2", (object) pwdHash);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            registryKey3.Close();
          }
        }
      }
      finally
      {
        registryKey2?.Close();
      }
    }
    finally
    {
      registryKey1?.Close();
    }
    bool flag;
    return flag;
  }

  private static bool GetUserInfo(ref string usernameDomainHash, ref string pwdHash)
  {
    RegistryKey registryKey1 = (RegistryKey) null;
    RegistryKey registryKey2 = (RegistryKey) null;
    RegistryKey registryKey3 = (RegistryKey) null;
    bool flag = true;
    bool userInfo;
    try
    {
      registryKey1 = Registry.LocalMachine;
      try
      {
        registryKey2 = registryKey1.OpenSubKey("Software");
        try
        {
          registryKey3 = registryKey2.OpenSubKey("MGA Systems IMS");
          if (registryKey3 == null)
          {
            usernameDomainHash = string.Empty;
            pwdHash = string.Empty;
            userInfo = false;
            goto label_22;
          }
          try
          {
            usernameDomainHash = Conversions.ToString(registryKey3.GetValue("UserSetting1", (object) string.Empty));
            pwdHash = Conversions.ToString(registryKey3.GetValue("UserSetting2", (object) string.Empty));
            if (usernameDomainHash.Length != 0)
            {
              if (pwdHash.Length != 0)
                goto label_21;
            }
            usernameDomainHash = string.Empty;
            pwdHash = string.Empty;
            userInfo = false;
            goto label_22;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            usernameDomainHash = string.Empty;
            pwdHash = string.Empty;
            userInfo = false;
            ProjectData.ClearProjectError();
            goto label_22;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          if (registryKey3 == null)
          {
            usernameDomainHash = string.Empty;
            pwdHash = string.Empty;
            userInfo = false;
            ProjectData.ClearProjectError();
            goto label_22;
          }
          ProjectData.ClearProjectError();
        }
        finally
        {
          registryKey3?.Close();
        }
      }
      finally
      {
        registryKey2?.Close();
      }
    }
    finally
    {
      registryKey1?.Close();
    }
label_21:
    userInfo = flag;
label_22:
    return userInfo;
  }

  private static string EncryptTripleDES(string Plaintext, string Key)
  {
    TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
    cryptoServiceProvider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Key));
    cryptoServiceProvider.Mode = CipherMode.ECB;
    ICryptoTransform encryptor = cryptoServiceProvider.CreateEncryptor();
    byte[] bytes = Encoding.ASCII.GetBytes(Plaintext);
    byte[] inputBuffer = bytes;
    int length = bytes.Length;
    return Convert.ToBase64String(encryptor.TransformFinalBlock(inputBuffer, 0, length));
  }

  private static string DecryptTripleDES(string base64Text, string Key)
  {
    TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
    cryptoServiceProvider.Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Key));
    cryptoServiceProvider.Mode = CipherMode.ECB;
    ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor();
    byte[] inputBuffer = Convert.FromBase64String(base64Text);
    return Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
  }

  private static string GUIDKey => UserImpersonationManager._guidKey.ToString();
}

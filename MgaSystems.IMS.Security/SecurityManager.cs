// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.SecurityManager
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

public sealed class SecurityManager : ISecurityManager
{
  [ThreadStatic]
  private static SecurityManager _security;
  private static Guid _userGuid;
  private DateTime _enabledStateExpires;
  private Dictionary<string, SecurityManager.SecurityCookie> _securityAccessHash;
  private bool _notFirstSecurityHit;
  private DataTable _tblSecurityGroups;
  private DateTime _tblSecurityUserGroupExpires;
  private DataTable _tblSecurityUserGroups;
  private DataTable _tblSecurityUsersGroupsPermissions;
  private DateTime _tblSecurityUsersGroupsPermissionsExpires;

  private SecurityManager()
  {
    this._enabledStateExpires = DateTime.Now.AddSeconds(90.0);
    this._securityAccessHash = new Dictionary<string, SecurityManager.SecurityCookie>();
    this._tblSecurityUserGroupExpires = DateTime.Now.AddHours(2.0);
    this._tblSecurityUsersGroupsPermissionsExpires = DateTime.Now.AddHours(2.0);
  }

  [Obsolete]
  public static void Initialize(Control uiContext, Guid userGuid)
  {
    SecurityManager._userGuid = userGuid;
  }

  public static void Initialize(Guid userGuid) => SecurityManager._userGuid = userGuid;

  public static SecurityManager Instance
  {
    get
    {
      if (SecurityManager._security == null)
        SecurityManager._security = new SecurityManager();
      return SecurityManager._security;
    }
  }

  public void Reset() => this._securityAccessHash.Clear();

  public bool AssertPermissionWithPrompt(Guid resourceGuid)
  {
    return this.AssertPermissionWithPrompt(resourceGuid.ToString(), 0);
  }

  public bool AssertPermissionWithPrompt(string resourceGuid)
  {
    return this.AssertPermissionWithPrompt(resourceGuid, 0);
  }

  private bool AssertPermissionWithPrompt(string resourceGuid, int timeout)
  {
    bool flag = this.AssertPermission(resourceGuid, timeout);
    if (!flag)
    {
      FormSecurityPrompt formSecurityPrompt = new FormSecurityPrompt();
      if (formSecurityPrompt.ShowDialog() == DialogResult.OK && formSecurityPrompt.Username.Length > 0 && formSecurityPrompt.Password.Length > 0)
      {
        Guid userGuid = SecurityManager._userGuid;
        try
        {
          SecurityManager._userGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT UserGuid FROM tblUsers WHERE Username = @Username AND Password = @Password", new object[4]
          {
            (object) "@Username",
            (object) formSecurityPrompt.Username,
            (object) "@Password",
            (object) formSecurityPrompt.Password
          });
          flag = this.AssertPermission(resourceGuid, timeout);
        }
        finally
        {
          SecurityManager._userGuid = userGuid;
        }
      }
    }
    return flag;
  }

  [Obsolete("SecurityManager.Instance.AssertPermission() now supports caching, and should be used instead.")]
  public static void BeginAssertPermission(
    Control uiContext,
    Guid resourceGuid,
    AssertPermissionEventHandler assertPermissionHandler)
  {
    SecurityManager.Instance.AssertPermission(resourceGuid);
  }

  [Obsolete("SecurityManager.Instance.AssertPermission() now supports caching, and should be used instead.")]
  public static void BeginAssertPermission(
    Control uiContext,
    string resourceGuid,
    AssertPermissionEventHandler assertPermissionHandler)
  {
    SecurityManager.Instance.AssertPermission(resourceGuid);
  }

  [Obsolete("SecurityManager.Instance.AssertPermission() now supports caching, and should be used instead.")]
  public static void BeginAssertPermission(
    Control uiContext,
    Guid resourceGuid,
    int timeout,
    AssertPermissionEventHandler assertPermissionHandler)
  {
    SecurityManager.Instance.AssertPermission(resourceGuid, timeout);
  }

  [Obsolete("SecurityManager.Instance.AssertPermission() now supports caching, and should be used instead.")]
  public static void BeginAssertPermission(
    Control uiContext,
    string resourceGuid,
    int timeout,
    AssertPermissionEventHandler assertPermissionHandler)
  {
    SecurityManager.Instance.AssertPermission(resourceGuid, timeout);
  }

  public static void BeginAssertPermission(
    Control uiContext,
    AssertPermissionEventHandler assertPermissionHandler,
    params Guid[] resourceGuids)
  {
    SecurityManager.BeginAssertPermission(uiContext, 2, assertPermissionHandler, SecurityManager.ConvertGuidArrayToStringArray(resourceGuids));
  }

  public static void BeginAssertPermission(
    Control uiContext,
    AssertPermissionEventHandler assertPermissionHandler,
    params string[] resourceGuids)
  {
    SecurityManager.BeginAssertPermission(uiContext, 2, assertPermissionHandler, resourceGuids);
  }

  public static void BeginAssertPermission(
    Control uiContext,
    int timeout,
    AssertPermissionEventHandler assertPermissionHandler,
    params Guid[] resourceGuids)
  {
    SecurityManager.BeginAssertPermission(uiContext, timeout, assertPermissionHandler, SecurityManager.ConvertGuidArrayToStringArray(resourceGuids));
  }

  public static void BeginAssertPermission(
    Control uiContext,
    int timeout,
    AssertPermissionEventHandler assertPermissionHandler,
    params string[] resourceGuids)
  {
    new SecurityBackgroundThread(uiContext, timeout, SecurityManager._userGuid, assertPermissionHandler, resourceGuids).Start();
  }

  private static string[] ConvertGuidArrayToStringArray(params Guid[] resourceGuids)
  {
    string[] stringArray = new string[checked (resourceGuids.Length - 1 + 1)];
    int num = checked (resourceGuids.Length - 1);
    int index = 0;
    while (index <= num)
    {
      stringArray[index] = resourceGuids[index].ToString();
      checked { ++index; }
    }
    return stringArray;
  }

  public bool AssertPermission(Guid resourceGuid)
  {
    return this.AssertPermission(resourceGuid.ToString(), 120);
  }

  public bool AssertPermission(string resourceGuid) => this.AssertPermission(resourceGuid, 120);

  public bool AssertPermission(Guid resourceGuid, int timeout)
  {
    return this.AssertPermission(resourceGuid.ToString(), timeout);
  }

  public bool AssertPermission(string resourceGuid, int timeout)
  {
    if (timeout < 0 || timeout > 120)
      throw new ArgumentOutOfRangeException(nameof (timeout), (object) timeout, SR.GetString("ASSERT_TIMEOUT_INVALID"));
    bool flag;
    if (DateTime.Compare(DateTime.Now, this._enabledStateExpires) > 0)
    {
      this._enabledStateExpires = DateAndTime.Now.AddSeconds(90.0);
      if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsUserDisabled(@UserGuid)", new object[2]
      {
        (object) "@UserGuid",
        (object) SecurityManager._userGuid
      }))
      {
        flag = false;
        goto label_12;
      }
    }
    if (this._securityAccessHash.ContainsKey(resourceGuid))
    {
      SecurityManager.SecurityCookie securityCookie = this._securityAccessHash[resourceGuid];
      if (securityCookie.Expired)
      {
        this._securityAccessHash.Remove(resourceGuid);
      }
      else
      {
        flag = securityCookie.Granted;
        goto label_12;
      }
    }
    bool granted = this.ValidateUserPermission(new Guid(resourceGuid));
    if (timeout > 0)
      this._securityAccessHash.Add(resourceGuid, new SecurityManager.SecurityCookie(granted, timeout));
    flag = granted;
label_12:
    return flag;
  }

  public bool IsPermissionDenied(string resourceGuid) => this.IsPermissionDenied(resourceGuid, 120);

  public bool IsPermissionDenied(Guid resourceGuid)
  {
    return this.IsPermissionDenied(resourceGuid.ToString(), 120);
  }

  public bool IsPermissionDenied(string resourceGuid, int timeout)
  {
    DataRow[] dataRowArray1 = this.SecurityUsersGroupsPermissions.Select($"UserGuid = '{SecurityManager._userGuid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 0");
    bool flag;
    if (dataRowArray1 != null && dataRowArray1.Length > 0)
    {
      flag = true;
    }
    else
    {
      DataRow[] dataRowArray2 = this.SecurityUsersGroupsPermissions.Select($"UserGuid = '{SecurityManager._userGuid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 1");
      if (dataRowArray2 != null && dataRowArray2.Length > 0)
      {
        flag = false;
      }
      else
      {
        DataRow[] dataRowArray3 = this.SecurityUserGroups.Select($"UserGuid = '{SecurityManager._userGuid.ToString()}'");
        if (dataRowArray3 != null && dataRowArray3.Length > 0)
        {
          DataRow[] dataRowArray4 = dataRowArray3;
          int index1 = 0;
          while (index1 < dataRowArray4.Length)
          {
            DataRow[] dataRowArray5 = this.SecurityUsersGroupsPermissions.Select($"GroupGuid = '{((Guid) dataRowArray4[index1]["GroupGuid"]).ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 1");
            if (dataRowArray5 != null && dataRowArray5.Length > 0)
            {
              flag = false;
              goto label_19;
            }
            checked { ++index1; }
          }
          DataRow[] dataRowArray6 = dataRowArray3;
          int index2 = 0;
          while (index2 < dataRowArray6.Length)
          {
            DataRow[] dataRowArray7 = this.SecurityUsersGroupsPermissions.Select($"GroupGuid = '{((Guid) dataRowArray6[index2]["GroupGuid"]).ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 0");
            if (dataRowArray7 != null && dataRowArray7.Length > 0)
            {
              flag = true;
              goto label_19;
            }
            checked { ++index2; }
          }
        }
        Guid? groupGuid = this.GetGroupGuid("Everyone");
        if (groupGuid.HasValue)
        {
          DataRow[] dataRowArray8 = this.SecurityUsersGroupsPermissions.Select($"GroupGuid = '{groupGuid.Value.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 0");
          if (dataRowArray8 != null && dataRowArray8.Length > 0)
          {
            flag = true;
            goto label_19;
          }
        }
        flag = false;
      }
    }
label_19:
    return flag;
  }

  private DataTable SecurityUsersGroupsPermissions
  {
    get
    {
      if (this._tblSecurityUsersGroupsPermissions == null || DateTime.Compare(DateTime.Now, this._tblSecurityUsersGroupsPermissionsExpires) > 0)
      {
        this._tblSecurityUsersGroupsPermissions = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select * from tblSecurityUsersGroupsPermissions");
        this._tblSecurityUsersGroupsPermissionsExpires = DateTime.Now.AddHours(2.0);
      }
      return this._tblSecurityUsersGroupsPermissions;
    }
  }

  private DataTable SecurityUserGroups
  {
    get
    {
      if (this._tblSecurityUserGroups == null || DateTime.Compare(DateTime.Now, this._tblSecurityUserGroupExpires) > 0)
      {
        this._tblSecurityUserGroups = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select * from tblSecurityUserGroups");
        this._tblSecurityUserGroupExpires = DateTime.Now.AddHours(2.0);
      }
      return this._tblSecurityUserGroups;
    }
  }

  private DataTable SecurityGroups
  {
    get
    {
      if (this._tblSecurityGroups == null)
        this._tblSecurityGroups = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select * from tblSecurityGroups");
      return this._tblSecurityGroups;
    }
  }

  private Guid? GetGroupGuid(string groupName)
  {
    DataRow[] dataRowArray = this.SecurityGroups.Select($"Name = '{groupName}'");
    Guid? groupGuid;
    if (dataRowArray != null && dataRowArray.Length == 1)
      groupGuid = new Guid?((Guid) dataRowArray[0]["GroupGuid"]);
    return groupGuid;
  }

  private bool ValidateUserPermission(Guid resourceGuid)
  {
    bool flag;
    if (this._notFirstSecurityHit)
    {
      Guid? groupGuid1 = this.GetGroupGuid("Administrators");
      Guid guid;
      if (groupGuid1.HasValue)
      {
        DataTable securityUserGroups = this.SecurityUserGroups;
        string str1 = SecurityManager._userGuid.ToString();
        guid = groupGuid1.Value;
        string str2 = guid.ToString();
        string filterExpression = $"UserGuid = '{str1}' and GroupGuid = '{str2}'";
        if (securityUserGroups.Select(filterExpression).Length > 0)
        {
          flag = true;
          goto label_24;
        }
      }
      DataRow[] dataRowArray1 = this.SecurityUsersGroupsPermissions.Select($"UserGuid = '{SecurityManager._userGuid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 0");
      if (dataRowArray1 != null && dataRowArray1.Length > 0)
      {
        flag = false;
      }
      else
      {
        DataRow[] dataRowArray2 = this.SecurityUsersGroupsPermissions.Select($"UserGuid = '{SecurityManager._userGuid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 1");
        if (dataRowArray2 != null && dataRowArray2.Length > 0)
        {
          flag = true;
        }
        else
        {
          DataRow[] dataRowArray3 = this.SecurityUserGroups.Select($"UserGuid = '{SecurityManager._userGuid.ToString()}'");
          if (dataRowArray3 != null && dataRowArray3.Length > 0)
          {
            DataRow[] dataRowArray4 = dataRowArray3;
            int index1 = 0;
            while (index1 < dataRowArray4.Length)
            {
              DataRow dataRow = dataRowArray4[index1];
              DataTable groupsPermissions = this.SecurityUsersGroupsPermissions;
              guid = (Guid) dataRow["GroupGuid"];
              string filterExpression = $"GroupGuid = '{guid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 0";
              DataRow[] dataRowArray5 = groupsPermissions.Select(filterExpression);
              if (dataRowArray5 != null && dataRowArray5.Length > 0)
              {
                flag = false;
                goto label_24;
              }
              checked { ++index1; }
            }
            DataRow[] dataRowArray6 = dataRowArray3;
            int index2 = 0;
            while (index2 < dataRowArray6.Length)
            {
              DataRow dataRow = dataRowArray6[index2];
              DataTable groupsPermissions = this.SecurityUsersGroupsPermissions;
              guid = (Guid) dataRow["GroupGuid"];
              string filterExpression = $"GroupGuid = '{guid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 1";
              DataRow[] dataRowArray7 = groupsPermissions.Select(filterExpression);
              if (dataRowArray7 != null && dataRowArray7.Length > 0)
              {
                flag = true;
                goto label_24;
              }
              checked { ++index2; }
            }
          }
          Guid? groupGuid2 = this.GetGroupGuid("Everyone");
          if (groupGuid2.HasValue)
          {
            DataTable groupsPermissions = this.SecurityUsersGroupsPermissions;
            guid = groupGuid2.Value;
            string filterExpression = $"GroupGuid = '{guid.ToString()}' and ResourceGuid = '{resourceGuid.ToString()}' and PermissionBits = 1";
            DataRow[] dataRowArray8 = groupsPermissions.Select(filterExpression);
            if (dataRowArray8 != null && dataRowArray8.Length > 0)
            {
              flag = true;
              goto label_24;
            }
          }
          flag = false;
        }
      }
    }
    else
    {
      this._notFirstSecurityHit = true;
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(nameof (ValidateUserPermission), new object[4]
      {
        (object) "@UserGuid",
        (object) SecurityManager._userGuid,
        (object) "@ResourceGuid",
        (object) resourceGuid
      }));
      flag = objectValue != null && Conversions.ToBoolean(objectValue);
    }
label_24:
    return flag;
  }

  internal sealed class SecurityCookie
  {
    private bool _granted;
    private DateTime _createdTime;
    private int _timeout;

    public SecurityCookie(bool granted, int timeout)
    {
      this._granted = granted;
      this._timeout = timeout;
      this._createdTime = DateAndTime.Now;
    }

    public bool Granted => this._granted;

    public bool Expired
    {
      get
      {
        return this._timeout == 0 || DateAndTime.DateDiff(DateInterval.Minute, this._createdTime, DateAndTime.Now) >= (long) this._timeout;
      }
    }
  }
}

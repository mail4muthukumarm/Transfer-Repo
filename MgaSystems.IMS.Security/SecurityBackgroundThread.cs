// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.SecurityBackgroundThread
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
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

public class SecurityBackgroundThread
{
  private AssertPermissionEventHandler _assertPermissionEventHandler;
  private Control _uiContext;
  private List<string> _resourceGuidList;
  private Guid _userGuid;
  private DateTime _enabledStateLastChecked;
  private Dictionary<string, SecurityManager.SecurityCookie> _securityAccessHash;
  private int _timeout;

  public SecurityBackgroundThread(
    Control uiContext,
    int timeout,
    Guid userGuid,
    AssertPermissionEventHandler securityBackgroundThreadCompletedHandler,
    params string[] resourceGuids)
  {
    this._resourceGuidList = new List<string>();
    this._enabledStateLastChecked = DateTime.MinValue;
    this._securityAccessHash = new Dictionary<string, SecurityManager.SecurityCookie>();
    this._assertPermissionEventHandler = securityBackgroundThreadCompletedHandler;
    this._uiContext = uiContext;
    this._userGuid = userGuid;
    this._resourceGuidList.AddRange((IEnumerable<string>) resourceGuids);
    this._timeout = timeout;
  }

  public void Start()
  {
    new Thread(new ThreadStart(this.BackgroundProc))
    {
      Name = nameof (SecurityBackgroundThread)
    }.Start();
  }

  private void BackgroundProc()
  {
    try
    {
      foreach (string resourceGuid in this._resourceGuidList)
      {
        bool granted = this.AssertPermission(resourceGuid, this._timeout);
        if (!this._uiContext.IsDisposed && this._uiContext.IsHandleCreated)
        {
          if (this._uiContext.InvokeRequired)
          {
            try
            {
              this._uiContext.Invoke((Delegate) new SecurityBackgroundThread.CompletedHandler(this.UIPermissionAccessResolved), (object) resourceGuid, (object) granted);
            }
            catch (ObjectDisposedException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
          }
          else
            this.UIPermissionAccessResolved(resourceGuid, granted);
        }
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this._resourceGuidList.Clear();
  }

  private bool AssertPermission(string resourceGuid, int timeout)
  {
    if (timeout < 0 || timeout > 120)
      throw new ArgumentOutOfRangeException(nameof (timeout), (object) timeout, SR.GetString("ASSERT_TIMEOUT_INVALID"));
    bool flag;
    if (this._enabledStateLastChecked.Equals(DateTime.MinValue) || this._enabledStateLastChecked.Subtract(DateAndTime.Now).Seconds > 90)
    {
      this._enabledStateLastChecked = DateAndTime.Now;
      if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsUserDisabled(@UserGuid)", new object[2]
      {
        (object) "@UserGuid",
        (object) this._userGuid
      }))
      {
        flag = false;
        goto label_14;
      }
    }
    if (this._securityAccessHash.ContainsKey(resourceGuid))
    {
      SecurityManager.SecurityCookie securityCookie = this._securityAccessHash[resourceGuid];
      if (securityCookie.Expired)
      {
        this._securityAccessHash.Remove(resourceGuid);
        flag = this.AssertPermission(resourceGuid, timeout);
      }
      else
        flag = securityCookie.Granted;
    }
    else
    {
      bool boolean = Conversions.ToBoolean((object) this.ValidateUserPermission(new Guid(resourceGuid)) ?? throw new SecurityException("Error obtaining permission information for this user"));
      if (timeout > 0)
        this._securityAccessHash.Add(resourceGuid, new SecurityManager.SecurityCookie(boolean, timeout));
      flag = boolean;
    }
label_14:
    return flag;
  }

  private void UIPermissionAccessResolved(string resourceGuid, bool granted)
  {
    if (this._assertPermissionEventHandler == null)
      return;
    try
    {
      this._assertPermissionEventHandler((object) this, new AssertPermissionEventArgs(new Guid(resourceGuid), granted));
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private bool ValidateUserPermission(Guid resourceGuid)
  {
    return DefaultDatabase.ExecuteScalar<bool>(nameof (ValidateUserPermission), new object[4]
    {
      (object) "@UserGuid",
      (object) this._userGuid,
      (object) "@ResourceGuid",
      (object) resourceGuid
    });
  }

  private delegate void CompletedHandler(string resourceGuid, bool granted);
}

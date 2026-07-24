// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ConcurrencyManager
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Enums;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class ConcurrencyManager
{
  private static Dictionary<object, int> _lockedObjects = new Dictionary<object, int>();

  public static void ReleaseLock(IConcurrentObject objectToLock)
  {
    if (objectToLock == null)
      throw new ArgumentNullException(nameof (objectToLock));
    if (!ConcurrencyManager._lockedObjects.ContainsKey((object) objectToLock))
      throw new ArgumentNullException(nameof (objectToLock), "No local record of locked object");
    ConcurrencyManager.ReleaseLock(ConcurrencyManager._lockedObjects[(object) objectToLock]);
    ConcurrencyManager._lockedObjects.Remove((object) objectToLock);
  }

  public static void ReleaseLock(int lockId)
  {
    DefaultDatabase.ExecuteNonQuery("UserObjectLockUnRegister", new object[2]
    {
      (object) "@objectLockId",
      (object) lockId
    });
  }

  public static bool RegisterLock(
    IConcurrentObject objectToLock,
    ConcurrencyLockManagementType lockManagementType)
  {
    if (objectToLock == null)
      throw new ArgumentNullException(nameof (objectToLock));
    bool flag;
    if (string.IsNullOrEmpty(objectToLock.DataKey))
    {
      flag = false;
    }
    else
    {
      if (lockManagementType == ConcurrencyLockManagementType.ReleaseOnFormClose)
      {
        if (!(objectToLock is Form form))
          throw new ArgumentNullException(nameof (objectToLock), "objectToLock must derive from Form if using ConcurrencyLockManagementType.ReleaseOnFormClose");
        form.FormClosed += new FormClosedEventHandler(ConcurrencyManager.formToMonitor_FormClosed);
      }
      if (!ConcurrencyManager._lockedObjects.ContainsKey((object) objectToLock))
        DefaultDatabase.ExecuteTransaction(IsolationLevel.Serializable, new EventHandler<ExecuteTransactionEventArgs>(ConcurrencyManager.RegisterLockTransaction), (object) objectToLock);
      flag = ConcurrencyManager._lockedObjects.ContainsKey((object) objectToLock);
    }
    return flag;
  }

  private static void formToMonitor_FormClosed(object sender, FormClosedEventArgs e)
  {
    ((Form) sender).FormClosed -= new FormClosedEventHandler(ConcurrencyManager.formToMonitor_FormClosed);
    ConcurrencyManager.ReleaseLock((IConcurrentObject) sender);
  }

  private static void RegisterLockTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    IConcurrentObject context = (IConcurrentObject) e.Context;
    ObjectLockInfo objectLockedInfo = ConcurrencyManager.GetObjectLockedInfo(context);
    if (objectLockedInfo == null)
    {
      int int32 = Decimal.ToInt32(Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("UserObjectLockRegister", new object[8]
      {
        (object) "@objectType",
        (object) context.GetType().FullName,
        (object) "@objectDataKey",
        (object) context.DataKey,
        (object) "@objectLockDescription",
        (object) context.LockDescription,
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID
      })), -1M));
      if (int32 == -1)
        throw new InvalidOperationException();
      e.Transaction.Commit();
      ConcurrencyManager._lockedObjects.Add((object) context, int32);
    }
    else
    {
      if (!(objectLockedInfo.UserGuid == CurrentUser.Instance.UserGUID))
        return;
      if (objectLockedInfo.LockId == -1)
        throw new InvalidOperationException();
      ConcurrencyManager._lockedObjects.Add((object) context, objectLockedInfo.LockId);
    }
  }

  public static ObjectLockInfo GetObjectLockedInfo(IConcurrentObject objectToLock)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("UserObjectLockInfo", new object[4]
    {
      (object) "@objectType",
      (object) objectToLock.GetType().FullName,
      (object) "@objectDataKey",
      (object) objectToLock.DataKey
    });
    return dataRow == null || dataRow.IsNull("ObjectLockId") ? (ObjectLockInfo) null : new ObjectLockInfo((int) dataRow["ObjectLockId"], (string) dataRow["ObjectLockDescription"], (Guid) dataRow["UserGuid"], (DateTime) dataRow["ObjectLockCreated"]);
  }

  public static bool IsObjectLocked(IConcurrentObject objectToLock)
  {
    if (objectToLock == null)
      throw new ArgumentNullException(nameof (objectToLock));
    return ConcurrencyManager.GetObjectLockedInfo(objectToLock) != null;
  }

  public static void ClearUserObjectLocks()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "delete from tblUserObjectLocks where UserGuid = @userGuid", new object[2]
    {
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }
}

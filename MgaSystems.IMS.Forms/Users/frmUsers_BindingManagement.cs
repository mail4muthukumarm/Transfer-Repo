// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmUsers_BindingManagement
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Users;

public class frmUsers_BindingManagement : IDisposable
{
  private BindingContext _bindingContext;
  private DataSet _dataSet;

  public frmUsers_BindingManagement(DataSet dataSet, BindingContext bindingContext)
  {
    this._bindingContext = bindingContext;
    this._dataSet = dataSet;
  }

  public virtual BindingManagerBase BindingMngrtblUsers
  {
    get => this._bindingContext[(object) this._dataSet, "tblUsers"];
  }

  public virtual bool IsCurrentBindingMngrtblUsersNotNull
  {
    get => this.BindingMngrtblUsers.Current != null;
  }

  public virtual dsUser.tblUsersRow CurrenttblUsers
  {
    get
    {
      return !this.IsCurrentBindingMngrtblUsersNotNull ? (dsUser.tblUsersRow) null : (dsUser.tblUsersRow) ((DataRowView) this.BindingMngrtblUsers.Current).Row;
    }
  }

  public virtual void Dispose()
  {
    this._bindingContext = (BindingContext) null;
    this._dataSet = (DataSet) null;
  }

  public virtual int SetBindingMngrPosFromValue(
    BindingManagerBase bindingManager,
    string tableName,
    string fieldName,
    object searchValue)
  {
    if (bindingManager == null)
      throw new ArgumentNullException(nameof (bindingManager));
    DataTable table = this._dataSet.Tables[tableName];
    int num;
    for (int index = 0; index < table.Rows.Count; ++index)
    {
      if (table.Rows[index].RowState != DataRowState.Deleted && table.Rows[index][fieldName].Equals(RuntimeHelpers.GetObjectValue(searchValue)))
      {
        bindingManager.Position = index;
        num = bindingManager.Position;
        goto label_8;
      }
    }
    num = -1;
label_8:
    return num;
  }

  public virtual int SetBindingMngrtblUsersPosFromValue(string fieldName, object searchValue)
  {
    return this.SetBindingMngrPosFromValue(this.BindingMngrtblUsers, "tblUsers", fieldName, RuntimeHelpers.GetObjectValue(searchValue));
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Cancellations.Notices.frmNOC_BindingManagement
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Cancellations.Notices;

public class frmNOC_BindingManagement : IDisposable
{
  private BindingContext _bindingContext;
  private DataSet _dataSet;

  public frmNOC_BindingManagement(DataSet dataSet, BindingContext bindingContext)
  {
    this._bindingContext = bindingContext;
    this._dataSet = dataSet;
  }

  public virtual BindingManagerBase BindingMngrlstPolicyCancellationNoticeTypes
  {
    get => this._bindingContext[(object) this._dataSet, "lstPolicyCancellationNoticeTypes"];
  }

  public virtual bool IsCurrentBindingMngrlstPolicyCancellationNoticeTypesNotNull
  {
    get => this.BindingMngrlstPolicyCancellationNoticeTypes.Current != null;
  }

  public virtual dsNOC.lstPolicyCancellationNoticeTypesRow CurrentlstPolicyCancellationNoticeTypes
  {
    get
    {
      return !this.IsCurrentBindingMngrlstPolicyCancellationNoticeTypesNotNull ? (dsNOC.lstPolicyCancellationNoticeTypesRow) null : (dsNOC.lstPolicyCancellationNoticeTypesRow) ((DataRowView) this.BindingMngrlstPolicyCancellationNoticeTypes.Current).Row;
    }
  }

  public virtual BindingManagerBase BindingMngrlstQuoteStatusReasons
  {
    get => this._bindingContext[(object) this._dataSet, "lstQuoteStatusReasons"];
  }

  public virtual bool IsCurrentBindingMngrlstQuoteStatusReasonsNotNull
  {
    get => this.BindingMngrlstQuoteStatusReasons.Current != null;
  }

  public virtual dsNOC.lstQuoteStatusReasonsRow CurrentlstQuoteStatusReasons
  {
    get
    {
      return !this.IsCurrentBindingMngrlstQuoteStatusReasonsNotNull ? (dsNOC.lstQuoteStatusReasonsRow) null : (dsNOC.lstQuoteStatusReasonsRow) ((DataRowView) this.BindingMngrlstQuoteStatusReasons.Current).Row;
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
    int index;
    int num;
    for (DataTable table = this._dataSet.Tables[tableName]; index < table.Rows.Count; ++index)
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

  public virtual int SetBindingMngrlstPolicyCancellationNoticeTypesPosFromValue(
    string fieldName,
    object searchValue)
  {
    return this.SetBindingMngrPosFromValue(this.BindingMngrlstPolicyCancellationNoticeTypes, "lstPolicyCancellationNoticeTypes", fieldName, RuntimeHelpers.GetObjectValue(searchValue));
  }

  public virtual int SetBindingMngrlstQuoteStatusReasonsPosFromValue(
    string fieldName,
    object searchValue)
  {
    return this.SetBindingMngrPosFromValue(this.BindingMngrlstQuoteStatusReasons, "lstQuoteStatusReasons", fieldName, RuntimeHelpers.GetObjectValue(searchValue));
  }
}

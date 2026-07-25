// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StatusMemberUITypeEditor
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

#nullable disable
namespace MGASystems.Tools;

[SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
public class StatusMemberUITypeEditor : UITypeEditor, IDisposable
{
  private IWindowsFormsEditorService edSvc;
  private ListBox _dropDownList;

  protected virtual void LoadListBox(
    Component control,
    ITypeDescriptorContext context,
    ListBox listbox)
  {
    PropertyInfo property = control.GetType().GetProperty("DataSource", BindingFlags.Instance | BindingFlags.Public);
    if ((object) property == null)
      return;
    switch (RuntimeHelpers.GetObjectValue(property.GetValue((object) control, (object[]) null)))
    {
      case DataTable tbl:
        StatusMemberUITypeEditor.FillListBox(tbl, listbox);
        break;
      case DataView dataView:
        StatusMemberUITypeEditor.FillListBox(dataView.Table, listbox);
        break;
    }
  }

  private static void FillListBox(DataTable tbl, ListBox lb)
  {
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) tbl.Columns)
      {
        if (column.DataType.Equals(typeof (int)) || column.DataType.Equals(typeof (long)) || column.DataType.Equals(typeof (byte)))
          lb.Items.Add((object) column.ColumnName);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private ListBox DropDownListBox
  {
    get
    {
      if (this._dropDownList == null)
      {
        this._dropDownList = new ListBox();
        this._dropDownList.BorderStyle = BorderStyle.None;
        this._dropDownList.Click += new EventHandler(this.OnListClick);
      }
      return this._dropDownList;
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")]
  public override object EditValue(
    ITypeDescriptorContext context,
    IServiceProvider provider,
    object value)
  {
    object obj;
    if (context == null | provider == null)
    {
      obj = value;
    }
    else
    {
      IDesignerHost designerHostService = this.GetDesignerHostService(context, provider);
      Control componentBeingEdited = (Control) this.GetComponentBeingEdited(context, provider);
      if (componentBeingEdited != null & designerHostService != null)
      {
        this.edSvc = (IWindowsFormsEditorService) provider.GetService(typeof (IWindowsFormsEditorService));
        if (this.edSvc != null)
        {
          ListBox dropDownListBox = this.DropDownListBox;
          dropDownListBox.Items.Clear();
          this.LoadListBox((Component) componentBeingEdited, context, dropDownListBox);
          dropDownListBox.Sorted = true;
          dropDownListBox.Sorted = false;
          dropDownListBox.Items.Insert(0, (object) "(none)");
          dropDownListBox.Height = dropDownListBox.PreferredHeight;
          this.edSvc.DropDownControl((Control) dropDownListBox);
          if (dropDownListBox.SelectedItem != null)
            value = (object) dropDownListBox.SelectedItem.ToString();
          obj = value;
          goto label_8;
        }
      }
      obj = (object) null;
    }
label_8:
    return obj;
  }

  public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
  {
    return UITypeEditorEditStyle.DropDown;
  }

  protected virtual IDesignerHost GetDesignerHostService(
    ITypeDescriptorContext context,
    IServiceProvider provider)
  {
    IDesignerHost designerHostService = (IDesignerHost) null;
    if (provider != null)
      designerHostService = (IDesignerHost) provider.GetService(typeof (IDesignerHost));
    return designerHostService;
  }

  protected virtual Component GetComponentBeingEdited(
    ITypeDescriptorContext context,
    IServiceProvider provider)
  {
    Component componentBeingEdited = (Component) null;
    if (context != null)
      componentBeingEdited = (Component) context.Instance;
    return componentBeingEdited;
  }

  private void OnListClick(object sender, EventArgs e)
  {
    if (this.edSvc == null)
      return;
    this.edSvc.CloseDropDown();
  }

  [SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
  public void Dispose()
  {
    GC.SuppressFinalize((object) this);
    this.CleanUp();
  }

  private void CleanUp()
  {
    if (this._dropDownList == null)
      return;
    this._dropDownList.Click -= new EventHandler(this.OnListClick);
    this._dropDownList.Dispose();
    this._dropDownList = (ListBox) null;
  }

  [SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
  ~StatusMemberUITypeEditor()
  {
    this.CleanUp();
    // ISSUE: explicit finalizer call
    base.Finalize();
  }
}

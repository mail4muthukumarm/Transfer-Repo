// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ListTypeUIEditor
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

#nullable disable
namespace MGASystems.Tools;

public class ListTypeUIEditor : UITypeEditor
{
  private IWindowsFormsEditorService edSvc;

  protected virtual void LoadListBox(
    Component control,
    ITypeDescriptorContext context,
    ListBox listbox)
  {
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
          ListBox listbox = new ListBox();
          listbox.BorderStyle = BorderStyle.None;
          listbox.Click += new EventHandler(this.OnListClick);
          this.LoadListBox((Component) componentBeingEdited, context, listbox);
          listbox.Sorted = true;
          listbox.Sorted = false;
          listbox.Items.Insert(0, (object) string.Empty);
          if (listbox.PreferredHeight < listbox.Height)
            listbox.Height = listbox.PreferredHeight;
          this.edSvc.DropDownControl((Control) listbox);
          if (listbox.SelectedItem != null)
            value = (object) listbox.SelectedItem.ToString();
          listbox.Click -= new EventHandler(this.OnListClick);
          listbox.Dispose();
          obj = value;
          goto label_10;
        }
      }
      obj = (object) null;
    }
label_10:
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
}

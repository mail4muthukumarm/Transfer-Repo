// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.FieldToValidateUITypeEditor
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;

#nullable disable
namespace MGASystems.Tools;

public sealed class FieldToValidateUITypeEditor : UITypeEditor, IDisposable
{
  private IWindowsFormsEditorService _editorService;
  private ITypeDescriptorContext _context;
  private ListBox _listBox;
  private Control _lastControl;

  private ListBox DropDown
  {
    get
    {
      if (this._listBox == null)
      {
        this._listBox = new ListBox();
        this._listBox.BorderStyle = BorderStyle.None;
        this._listBox.Sorted = true;
      }
      return this._listBox;
    }
  }

  [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "lb")]
  private void InitializeDropDown(ListBox lb)
  {
    if (this._editorService == null || this._context == null || this._context.Instance == null || !(this._context.Instance is ValidatorBase))
      return;
    ValidatorBase instance = (ValidatorBase) this._context.Instance;
    if (instance.ControlToValidate == null || this._lastControl == instance.ControlToValidate)
      return;
    this.DropDown.Items.Clear();
    PropertyInfo[] properties = instance.ControlToValidate.GetType().GetProperties();
    int index1 = 0;
    while (index1 < properties.Length)
    {
      PropertyInfo propertyInfo = properties[index1];
      Type[] fieldToValidateTypes = instance.GetAcceptableFieldToValidateTypes();
      int index2 = 0;
      while (index2 < fieldToValidateTypes.Length)
      {
        if (fieldToValidateTypes[index2].Equals(propertyInfo.PropertyType))
          this.DropDown.Items.Add((object) propertyInfo.Name);
        checked { ++index2; }
      }
      checked { ++index1; }
    }
  }

  public override object EditValue(
    ITypeDescriptorContext context,
    IServiceProvider provider,
    object value)
  {
    if (provider == null)
      throw new ArgumentNullException(nameof (provider));
    object obj;
    if (context != null && context.Instance != null && provider != null)
    {
      this._context = context;
      this._editorService = (IWindowsFormsEditorService) provider.GetService(typeof (IWindowsFormsEditorService));
      if (this._editorService != null)
      {
        this.InitializeDropDown(this.DropDown);
        if (this.DropDown.Items.Count > 0)
        {
          this.DropDown.Click += new EventHandler(this.FieldToValidate_Listbox_Click);
          this._editorService.DropDownControl((Control) this.DropDown);
          obj = (object) this.DropDown.SelectedItem.ToString();
          goto label_8;
        }
        obj = (object) null;
        goto label_8;
      }
    }
    obj = (object) null;
label_8:
    return obj;
  }

  private void FieldToValidate_Listbox_Click(object sender, EventArgs e)
  {
    ((ListBox) sender).Click -= new EventHandler(this.FieldToValidate_Listbox_Click);
    if (this._editorService == null)
      return;
    this._editorService.CloseDropDown();
  }

  [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
  public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
  {
    if (context == null)
      throw new ArgumentNullException(nameof (context));
    return context.Instance == null ? base.GetEditStyle(context) : UITypeEditorEditStyle.DropDown;
  }

  public void Dispose()
  {
    if (this._listBox == null)
      return;
    this._listBox.Dispose();
  }
}

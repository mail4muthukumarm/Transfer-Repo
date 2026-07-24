// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.ExtendedControls.DragDropOutlookExtender
// Assembly: MGASystems.IMS.ExtendedControls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 933BCBB6-80B3-406B-A226-C528DBCF94BC
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.ExtendedControls.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.ExtendedControls;

[ToolboxBitmap(typeof (DragDropOutlookExtender), "MGASystems.IMS.ExtendedControls.DragDropOutlookExtender.bmp")]
[DefaultProperty("DropTarget")]
public class DragDropOutlookExtender : Component, ICustomDropTargetHandler
{
  private unsafe MGASystems.IMS.ExtendedControls.DropHelper* pFileDropHelper = (MGASystems.IMS.ExtendedControls.DropHelper*) 0;
  private DataObject activeDragItem = (DataObject) null;
  private bool oleInitialized;
  private Control control = (Control) null;
  private System.ComponentModel.Container components = (System.ComponentModel.Container) null;
  private EventHandler parentForm_closingHandler = (EventHandler) null;

  public DragDropOutlookExtender(IContainer container)
  {
    // ISSUE: fault handler
    try
    {
      container.Add((IComponent) this);
      this.InitializeComponent();
    }
    __fault
    {
      base.Dispose(true);
    }
  }

  public DragDropOutlookExtender()
  {
    // ISSUE: fault handler
    try
    {
      this.InitializeComponent();
    }
    __fault
    {
      base.Dispose(true);
    }
  }

  [EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted = true)]
  private void \u007EDragDropOutlookExtender()
  {
    this.components?.Dispose();
    this.CleanUpUnManaged();
    \u003CModule\u003E.OleUninitialize();
  }

  private void InitializeComponent() => this.components = new System.ComponentModel.Container();

  [Category("Behavior")]
  [Description("The control which will have it's Drop extended to accomodate outlook items.")]
  public unsafe Control DropTarget
  {
    get => this.control;
    set
    {
      if (!this.DesignMode && value != this.control)
      {
        if (!this.oleInitialized)
        {
          this.oleInitialized = true;
          \u003CModule\u003E.OleInitialize((void*) 0);
        }
        Control control = this.control;
        if (control != null)
        {
          this.DetachFormClosed(control);
          \u003CModule\u003E.RevokeDragDrop((HWND__*) this.control.Handle.ToInt32());
        }
        this.control = value;
        if (value == null)
          return;
        if (value.AllowDrop)
          this.control.AllowDrop = false;
        int num = \u003CModule\u003E.RegisterDragDrop((HWND__*) this.control.Handle.ToInt32(), (IDropTarget*) this.DropHelper);
        if (num >= 0)
          return;
        if (num != -2147221247)
          throw new InvalidOperationException("Unable to RegisterDragDrop");
        DragDropOutlookExtender dropOutlookExtender = this;
        dropOutlookExtender.AttachFormClosed(dropOutlookExtender.control);
      }
      else
        this.control = value;
    }
  }

  private EventHandler ParentFormClosedEventHandler
  {
    get
    {
      if (this.parentForm_closingHandler == null)
      {
        DragDropOutlookExtender dropOutlookExtender = this;
        dropOutlookExtender.parentForm_closingHandler = new EventHandler(dropOutlookExtender.ParentForm_Closed);
      }
      return this.parentForm_closingHandler;
    }
  }

  private void AttachFormClosed(Control control)
  {
    if (control == null)
      return;
    this.control.FindForm().Closed += this.ParentFormClosedEventHandler;
  }

  private void DetachFormClosed(Control controlToDetach)
  {
    if (controlToDetach == null)
      return;
    controlToDetach.FindForm().Closed -= this.ParentFormClosedEventHandler;
  }

  private unsafe void ParentForm_Closed(object sender, EventArgs e)
  {
    try
    {
      ((Form) sender).Closed -= this.ParentFormClosedEventHandler;
      Control control = this.control;
      if (control == null || !control.IsHandleCreated)
        return;
      \u003CModule\u003E.RevokeDragDrop((HWND__*) this.control.Handle.ToInt32());
    }
    catch (InvalidCastException ex)
    {
    }
  }

  [return: MarshalAs(UnmanagedType.U1)]
  private bool ShouldSerializeDropTarget() => this.control != null;

  private void ResetDropTarget() => this.control = (Control) null;

  private unsafe MGASystems.IMS.ExtendedControls.DropHelper* DropHelper
  {
    get
    {
      if ((IntPtr) this.pFileDropHelper == IntPtr.Zero)
      {
        MGASystems.IMS.ExtendedControls.DropHelper* dropHelperPtr1 = (MGASystems.IMS.ExtendedControls.DropHelper*) \u003CModule\u003E.@new(12U);
        MGASystems.IMS.ExtendedControls.DropHelper* dropHelperPtr2;
        try
        {
          dropHelperPtr2 = (IntPtr) dropHelperPtr1 == IntPtr.Zero ? (MGASystems.IMS.ExtendedControls.DropHelper*) 0 : \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002E\u007Bctor\u007D(dropHelperPtr1, (ICustomDropTargetHandler) this);
        }
        __fault
        {
          \u003CModule\u003E.delete((void*) dropHelperPtr1);
        }
        this.pFileDropHelper = dropHelperPtr2;
      }
      return this.pFileDropHelper;
    }
  }

  [EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted = true)]
  private unsafe void CleanUpUnManaged()
  {
    MGASystems.IMS.ExtendedControls.DropHelper* pFileDropHelper = this.pFileDropHelper;
    if ((IntPtr) pFileDropHelper != IntPtr.Zero)
    {
      MGASystems.IMS.ExtendedControls.DropHelper* dropHelperPtr = pFileDropHelper;
      gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* dropTargetHandlerPtr = (gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E*) ((IntPtr) dropHelperPtr + 8);
      ((GCHandle) new IntPtr((void*) *(int*) dropTargetHandlerPtr)).Free();
      *(int*) dropTargetHandlerPtr = 0;
      \u003CModule\u003E.delete((void*) dropHelperPtr);
      this.pFileDropHelper = (MGASystems.IMS.ExtendedControls.DropHelper*) 0;
    }
    if (this.DesignMode || this.control == null)
      return;
    this.control = (Control) null;
  }

  public virtual unsafe void OnDragEnter(
    IDataObject* pDataObj,
    uint grfKeyState,
    _POINTL pt,
    uint* pdwEffect)
  {
    DataObject dob = new DataObject(pDataObj);
    this.activeDragItem = dob;
    DragEventArgs dragEventArgs = DragDropOutlookExtender.CreateDragEventArgs(dob, (int) grfKeyState, pt, (int) *pdwEffect);
    DragDropOutlookExtender.InvokeDragEnter(this.control, dragEventArgs);
    *pdwEffect = (uint) dragEventArgs.Effect;
  }

  public virtual unsafe void OnDragOver(uint grfKeyState, _POINTL pt, uint* pdwEffect)
  {
    DragEventArgs dragEventArgs = DragDropOutlookExtender.CreateDragEventArgs(this.activeDragItem, (int) grfKeyState, pt, (int) *pdwEffect);
    DragDropOutlookExtender.InvokeDragOver(this.control, dragEventArgs);
    *pdwEffect = (uint) dragEventArgs.Effect;
  }

  public virtual void OnDragLeave() => DragDropOutlookExtender.InvokeDragLeave(this.control);

  public virtual unsafe void OnDrop(
    IDataObject* pDataObject,
    uint grfKeyState,
    _POINTL pt,
    uint* pdwEffect)
  {
    DragEventArgs dragEventArgs = DragDropOutlookExtender.CreateDragEventArgs(new DataObject(pDataObject), (int) grfKeyState, pt, (int) *pdwEffect);
    DragDropOutlookExtender.InvokeDragDrop(this.control, dragEventArgs);
    *pdwEffect = (uint) dragEventArgs.Effect;
  }

  private static unsafe DragEventArgs CreateDragEventArgs(
    DataObject dob,
    int grfKeyState,
    _POINTL pt,
    int effect)
  {
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    return new DragEventArgs((System.Windows.Forms.IDataObject) dob, grfKeyState, ^(int&) ref pt, ^(int&) ((IntPtr) &pt + 4), (DragDropEffects) effect, DragDropEffects.None);
  }

  private static void InvokeDragDrop(Control control, DragEventArgs e)
  {
    MethodInfo method = typeof (Control).GetMethod("OnDragDrop", BindingFlags.Instance | BindingFlags.NonPublic);
    object[] objArray = new object[1]{ (object) e };
    Control control1 = control;
    object[] parameters = objArray;
    method.Invoke((object) control1, parameters);
  }

  private static void InvokeDragOver(Control control, DragEventArgs e)
  {
    MethodInfo method = typeof (Control).GetMethod("OnDragOver", BindingFlags.Instance | BindingFlags.NonPublic);
    object[] objArray = new object[1]{ (object) e };
    Control control1 = control;
    object[] parameters = objArray;
    method.Invoke((object) control1, parameters);
  }

  private static void InvokeDragEnter(Control control, DragEventArgs e)
  {
    MethodInfo method = typeof (Control).GetMethod("OnDragEnter", BindingFlags.Instance | BindingFlags.NonPublic);
    object[] objArray = new object[1]{ (object) e };
    Control control1 = control;
    object[] parameters = objArray;
    method.Invoke((object) control1, parameters);
  }

  private static void InvokeDragLeave(Control control)
  {
    MethodInfo method = typeof (Control).GetMethod("OnDragLeave", BindingFlags.Instance | BindingFlags.NonPublic);
    object[] objArray = new object[1]{ (object) null };
    Control control1 = control;
    object[] parameters = objArray;
    method.Invoke((object) control1, parameters);
  }

  protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
  {
    if (_param1)
    {
      try
      {
        this.\u007EDragDropOutlookExtender();
      }
      finally
      {
        base.Dispose(true);
      }
    }
    else
      base.Dispose(false);
  }
}

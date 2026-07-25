// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.DragDrop.DragDropExtender
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using MGASystems.ExtendedEditors.ComTypes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.ExtendedEditors.DragDrop;

[ToolboxBitmap(typeof (ToolTip))]
[DefaultProperty("DropTarget")]
[DefaultEvent("DragDrop")]
public class DragDropExtender : Component, IOleDropTarget
{
  private Control control;
  private FileDropTarget fileDropTarget;
  private DragDropEffects lastEffect;
  private System.Windows.Forms.IDataObject lastDataObject;
  private IContainer components;

  private void ConnectDragDrop()
  {
    this.fileDropTarget = this.fileDropTarget == null ? new FileDropTarget((IOleDropTarget) this) : throw new InvalidOperationException("Cannot call ConnectDragDrop until you disconnect first");
    this.fileDropTarget.SetAcceptsDrops(this.control.Handle, true);
  }

  private void DisconnectDragDrop()
  {
    if (this.fileDropTarget == null)
      return;
    if (this.control != null && this.control.IsHandleCreated)
      this.fileDropTarget.SetAcceptsDrops(this.control.Handle, false);
    this.fileDropTarget = (FileDropTarget) null;
  }

  public DragDropExtender() => this.InitializeComponent();

  public DragDropExtender(IContainer container)
  {
    if (container == null)
      throw new ArgumentNullException(nameof (container));
    container.Add((IComponent) this);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.DisconnectDragDrop();
      this.control = (Control) null;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DefaultValue(null)]
  public Control DropTarget
  {
    get => this.control;
    set
    {
      if (!this.DesignMode && value != this.control)
      {
        if (this.control != null)
        {
          this.SetupFormClosedHandler(false);
          this.DisconnectDragDrop();
        }
        this.control = value;
        if (value == null)
          return;
        if (this.control.AllowDrop)
          this.control.AllowDrop = false;
        this.SetupFormClosedHandler(true);
        this.ConnectDragDrop();
      }
      else
        this.control = value;
    }
  }

  private void SetupFormClosedHandler(bool attach)
  {
    Form form = this.control.FindForm();
    if (form == null)
      return;
    if (attach)
      form.FormClosed += new FormClosedEventHandler(this.parentForm_FormClosed);
    else
      form.FormClosed -= new FormClosedEventHandler(this.parentForm_FormClosed);
  }

  private void parentForm_FormClosed(object sender, FormClosedEventArgs e)
  {
    if (this.control == null || !this.control.IsHandleCreated)
      return;
    this.SetupFormClosedHandler(false);
    this.DisconnectDragDrop();
  }

  private static int GetX(long pt) => (int) (pt & (long) uint.MaxValue);

  private static int GetY(long pt) => (int) (pt >> 32 /*0x20*/ & (long) uint.MaxValue);

  int IOleDropTarget.OleDragEnter(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
  {
    DragEventArgs dragEventArgs = this.CreateDragEventArgs(pDataObj, grfKeyState, new POINTL()
    {
      x = DragDropExtender.GetX(pt),
      y = DragDropExtender.GetY(pt)
    }, pdwEffect);
    if (dragEventArgs != null)
    {
      DragDropExtender.GetCursorScreenPosition();
      DragDropExtender.InvokeControlMethod(this.control, "OnDragEnter", (object) dragEventArgs);
      pdwEffect = (int) dragEventArgs.Effect;
      this.lastEffect = dragEventArgs.Effect;
    }
    else
      pdwEffect = 0;
    return 0;
  }

  private DragEventArgs CreateDragEventArgs(
    object pDataObj,
    int grfKeyState,
    POINTL pt,
    int pdwEffect)
  {
    System.Windows.Forms.IDataObject data;
    switch (pDataObj)
    {
      case null:
        data = this.lastDataObject;
        break;
      case System.Windows.Forms.IDataObject _:
        data = (System.Windows.Forms.IDataObject) pDataObj;
        break;
      case System.Runtime.InteropServices.ComTypes.IDataObject _:
        data = (System.Windows.Forms.IDataObject) new DataObject(pDataObj);
        break;
      default:
        return (DragEventArgs) null;
    }
    DragEventArgs dragEventArgs = new DragEventArgs(data, grfKeyState, pt.x, pt.y, (DragDropEffects) pdwEffect, this.lastEffect);
    this.lastDataObject = data;
    return dragEventArgs;
  }

  int IOleDropTarget.OleDragOver(int grfKeyState, long pt, ref int pdwEffect)
  {
    DragEventArgs dragEventArgs = this.CreateDragEventArgs((object) null, grfKeyState, new POINTL()
    {
      x = DragDropExtender.GetX(pt),
      y = DragDropExtender.GetY(pt)
    }, pdwEffect);
    DragDropExtender.InvokeControlMethod(this.control, "OnDragOver", (object) dragEventArgs);
    pdwEffect = (int) dragEventArgs.Effect;
    this.lastEffect = dragEventArgs.Effect;
    return 0;
  }

  int IOleDropTarget.OleDragLeave()
  {
    DragDropExtender.InvokeControlMethod(this.control, "OnDragLeave", (object) EventArgs.Empty);
    return 0;
  }

  int IOleDropTarget.OleDrop(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
  {
    DragEventArgs dragEventArgs = this.CreateDragEventArgs(pDataObj, grfKeyState, new POINTL()
    {
      x = DragDropExtender.GetX(pt),
      y = DragDropExtender.GetY(pt)
    }, pdwEffect);
    if (dragEventArgs != null)
    {
      DragDropExtender.InvokeControlMethod(this.control, "OnDragDrop", (object) dragEventArgs);
      pdwEffect = (int) dragEventArgs.Effect;
    }
    else
      pdwEffect = 0;
    this.lastEffect = DragDropEffects.None;
    this.lastDataObject = (System.Windows.Forms.IDataObject) null;
    return 0;
  }

  private static POINTSTRUCT GetCursorScreenPosition()
  {
    POINTSTRUCT lpPoint = new POINTSTRUCT();
    return UnsafeNativeMethods.GetCursorPos(ref lpPoint) != 0 ? lpPoint : throw new InvalidOperationException();
  }

  private static void InvokeControlMethod(
    Control control,
    string methodName,
    params object[] parameters)
  {
    typeof (Control).GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) control, parameters == null ? new object[1] : parameters);
  }

  private void InitializeComponent() => this.components = (IContainer) new System.ComponentModel.Container();
}

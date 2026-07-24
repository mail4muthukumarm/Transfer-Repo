// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.MenuManagerBase
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public abstract class MenuManagerBase : IMenuConsumer, IDisposable
{
  private Form _activeMDIChild;
  private bool _connected;
  private ArrayList _residentTools;
  private ArrayList _volatileTools;
  private UltraToolbarsManager _menuManager;
  private static ArrayList _menuMangers = new ArrayList();

  protected MenuManagerBase()
  {
    this._connected = true;
    this._residentTools = new ArrayList();
    this._volatileTools = new ArrayList();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  internal UltraToolbarsManager MenuManager => this._menuManager;

  void IMenuConsumer.IMenuConsumer_OnBeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (!this._connected)
      return;
    this.OnBeforeToolDropdown(RuntimeHelpers.GetObjectValue(sender), e);
  }

  void IMenuConsumer.IMenuConsumer_OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (!this._connected)
      return;
    if (this.FilterResidentToolClicks)
    {
      try
      {
        foreach (ToolBase residentTool in this._residentTools)
        {
          if (Operators.CompareString(residentTool.Key, ((ToolEventArgs) e).Tool.Key, false) == 0)
          {
            this.OnIGMenuToolClicked(RuntimeHelpers.GetObjectValue(sender), e);
            return;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this.FilterVolatileToolClicks)
    {
      try
      {
        foreach (ToolBase volatileTool in this._volatileTools)
        {
          if (Operators.CompareString(volatileTool.Key, ((ToolEventArgs) e).Tool.Key, false) == 0)
          {
            this.OnIGMenuToolClicked(RuntimeHelpers.GetObjectValue(sender), e);
            return;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this.FilterVolatileToolClicks || this.FilterResidentToolClicks)
      return;
    this.OnIGMenuToolClicked(RuntimeHelpers.GetObjectValue(sender), e);
  }

  void IMenuConsumer.IMenuConsumer_OnSetupIGMenu(UltraToolbarsManager menu)
  {
    this._menuManager = menu;
    MDIControls.Instance.MDIParent.MdiChildActivate += new EventHandler(this.InternalMDIChildActivate);
    this.OnSetupIGMenu(menu);
  }

  protected Form ActiveMDIChild => MDIControls.Instance.MDIParent.ActiveMdiChild;

  protected virtual void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  protected virtual void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
  }

  protected virtual void OnSetupIGMenu(UltraToolbarsManager menu)
  {
  }

  protected virtual void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public static void RefreshTopLevelTools(Type menuManagerType)
  {
    try
    {
      foreach (object menuManger in MenuManagerBase._menuMangers)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(menuManger);
        if (objectValue.GetType().Equals(menuManagerType))
        {
          if (!(objectValue is MenuManagerBase menuManagerBase))
            break;
          menuManagerBase.OnRefreshTopLevelTools(RuntimeHelpers.GetObjectValue(objectValue), menuManagerBase.MenuManager);
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void ClearAllVolatileTools()
  {
    try
    {
      foreach (object menuManger in MenuManagerBase._menuMangers)
      {
        if (RuntimeHelpers.GetObjectValue(menuManger) is MenuManagerBase objectValue)
          objectValue.ClearVolatileTools();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void OnMDIChildActivate(object sender, EventArgs e)
  {
  }

  private void InternalMDIChildActivate(object sender, EventArgs e)
  {
    if (this._activeMDIChild == null)
    {
      this._activeMDIChild = this.ActiveMDIChild;
      if (this._activeMDIChild != null)
        this._activeMDIChild.Closed += new EventHandler(this.ActiveMDIChildClosed);
    }
    else if (this._activeMDIChild != this.ActiveMDIChild)
    {
      if (this._activeMDIChild != null)
      {
        this._activeMDIChild.Closed -= new EventHandler(this.ActiveMDIChildClosed);
        this._activeMDIChild = (Form) null;
      }
      this._activeMDIChild = this.ActiveMDIChild;
      if (this._activeMDIChild != null)
        this._activeMDIChild.Closed += new EventHandler(this.ActiveMDIChildClosed);
    }
    this.OnMDIChildActivate(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void ActiveMDIChildClosed(object sender, EventArgs e)
  {
    this.ClearVolatileTools();
    if (this._activeMDIChild == null)
      return;
    this._activeMDIChild.Closed -= new EventHandler(this.ActiveMDIChildClosed);
    this._activeMDIChild = (Form) null;
  }

  protected virtual bool FilterResidentToolClicks => true;

  protected virtual bool FilterVolatileToolClicks => true;

  public void Dispose()
  {
    this.ClearResidentTools();
    this.ClearVolatileTools();
    ((Component) this._menuManager).Dispose();
    this._menuManager = (UltraToolbarsManager) null;
    MDIControls.Instance.MDIParent.MdiChildActivate -= new EventHandler(this.InternalMDIChildActivate);
    this._activeMDIChild.Dispose();
  }

  protected void AddResidentTool(ToolBase tool)
  {
    if (((ToolsCollectionBase) this._menuManager.Tools).Exists(tool.Key))
    {
      tool = ((ToolsCollectionBase) this._menuManager.Tools)[tool.Key];
    }
    else
    {
      this._residentTools.Add((object) tool);
      this._menuManager.Tools.Add(tool);
    }
  }

  protected void ClearResidentTools()
  {
    if (this._menuManager != null)
    {
      try
      {
        foreach (ToolBase residentTool in this._residentTools)
        {
          try
          {
            this._menuManager.Tools.Remove(residentTool);
            ((DisposableObject) residentTool).Dispose();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this._residentTools.Clear();
  }

  protected void SetResidentToolsVisible(bool visible)
  {
    try
    {
      foreach (ToolBase residentTool in this._residentTools)
        residentTool.SharedProps.Visible = visible;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected ToolBase GetResidentTool(string key)
  {
    ToolBase residentTool1;
    try
    {
      foreach (ToolBase residentTool2 in this._residentTools)
      {
        if (Operators.CompareString(residentTool2.Key, key, false) == 0)
        {
          residentTool1 = residentTool2;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    residentTool1 = (ToolBase) null;
label_8:
    return residentTool1;
  }

  protected ToolBase GetResidentTool(int index) => (ToolBase) this._residentTools[index];

  protected void AddVolatileTool(ToolBase tool)
  {
    this._volatileTools.Add((object) tool);
    this._menuManager.Tools.Add(tool);
  }

  protected void ClearVolatileTools()
  {
    if (this._menuManager != null)
    {
      try
      {
        foreach (ToolBase volatileTool in this._volatileTools)
        {
          try
          {
            this._menuManager.Tools.Remove(volatileTool);
            ((DisposableObject) volatileTool).Dispose();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this._volatileTools.Clear();
  }

  protected bool Connected
  {
    get => this._connected;
    set => this._connected = value;
  }

  public void IMenuConsumer_OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
    this.OnRefreshTopLevelTools(RuntimeHelpers.GetObjectValue(sender), menu);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public static ArrayList MenuManagers => MenuManagerBase._menuMangers;
}

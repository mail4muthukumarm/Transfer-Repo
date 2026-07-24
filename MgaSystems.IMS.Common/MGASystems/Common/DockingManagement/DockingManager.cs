// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DockingManagement.DockingManager
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinDock.Serialization;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DockingManagement;

public sealed class DockingManager : IMenuConsumer
{
  private const string DOCK_RESET_KEY = "DOCK_RESET";
  private static UltraDockManager _ultraDockManager;
  private static PaneLoadingHandler _paneLoading;
  private static Form _activeMdiChild;
  private static List<Control> _dockingInfoProviders;
  private static Form _mdiParent;
  private static List<ButtonTool> _tools = new List<ButtonTool>();
  private static ISecurityManager _security;
  private static IRemoteObjectManager _remoteObjects;
  private static UltraToolbarsManager _menu;
  private static List<IMdiActivationListener> _mgaChildActivationListeners;

  public static event EventHandler MDIChildActivating;

  public static event EventHandler MDIChildDeActivating;

  public static event CancelEventHandler OpeningDockableProvidor;

  public static List<IMdiActivationListener> MdiChildActivationListeners
  {
    get
    {
      if (DockingManager._mgaChildActivationListeners == null)
        DockingManager._mgaChildActivationListeners = new List<IMdiActivationListener>();
      return DockingManager._mgaChildActivationListeners;
    }
  }

  private static List<Control> DockingInfoProviders
  {
    get
    {
      if (DockingManager._dockingInfoProviders == null)
        DockingManager._dockingInfoProviders = new List<Control>();
      return DockingManager._dockingInfoProviders;
    }
  }

  public static void Close()
  {
    try
    {
      DockingManager.SaveConfig();
      try
      {
        foreach (Control dockingInfoProvider in DockingManager.DockingInfoProviders)
        {
          ObjectFactory.QueryInterface<IDockingInfoProvider>((object) dockingInfoProvider)?.BeforeLogOut();
          dockingInfoProvider.Visible = false;
          DockingManager._mdiParent.Controls.Remove(dockingInfoProvider);
        }
      }
      finally
      {
        List<Control>.Enumerator enumerator;
        enumerator.Dispose();
      }
      DockingManager._dockingInfoProviders.Clear();
      DockingManager._dockingInfoProviders = (List<Control>) null;
      if (DockingManager._ultraDockManager == null)
        return;
      DockingManager._ultraDockManager.PaneActivate -= new ControlPaneEventHandler(DockingManager.UltraDockManager_PaneActivate);
      try
      {
        DockingManager._ultraDockManager.ControlPanes.Clear();
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public static void Initialize(
    Form mdiParent,
    UltraDockManager ultraDockManager,
    PaneLoadingHandler paneLoading)
  {
    if (mdiParent == null)
      throw new ArgumentNullException(nameof (mdiParent));
    DockingManager._ultraDockManager = ultraDockManager;
    DockingManager._paneLoading = paneLoading;
    DockingManager._mdiParent = mdiParent;
    ObjectFactory.Instance.CreateObjectEX(typeof (DockingManager));
    mdiParent.MdiChildActivate += new EventHandler(DockingManager.mdiForm_MdiChildActivated);
  }

  public static bool IsPanelVisible(string key)
  {
    DockablePaneBase dockablePaneBase = DockingManager._ultraDockManager.PaneFromKey(key);
    return !(dockablePaneBase is DockableControlPane dockableControlPane) ? dockablePaneBase.IsVisible : (!dockableControlPane.Pinned ? dockableControlPane.Control.Visible : ((DockablePaneBase) dockableControlPane).IsSelectedTab);
  }

  public static ISecurityManager Security => DockingManager._security;

  private static void UltraDockManager_PaneActivate(object sender, ControlPaneEventArgs e)
  {
  }

  public static void Open(ISecurityManager security, IRemoteObjectManager remoteObjects)
  {
    DockingManager.Open(true, security, remoteObjects);
  }

  public static void Open(
    bool shouldLoadConfig,
    ISecurityManager security,
    IRemoteObjectManager remoteObjects)
  {
    DockingManager._security = security;
    DockingManager._remoteObjects = remoteObjects;
    DockingManager._ultraDockManager.PaneActivate += new ControlPaneEventHandler(DockingManager.UltraDockManager_PaneActivate);
    Type[] typeArray1 = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IDockingInfoProvider));
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    Type[] typeArray2 = typeArray1;
    int index = 0;
    while (index < typeArray2.Length)
    {
      Type type = typeArray2[index];
      CancelEventArgs e = new CancelEventArgs();
      // ISSUE: reference to a compiler-generated field
      CancelEventHandler dockableProvidorEvent = DockingManager.OpeningDockableProvidorEvent;
      if (dockableProvidorEvent != null)
        dockableProvidorEvent((object) type, e);
      if (!e.Cancel)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(type));
        if (objectValue != null)
        {
          Control control = objectValue as Control;
          IDockingInfoProvider dockingInfoProvider = ObjectFactory.QueryInterface<IDockingInfoProvider>(RuntimeHelpers.GetObjectValue(objectValue));
          object obj;
          if (!dictionary.ContainsKey(dockingInfoProvider.CreationInfo.Key))
          {
            dictionary.Add(dockingInfoProvider.CreationInfo.Key, dockingInfoProvider.CreationInfo.Key);
            if (control != null)
            {
              if (dockingInfoProvider != null)
              {
                if (dockingInfoProvider.CreationInfo != null)
                {
                  DockingManager.DockingInfoProviders.Add(control);
                  if (objectValue is Form form)
                    form.TopLevel = false;
                }
                else
                {
                  control.Dispose();
                  obj = (object) null;
                }
              }
              else
              {
                control.Dispose();
                obj = (object) null;
              }
            }
          }
          else
          {
            control.Dispose();
            obj = (object) null;
          }
        }
      }
      checked { ++index; }
    }
    DockingManager.DockingInfoProviders.Sort((IComparer<Control>) new DockingManagerSort());
    try
    {
      foreach (Control dockingInfoProvider1 in DockingManager.DockingInfoProviders)
      {
        IDockingInfoProvider dockingInfoProvider2 = ObjectFactory.QueryInterface<IDockingInfoProvider>((object) dockingInfoProvider1);
        DockingManager._paneLoading(dockingInfoProvider2.CreationInfo.Title);
        DockingManager.CreatePane(DockingManager._ultraDockManager, dockingInfoProvider1);
      }
    }
    finally
    {
      List<Control>.Enumerator enumerator;
      enumerator.Dispose();
    }
    DockingManager.ResetMenu();
    int num = shouldLoadConfig ? 1 : 0;
    try
    {
      foreach (object dockingInfoProvider in DockingManager.DockingInfoProviders)
        ObjectFactory.QueryInterface<IDockingInfoProvider>(dockingInfoProvider).AfterLogon();
    }
    finally
    {
      List<Control>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public static void ShowAndActivate(string paneKey)
  {
    if (!((KeyedSubObjectsCollectionBase) DockingManager._ultraDockManager.ControlPanes).Exists(paneKey))
      return;
    DockableControlPane controlPane = DockingManager._ultraDockManager.ControlPanes[paneKey];
    if (controlPane == null || controlPane.IsMdiChild)
      return;
    controlPane.Activate();
    DockingManager.ShowInFlyout(controlPane);
  }

  private static void ShowInFlyout(DockableControlPane pane)
  {
    if (pane.IsFlyoutPaneDisplayed && pane.IsActive || pane.Pinned && pane.IsVisible)
      return;
    if (pane.IsFlyoutPaneDisplayed && !pane.IsActive)
    {
      pane.Activate();
    }
    else
    {
      if (!pane.IsVisible)
        ((DockablePaneBase) pane).Show();
      if (((DockablePaneBase) pane).Manager.FlyoutPane != null)
        ((DockablePaneBase) pane).Manager.FlyIn();
      if (pane.Pinned)
      {
        if (((DockablePaneBase) pane).DockedState == null)
          ((DockablePaneBase) pane).Dock(true);
        pane.Unpin();
        pane.Activate();
      }
      else
        pane.Flyout(true, true);
    }
  }

  public static void SendMessageToTabs(Guid eventGuid, object context)
  {
    try
    {
      foreach (object dockingInfoProvider in DockingManager.DockingInfoProviders)
        ObjectFactory.QueryInterface<IMessageListener>(dockingInfoProvider)?.OnMessageReceived(eventGuid, RuntimeHelpers.GetObjectValue(context));
    }
    finally
    {
      List<Control>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public static Control ControlFromKey(string key)
  {
    return !(DockingManager._ultraDockManager.PaneFromKey(key) is DockableControlPane dockableControlPane) ? (Control) null : dockableControlPane.Control;
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "DOCK_RESET", false) == 0)
    {
      DockingManager.Close();
      DockingManager.Open(false, DockingManager._security, DockingManager._remoteObjects);
    }
    else
      DockingManager.ShowAndActivate(key);
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu) => DockingManager._menu = menu;

  private static void ResetMenu()
  {
    try
    {
      foreach (ToolBase tool in DockingManager._tools)
      {
        DockingManager._menu.Tools.Remove(tool);
        ((DisposableObject) tool).Dispose();
      }
    }
    finally
    {
      List<ButtonTool>.Enumerator enumerator;
      enumerator.Dispose();
    }
    DockingManager._tools.Clear();
    foreach (DockableControlPane controlPane in DockingManager._ultraDockManager.ControlPanes)
    {
      string key = ((KeyedSubObjectBase) controlPane).Key;
      ButtonTool buttonTool = new ButtonTool(key);
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = RuntimeHelpers.GetObjectValue(((DockablePaneBase) controlPane).Settings.TabAppearance.Image);
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = RuntimeHelpers.GetObjectValue(((DockablePaneBase) controlPane).Settings.TabAppearance.Image);
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "&" + ((DockablePaneBase) controlPane).Text;
      DockingManager._menu.Tools.Add((ToolBase) buttonTool);
      ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) DockingManager._menu.Toolbars["mainMenu"]).Tools)["View"]).Tools.AddTool(key);
      DockingManager._tools.Add(buttonTool);
    }
    ButtonTool buttonTool1 = new ButtonTool("DOCK_RESET");
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedProps).Caption = "&Reset Dockable Panes";
    DockingManager._menu.Tools.Add((ToolBase) buttonTool1);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) DockingManager._menu.Toolbars["mainMenu"]).Tools)["View"]).Tools.AddTool("DOCK_RESET");
    DockingManager._tools.Add(buttonTool1);
  }

  private static DockablePaneBase InternalCreatePane(
    UltraDockManager dockManager,
    Control dockingControl)
  {
    IDockingInfoProvider dockingInfoProvider = ObjectFactory.QueryInterface<IDockingInfoProvider>((object) dockingControl);
    DockWindowCreationInfo creationInfo = dockingInfoProvider.CreationInfo;
    if (dockManager.PaneFromKey(creationInfo.Key) != null)
      dockManager.DockAreas.Remove(creationInfo.Key);
    if (dockManager.PaneFromKey(creationInfo.Key) == null)
    {
      if (Operators.CompareString(dockingControl.Name, creationInfo.Key, false) != 0)
        dockingInfoProvider.InitializeOnSplashLoad();
      dockingControl.Name = creationInfo.Key;
      DockableControlPane dockableControlPane1 = new DockableControlPane(creationInfo.Key, dockingControl);
      DockableControlPane dockableControlPane2 = dockableControlPane1;
      ((DockablePaneBase) dockableControlPane2).Text = creationInfo.Title;
      dockableControlPane2.FlyoutSize = dockingControl.Size;
      ((DockablePaneBase) dockableControlPane2).Size = dockingControl.Size;
      ((DockablePaneBase) dockableControlPane2).Settings.TabAppearance.Image = (object) creationInfo.TabImage;
      ((DockablePaneBase) dockableControlPane2).MinimumSize = dockingControl.Size;
      if (creationInfo.GroupKey != null && Operators.CompareString(creationInfo.GroupKey, string.Empty, false) != 0)
      {
        DockableGroupPane dockableGroupPane = (DockableGroupPane) null;
        foreach (DockAreaPane dockArea in dockManager.DockAreas)
        {
          if (((KeyedSubObjectsCollectionBase) ((DockableGroupPane) dockArea).Panes).Exists(creationInfo.GroupKey))
          {
            dockableGroupPane = (DockableGroupPane) ((DockableGroupPane) dockArea).Panes[creationInfo.GroupKey];
            break;
          }
        }
        if (dockableGroupPane == null)
        {
          dockableGroupPane = new DockableGroupPane(creationInfo.GroupKey);
          dockableGroupPane.ChildPaneStyle = (ChildPaneStyle) 2;
          dockableGroupPane.Panes.Add((DockablePaneBase) dockableControlPane1);
          DockAreaPane dockAreaPane = new DockAreaPane(creationInfo.DockedLocation);
          ((DockablePaneBase) dockAreaPane).Size = dockingControl.Size;
          ((DockablePaneBase) dockAreaPane).MinimumSize = dockingControl.Size;
          ((DockableGroupPane) dockAreaPane).Panes.Add((DockablePaneBase) dockableGroupPane);
          dockManager.DockAreas.Add(dockAreaPane);
        }
        dockableGroupPane.Panes.Add((DockablePaneBase) dockableControlPane1);
      }
      else
      {
        DockAreaPane dockAreaPane = new DockAreaPane(creationInfo.DockedLocation);
        ((DockableGroupPane) dockAreaPane).Panes.Add((DockablePaneBase) dockableControlPane1);
        dockManager.DockAreas.Add(dockAreaPane);
      }
    }
    return DockingManager._ultraDockManager.PaneFromKey(creationInfo.Key);
  }

  private static void CreatePane(UltraDockManager dockManager, Control dockingControl)
  {
    SecureTabResourceAttribute searchAttribute = new SecureTabResourceAttribute();
    object attributeFromType = (object) ObjectFactory.GetAttributeFromType(ObjectFactory.QueryInterface<IDockingInfoProvider>((object) dockingControl).GetType(), (Attribute) searchAttribute);
    DockablePaneBase dockablePaneBase = (DockablePaneBase) null;
    if (attributeFromType == null)
    {
      dockablePaneBase = DockingManager.InternalCreatePane(dockManager, dockingControl);
    }
    else
    {
      Guid uniqueIdentifier = ((SecureResourceAttribute) attributeFromType).UniqueIdentifier;
      if (DockingManager._security.AssertPermission(uniqueIdentifier, 0))
        dockablePaneBase = DockingManager.InternalCreatePane(dockManager, dockingControl);
    }
    IDockingInfoProvider dockingInfoProvider = ObjectFactory.QueryInterface<IDockingInfoProvider>((object) dockingControl);
    if (dockablePaneBase == null || dockingInfoProvider.CreationInfo.DefaultVisible)
      return;
    dockablePaneBase.Close();
  }

  private static bool IsDockStreamValid(MemoryStream stream)
  {
    stream.Position = 0L;
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    binaryFormatter.Binder = (SerializationBinder) new Binder();
    bool flag;
    try
    {
      ((Component) binaryFormatter.Deserialize((Stream) stream)).Dispose();
      stream.Position = 0L;
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      stream.Position = 0L;
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  private static void LoadConfig()
  {
    if (Conversions.ToInteger(DockingManager._remoteObjects.GetObject("IMS_DOCK_CONFIG_PANECOUNT", (object) 0)) != ((DisposableObjectCollectionBase) DockingManager._ultraDockManager.ControlPanes).Count)
      return;
    string str = Conversions.ToString(DockingManager._remoteObjects.GetObject("IMS_DOCK_PANE_KEYS", (object) string.Empty));
    if (str.Length <= 0 || str.IndexOf("*") == -1)
      return;
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    string[] strArray = str.Split("*".ToCharArray());
    int index = 0;
    while (index < strArray.Length)
    {
      string key = strArray[index];
      dictionary.Add(key, key);
      checked { ++index; }
    }
    foreach (DockableControlPane controlPane in DockingManager._ultraDockManager.ControlPanes)
    {
      if (!dictionary.ContainsKey(((KeyedSubObjectBase) controlPane).Key))
        return;
    }
    object objectValue = RuntimeHelpers.GetObjectValue(DockingManager._remoteObjects.GetObject("IMS_DOCK_CONFIG"));
    if (objectValue == null)
      return;
    try
    {
      MemoryStream stream = (MemoryStream) objectValue;
      stream.Position = 0L;
      if (!DockingManager.IsDockStreamValid(stream))
        return;
      DockingManager._ultraDockManager.LoadFromBinary((Stream) stream);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private static void SaveConfig()
  {
    if (DockingManager._ultraDockManager == null)
      return;
    MemoryStream memoryStream = new MemoryStream();
    DockingManager._ultraDockManager.SaveAsBinary((Stream) memoryStream);
    DockingManager._remoteObjects.SetObject("IMS_DOCK_CONFIG_PANECOUNT", (object) ((DisposableObjectCollectionBase) DockingManager._ultraDockManager.ControlPanes).Count);
    StringBuilder stringBuilder = new StringBuilder();
    bool flag = true;
    foreach (DockableControlPane controlPane in DockingManager._ultraDockManager.ControlPanes)
    {
      if (flag)
        flag = false;
      else
        stringBuilder.Append("*");
      stringBuilder.Append(((KeyedSubObjectBase) controlPane).Key);
    }
    DockingManager._remoteObjects.SetObject("IMS_DOCK_PANE_KEYS", (object) stringBuilder.ToString());
    DockingManager._remoteObjects.SetObject("IMS_DOCK_CONFIG", (object) memoryStream);
  }

  private static void mdiForm_MdiChildActivated(object sender, EventArgs e)
  {
    DockingManager.SafeDisconnectMdiChildClosing();
    Form form = (Form) sender;
    if (form.ActiveMdiChild == null)
      return;
    DockingManager._activeMdiChild = form.ActiveMdiChild;
    DockingManager._activeMdiChild.Closing += new CancelEventHandler(DockingManager.mdiForm_MdiChildClosing);
    DockingManager._activeMdiChild.Closed += new EventHandler(DockingManager.mdiForm_MdiChildClosed);
    DockingManager._activeMdiChild.Deactivate += new EventHandler(DockingManager.mdiForm_MdiChildDeActivated);
    DockingManager.BroadcastMdiChildActivated(DockingManager._activeMdiChild);
  }

  private static void mdiForm_MdiChildDeActivated(object sender, EventArgs e)
  {
    MDIControls.Instance.LastActivatedVisibleForm = (Form) sender;
    MDIControls.Instance.LastActivatedVisibleForm.Deactivate -= new EventHandler(DockingManager.mdiForm_MdiChildDeActivated);
  }

  private static void mdiForm_MdiChildClosed(object sender, EventArgs e)
  {
    MDIControls.Instance.LastActivatedVisibleForm = (Form) null;
    ((Form) sender).Closed -= new EventHandler(DockingManager.mdiForm_MdiChildClosed);
  }

  private static void mdiForm_MdiChildClosing(object sender, CancelEventArgs e)
  {
    if (sender != DockingManager._activeMdiChild)
      return;
    DockingManager.SafeDisconnectMdiChildClosing();
  }

  private static void BroadcastMdiChildActivated(Form mdiChild)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler childActivatingEvent = DockingManager.MDIChildActivatingEvent;
    if (childActivatingEvent != null)
      childActivatingEvent((object) mdiChild, EventArgs.Empty);
    try
    {
      foreach (object dockingInfoProvider in DockingManager.DockingInfoProviders)
        ObjectFactory.QueryInterface<IDockingInfoProvider>(dockingInfoProvider).MDIChildActivating(mdiChild);
    }
    finally
    {
      List<Control>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (IMdiActivationListener activationListener in DockingManager.MdiChildActivationListeners)
        activationListener.MDIChildActivating(mdiChild);
    }
    finally
    {
      List<IMdiActivationListener>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private static void BroadcastMdiChildDectivated(Form mdiChild)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler deActivatingEvent = DockingManager.MDIChildDeActivatingEvent;
    if (deActivatingEvent != null)
      deActivatingEvent((object) mdiChild, EventArgs.Empty);
    try
    {
      foreach (object dockingInfoProvider in DockingManager.DockingInfoProviders)
        ObjectFactory.QueryInterface<IDockingInfoProvider>(dockingInfoProvider).MDIChildDeActivate(mdiChild);
    }
    finally
    {
      List<Control>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (IMdiActivationListener activationListener in DockingManager.MdiChildActivationListeners)
        activationListener.MDIChildDeActivate(mdiChild);
    }
    finally
    {
      List<IMdiActivationListener>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private static void SafeDisconnectMdiChildClosing()
  {
    if (DockingManager._activeMdiChild == null)
      return;
    DockingManager._activeMdiChild.Closing -= new CancelEventHandler(DockingManager.mdiForm_MdiChildClosing);
    DockingManager.BroadcastMdiChildDectivated(DockingManager._activeMdiChild);
    DockingManager._activeMdiChild = (Form) null;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FormSettingsManager
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win.UltraWinDock;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[Preference("Screens.All.AutoPositioning.Enabled", true)]
public sealed class FormSettingsManager : IDisposable
{
  public const string PREFERENCE_FormSettingsManager_DoAutoPosDlg = "Screens.All.AutoPositioning.Enabled";
  private UltraDockManager _dm;
  private IRemoteObjectManager _remoteObjects;
  private IPreferenceManager _preferences;

  public FormSettingsManager(
    UltraDockManager dm,
    IRemoteObjectManager remoteObjects,
    IPreferenceManager preferences)
  {
    this._remoteObjects = remoteObjects;
    this._preferences = preferences;
    ObjectFactory.Instance.ObjectConstructed += new ObjectFactory.ObjectConstructedEventHandler(this.objectFactory_ObjectCreated);
    this._dm = dm;
  }

  private void form_closing(object sender, CancelEventArgs e)
  {
    Form frm = (Form) sender;
    frm.Closing -= new CancelEventHandler(this.form_closing);
    if (!CurrentUser.Instance.IsLoggedIn)
      return;
    if (frm.FormBorderStyle != FormBorderStyle.Fixed3D && frm.FormBorderStyle != FormBorderStyle.FixedDialog && frm.FormBorderStyle != FormBorderStyle.FixedToolWindow && frm.FormBorderStyle != FormBorderStyle.FixedSingle && frm.StartPosition != FormStartPosition.CenterScreen && frm.StartPosition != FormStartPosition.CenterParent)
      this._remoteObjects.BeginSetObject(frm.GetType().FullName, (object) new FormSettings(frm, this._remoteObjects));
    else
      this._remoteObjects.BeginRemoveObject(frm.GetType().FullName);
  }

  private void form_load(object sender, EventArgs e)
  {
    if (!CurrentUser.Instance.IsLoggedIn)
      return;
    Form frm = (Form) sender;
    frm.Load -= new EventHandler(this.form_load);
    int x = 0;
    int y = 0;
    int num1 = MDIControls.Instance.MDIParent.ClientSize.Width;
    int num2 = MDIControls.Instance.MDIParent.ClientSize.Height;
    bool flag = false;
    foreach (DockableControlPane controlPane in this._dm.ControlPanes)
    {
      if (controlPane.IsFlyoutPaneDisplayed && ((DockablePaneBase) controlPane).DockedState == 1)
      {
        if (((DockablePaneBase) controlPane).DockAreaPane.DockedLocation == 1 && controlPane.FlyoutSize.Width > x)
          x = controlPane.FlyoutSize.Width;
        if (((DockablePaneBase) controlPane).DockAreaPane.DockedLocation == 4 && controlPane.FlyoutSize.Height > y)
          y = controlPane.FlyoutSize.Height;
        if (((DockablePaneBase) controlPane).DockAreaPane.DockedLocation == 2 && MDIControls.Instance.MDIParent.ClientSize.Width - controlPane.FlyoutSize.Width < num1)
          num1 = MDIControls.Instance.MDIParent.ClientSize.Width - controlPane.FlyoutSize.Width;
        if (((DockablePaneBase) controlPane).DockAreaPane.DockedLocation == 3 && MDIControls.Instance.MDIParent.ClientSize.Height - controlPane.FlyoutSize.Height < num2)
          num2 = MDIControls.Instance.MDIParent.ClientSize.Height - controlPane.FlyoutSize.Height;
      }
    }
    if (frm.Location.X < x || frm.Location.Y < y)
      flag = true;
    else if (frm.Bounds.Right > num1 || frm.Bounds.Bottom > num2)
      flag = true;
    if (!flag || !this._preferences.GetPreferenceBool("Screens.All.AutoPositioning.Enabled"))
      return;
    FormSettingsManager.AutoPosDialog(frm, x, y);
  }

  private static void AutoPosDialog(Form frm, int x, int y)
  {
    if (frm is IFormSettingsIgnore)
      return;
    Point location;
    if (frm.Location.X < x)
    {
      Form form = frm;
      int x1 = x;
      location = frm.Location;
      int y1 = location.Y;
      Point point = new Point(x1, y1);
      form.Location = point;
    }
    location = frm.Location;
    if (location.X >= y)
      return;
    Form form1 = frm;
    location = frm.Location;
    Point point1 = new Point(location.X, y);
    form1.Location = point1;
  }

  private void CleanUp()
  {
    ObjectFactory.Instance.ObjectConstructed -= new ObjectFactory.ObjectConstructedEventHandler(this.objectFactory_ObjectCreated);
  }

  private void objectFactory_ObjectCreated(object sender, EventArgs e)
  {
    if (!(sender is Form form) || sender is IFormSettingsIgnore)
      return;
    form.Closing += new CancelEventHandler(this.form_closing);
    form.Load += new EventHandler(this.form_load);
  }

  public void Dispose()
  {
    ((Component) this._dm).Dispose();
    GC.SuppressFinalize((object) this);
    this.CleanUp();
  }
}

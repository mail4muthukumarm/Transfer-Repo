// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DockingManagement.DockingManagerSort
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DockingManagement;

public sealed class DockingManagerSort : IComparer<Control>
{
  public int Compare(Control x, Control y)
  {
    IDockingInfoProvider dockingInfoProvider1 = ObjectFactory.QueryInterface<IDockingInfoProvider>((object) x);
    IDockingInfoProvider dockingInfoProvider2 = ObjectFactory.QueryInterface<IDockingInfoProvider>((object) y);
    return dockingInfoProvider1.PreferredPosition != dockingInfoProvider2.PreferredPosition ? (dockingInfoProvider1.PreferredPosition <= dockingInfoProvider2.PreferredPosition ? -1 : 1) : 0;
  }
}

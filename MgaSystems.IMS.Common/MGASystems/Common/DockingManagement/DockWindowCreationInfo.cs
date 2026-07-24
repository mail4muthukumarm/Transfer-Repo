// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DockingManagement.DockWindowCreationInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win.UltraWinDock;
using System.Drawing;

#nullable disable
namespace MGASystems.Common.DockingManagement;

public sealed class DockWindowCreationInfo
{
  public string Title;
  public string Key;
  public DockedLocation DockedLocation;
  public bool Pinned;
  public string GroupKey;
  public Image TabImage;
  public bool DefaultVisible;

  public DockWindowCreationInfo(bool defaultVisible, string key, string title)
    : this(defaultVisible, key, title, (DockedLocation) 0, (string) null, (Image) null, true)
  {
  }

  public DockWindowCreationInfo(
    bool defaultVisible,
    string key,
    string title,
    DockedLocation dockedLocation,
    Image tabImage,
    bool pinned)
    : this(defaultVisible, key, title, dockedLocation, (string) null, tabImage, true)
  {
  }

  public DockWindowCreationInfo(
    bool defaultVisible,
    string key,
    string title,
    string groupKey,
    Image tabImage)
    : this(defaultVisible, key, title, (DockedLocation) 0, groupKey, tabImage, true)
  {
  }

  public DockWindowCreationInfo(bool defaultVisible, string key, string title, Image tabImage)
    : this(defaultVisible, key, title, (DockedLocation) 0, (string) null, tabImage, true)
  {
  }

  public DockWindowCreationInfo(
    bool defaultVisible,
    string key,
    string title,
    DockedLocation dockedLocation)
    : this(defaultVisible, key, title, dockedLocation, (string) null, (Image) null, true)
  {
  }

  public DockWindowCreationInfo(string key, string title)
    : this(key, title, (DockedLocation) 0, (string) null, (Image) null, true)
  {
  }

  public DockWindowCreationInfo(
    string key,
    string title,
    DockedLocation dockedLocation,
    Image tabImage,
    bool pinned)
    : this(key, title, dockedLocation, (string) null, tabImage, true)
  {
  }

  public DockWindowCreationInfo(string key, string title, string groupKey, Image tabImage)
    : this(key, title, (DockedLocation) 0, groupKey, tabImage, true)
  {
  }

  public DockWindowCreationInfo(string key, string title, Image tabImage)
    : this(key, title, (DockedLocation) 0, (string) null, tabImage, true)
  {
  }

  public DockWindowCreationInfo(string key, string title, DockedLocation dockedLocation)
    : this(key, title, dockedLocation, (string) null, (Image) null, true)
  {
  }

  public DockWindowCreationInfo(
    string key,
    string title,
    DockedLocation dockedLocation,
    string groupKey,
    Image tabImage,
    bool pinned)
    : this(true, key, title, dockedLocation, groupKey, tabImage, pinned)
  {
  }

  public DockWindowCreationInfo(
    bool defaultVisible,
    string key,
    string title,
    DockedLocation dockedLocation,
    string groupKey,
    Image tabImage,
    bool pinned)
  {
    this.DefaultVisible = defaultVisible;
    this.Key = key;
    this.Title = title;
    this.DockedLocation = dockedLocation;
    this.GroupKey = groupKey;
    this.TabImage = tabImage;
    this.Pinned = pinned;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ClearanceContextMenuAttribute
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ClearanceContextMenuAttribute : Attribute
{
  private string _caption;
  private string _folder;
  private ClearanceContextMenuLevelEnum _level;

  public string Caption => this._caption;

  public string Folder => this._folder != null ? this._folder : string.Empty;

  public ClearanceContextMenuLevelEnum Level => this._level;

  public ClearanceContextMenuAttribute()
  {
  }

  public ClearanceContextMenuAttribute(
    string caption,
    string folder,
    ClearanceContextMenuLevelEnum level)
  {
    this._caption = caption;
    this._folder = folder;
    this._level = level;
  }

  public ClearanceContextMenuAttribute(string caption, ClearanceContextMenuLevelEnum level)
    : this(caption, string.Empty, level)
  {
  }

  public override bool Match(object obj) => obj is ClearanceContextMenuAttribute;
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGADrawListItemEventArgs
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGADrawListItemEventArgs : EventArgs
{
  private bool _enabled;
  private bool _showCheck;
  private bool _checked;
  private DrawItemEventArgs _itemArgs;

  public bool Enabled
  {
    get => this._enabled;
    set => this._enabled = value;
  }

  public bool ShowCheck
  {
    get => this._showCheck;
    set => this._showCheck = value;
  }

  public DrawItemEventArgs ItemInfo
  {
    get => this._itemArgs;
    set => this._itemArgs = value;
  }

  public bool Checked
  {
    get => this._checked;
    set => this._checked = value;
  }
}

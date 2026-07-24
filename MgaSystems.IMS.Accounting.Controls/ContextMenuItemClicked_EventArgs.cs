// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.ContextMenuItemClicked_EventArgs
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public sealed class ContextMenuItemClicked_EventArgs
{
  private string _ExtendedDropDownName;
  private string _ContextMenuItemText;

  public string ExtendedDropDownName => this._ExtendedDropDownName;

  public string ContextMenuItemText => this._ContextMenuItemText;

  public ContextMenuItemClicked_EventArgs(
    string PassedMenuItemText,
    string PassedExtendedDropDownName)
  {
    this._ContextMenuItemText = PassedMenuItemText;
    this._ExtendedDropDownName = PassedExtendedDropDownName;
  }
}

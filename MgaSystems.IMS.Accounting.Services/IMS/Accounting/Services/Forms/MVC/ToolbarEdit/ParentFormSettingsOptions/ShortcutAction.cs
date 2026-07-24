// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions.ShortcutAction
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;

public class ShortcutAction
{
  private readonly Keys _activationKeys;
  private readonly Action _onActivationKeysPressed;

  public ShortcutAction(Keys activationKeys, Action action)
  {
    this._activationKeys = activationKeys;
    this._onActivationKeysPressed = action ?? throw new ArgumentNullException(nameof (action));
  }

  public virtual bool ExecuteIfForThis(Keys keys)
  {
    if (keys != this._activationKeys)
      return false;
    this._onActivationKeysPressed();
    return true;
  }

  public static ShortcutAction CreateCancel(Action action)
  {
    return new ShortcutAction(Keys.W | Keys.Control, action);
  }

  public static ShortcutAction CreateSave(Action action)
  {
    return new ShortcutAction(Keys.S | Keys.Control, action);
  }

  public static ShortcutAction CreateReset(Action action)
  {
    return new ShortcutAction(Keys.R | Keys.Control, action);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;

public class ParentFormSettings : IParentFormSettings
{
  private ShortcutAction[] _shortcutActions;

  public virtual int Width { get; set; }

  public virtual int Height { get; set; }

  public virtual string Name { get; set; }

  public virtual FormBorderStyle BorderStyle { get; set; } = FormBorderStyle.FixedDialog;

  public virtual bool Maximizeable { get; set; }

  public virtual bool Minimizeable { get; set; }

  public virtual ShortcutAction[] ShortcutActions
  {
    get
    {
      if (this._shortcutActions == null)
        this._shortcutActions = new ShortcutAction[0];
      return this._shortcutActions;
    }
    set => this._shortcutActions = value;
  }

  public virtual IParentFormSettings AppendClientNameToTitle(string clientName)
  {
    this.Name = $"{this.Name} ({clientName})";
    return (IParentFormSettings) this;
  }
}

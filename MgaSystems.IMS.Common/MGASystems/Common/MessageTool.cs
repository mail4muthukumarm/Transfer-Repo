// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MessageTool
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

internal class MessageTool : NativeWindow
{
  private const int WM_LBUTTONDOWN = 513;

  public event DeActivateEventHandler DeActivate;

  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 513)
    {
      // ISSUE: reference to a compiler-generated field
      DeActivateEventHandler deActivateEvent = this.DeActivateEvent;
      if (deActivateEvent != null)
        deActivateEvent();
    }
    base.WndProc(ref m);
  }
}

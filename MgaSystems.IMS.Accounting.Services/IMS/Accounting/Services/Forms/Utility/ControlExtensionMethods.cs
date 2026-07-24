// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.Utility.ControlExtensionMethods
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.Utility;

public static class ControlExtensionMethods
{
  public static int GetTotalWidth(this IStackEntryControl control)
  {
    return control.Width + control.Margin.Right + control.Margin.Left;
  }

  public static int GetTotalHeight(this IStackEntryControl control)
  {
    return control.Height + control.Margin.Bottom + control.Margin.Top;
  }

  public static int GetTotalWidth(this Control control)
  {
    return control.Width + control.Margin.Right + control.Margin.Left;
  }

  public static int GetTotalHeight(this Control control)
  {
    return control.Height + control.Margin.Bottom + control.Margin.Top;
  }

  public static int GetTotalWidth(this IMvcView view) => ((Control) view).GetTotalWidth();

  public static int GetTotalHeight(this IMvcView view) => ((Control) view).GetTotalHeight();

  public static int GetPreferredWidth(this Label label)
  {
    return label.PreferredWidth + label.Margin.Right + label.Margin.Left;
  }

  public static int GetPreferredHeight(this Label label)
  {
    return label.PreferredHeight + label.Margin.Bottom + label.Margin.Top;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry.IStackEntryControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;

public interface IStackEntryControl
{
  void AdjustControlSizeToFitLabelOfMaximumWidth(int width);

  int GetControlWidth();

  int GetPreferredTextWidth();

  int GetTextWidth();

  void SetLabelWidth(int width);

  void SetStartingWidth(int startingWidth);

  int Width { get; set; }

  int Height { get; }

  Padding Margin { get; }
}

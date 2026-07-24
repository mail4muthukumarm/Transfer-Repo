// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.ButtonToolbarControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;

public class ButtonToolbarControl : ButtonBaseToolbarControl<ButtonTool>
{
  public ButtonToolbarControl(string caption, Action onClick, object image = null)
    : base(caption, onClick, image)
  {
  }

  public ButtonToolbarControl(string identifier, string caption, Action onClick, object image = null)
    : base(identifier, caption, onClick, image)
  {
  }

  protected override void ChildApplySettingsToInfragisticsTool(ButtonTool tool)
  {
  }

  protected override ButtonTool ChildCreateInfragisticsTool()
  {
    return new ButtonTool(base.UniqueIdentifier);
  }
}

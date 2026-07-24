// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.IOptionStackView`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack;

[Obsolete]
public interface IOptionStackView<TDisplayItem> : IOptionStackView, IMvcView, IModelObserver
{
  void SetControlValues(TDisplayItem displayItem);

  IEnumerable<IOptionStackOptionSetting<TDisplayItem>> ControlSettings { get; }

  void CreateControls(
    IEnumerable<IOptionStackOptionSetting<TDisplayItem>> controlSettings);
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.OptionStackSetSettings`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack;

[Obsolete]
public class OptionStackSetSettings<TDisplayItem>
{
  public IEnumerable<IOptionStackOptionSetting<TDisplayItem>> OptionSettings { get; }

  public OptionStackSetSettings(
    List<IOptionStackOptionSetting<TDisplayItem>> settings)
  {
    this.OptionSettings = (IEnumerable<IOptionStackOptionSetting<TDisplayItem>>) (settings ?? throw new ArgumentNullException(nameof (settings)));
  }

  public OptionStackView<TDisplayItem> CreateView()
  {
    OptionStackView<TDisplayItem> view = new OptionStackView<TDisplayItem>();
    view.CreateControls(this.OptionSettings);
    return view;
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.E2ValueCommands
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Common;
using System;
using System.Windows.Input;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value;

public static class E2ValueCommands
{
  public static ICommand DoTheThing
  {
    get
    {
      return (ICommand) new RelayCommand<Property>((Action<Property>) (p =>
      {
        p.Include = true;
        int num = (int) ObjectFactory.Instance.CreateForm(typeof (PropertyEditor), new object[1]
        {
          (object) p.InnerProperty
        }).ShowDialog();
        p.InnerPropertyChanged();
      }));
    }
  }
}

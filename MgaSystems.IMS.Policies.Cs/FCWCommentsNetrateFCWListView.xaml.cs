// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.FCWComments.NetrateFCWListView
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.FCWComments;

public partial class NetrateFCWListView : MgaMdiChild, IComponentConnector
{
  internal NetrateFCWListView mainWindow;
  private bool _contentLoaded;

  public NetrateFCWListView()
  {
    this.InitializeComponent();
    this.Title = "FCW Comments Administration";
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/fcwcomments/netratefcwlistview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.mainWindow = (NetrateFCWListView) target;
    else
      this._contentLoaded = true;
  }
}

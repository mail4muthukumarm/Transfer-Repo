// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.HelpMenuAdmin.ViewHelpMenuAdmin
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Forms.HelpMenuAdmin;

public partial class ViewHelpMenuAdmin : MgaMdiChild, IComponentConnector
{
  private bool _contentLoaded;

  public ViewHelpMenuAdmin() => this.InitializeComponent();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Forms.Cs;component/helpmenuadmin/viewhelpmenuadmin.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target) => this._contentLoaded = true;
}

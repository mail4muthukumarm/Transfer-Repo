// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PreparedXMLViewer.PreparedXMLViewerView
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI.PreparedXMLViewer;

public partial class PreparedXMLViewerView : MgaMdiChild, IComponentConnector
{
  internal WebBrowser XMLView;
  private bool _contentLoaded;

  public PreparedXMLViewerView() => this.InitializeComponent();

  public PreparedXMLViewerView(WinMsgBoxService msg, string importXMLAsString)
  {
    this.InitializeComponent();
    ((FrameworkElement) this).DataContext = (object) PreparedXMLViewerViewModel.Create((IWinMsgBoxService) msg, importXMLAsString);
    this.XMLView.NavigateToString(importXMLAsString);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.Ims.Fortegra.PolicyImport;component/ui/preparedxmlviewer/preparedxmlviewerview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.XMLView = (WebBrowser) target;
    else
      this._contentLoaded = true;
  }
}

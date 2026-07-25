// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.UI.QuoteStatusSystemEventView
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.UI;

public partial class QuoteStatusSystemEventView : MgaMdiChild, IComponentConnector
{
  internal Grid grid;
  private bool _contentLoaded;

  public QuoteStatusSystemEventView() => this.InitializeComponent();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.TechTools;component/quotestatussystemeventadmin/ui/quotestatussystemeventview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.grid = (Grid) target;
    else
      this._contentLoaded = true;
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.DebugHelper.Views.DeveloperDebugHelper
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using Mga.Wpf.Ims.Interop;
using MgaSystems.IMS.Forms.DebugHelper.ViewModels;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Forms.DebugHelper.Views;

public partial class DeveloperDebugHelper : MgaMdiChild, IComponentConnector
{
  internal ListView lstPrimary;
  internal ListView lstInner;
  internal TextBox detailsText;
  internal TextBox fusionLogText;
  private bool _contentLoaded;

  public DeveloperDebugHelper(Exception ex)
  {
    ((FrameworkElement) this).DataContext = (object) new DeveloperDebugHelperViewModel(ex);
    this.InitializeComponent();
  }

  public void lstPrimary_SelectionChanged(object sender, SelectionChangedEventArgs e)
  {
    ListView listView = (ListView) sender;
    if (listView == null || listView.SelectedItems.Count <= 0)
      return;
    this.detailsText.Text = listView.SelectedItems.OfType<KeyValuePair<string, string>>().Select<KeyValuePair<string, string>, string>((Func<KeyValuePair<string, string>, string>) (x => x.Value)).First<string>();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Forms.Cs;component/debughelper/views/developerdebughelper.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.lstPrimary = (ListView) target;
        this.lstPrimary.SelectionChanged += new SelectionChangedEventHandler(this.lstPrimary_SelectionChanged);
        break;
      case 2:
        this.lstInner = (ListView) target;
        break;
      case 3:
        this.detailsText = (TextBox) target;
        break;
      case 4:
        this.fusionLogText = (TextBox) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

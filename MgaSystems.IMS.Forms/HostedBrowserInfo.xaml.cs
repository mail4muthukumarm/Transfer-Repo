// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.HostedBrowserInfo
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.Toolkit.Wpf.UI.Controls;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public partial class HostedBrowserInfo : Window, IComponentConnector
{
  private bool _contentLoaded;

  public HostedBrowserInfo() => this.InitializeComponent();

  private void Button_Click(object sender, RoutedEventArgs e) => this.NavigateToUrl();

  private void NavigateToUrl()
  {
    try
    {
      this.browser.Navigate(this.navigationTextBox.Text);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) System.Windows.Forms.MessageBox.Show(ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void Window_Loaded(object sender, RoutedEventArgs e) => this.NavigateToUrl();

  [field: AccessedThroughProperty("navigationTextBox")]
  internal virtual System.Windows.Controls.TextBox navigationTextBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("browser")]
  internal virtual WebViewCompatible browser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    System.Windows.Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Forms;component/hostedbrowserinfo.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        ((FrameworkElement) target).Loaded += new RoutedEventHandler(this.Window_Loaded);
        break;
      case 2:
        this.navigationTextBox = (System.Windows.Controls.TextBox) target;
        break;
      case 3:
        ((System.Windows.Controls.Primitives.ButtonBase) target).Click += new RoutedEventHandler(this.Button_Click);
        break;
      case 4:
        this.browser = (WebViewCompatible) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

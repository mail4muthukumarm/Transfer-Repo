// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Views.CheckFinderView
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Controls;
using Mga.Wpf.Ims.Interop;
using MgaSystems.IMS.TechTools.ViewModels;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Xceed.Wpf.Toolkit;

#nullable disable
namespace MgaSystems.IMS.TechTools.Views;

public partial class CheckFinderView : MgaMdiChild, IComponentConnector
{
  internal BusyIndicator BusyBar;
  internal MgaDatePicker DpDateFrom;
  internal MgaDatePicker DpDateTo;
  internal CheckBox ChbInvoice;
  internal CheckBox ChbClaims;
  internal CheckBox ChbOperating;
  internal ComboBox CboCheckPrinterSettings;
  internal Button BGetChecks;
  internal Button BConfigureAccountingPrinters;
  internal DataGrid DgChecks;
  private bool _contentLoaded;

  public CheckFinderView() => this.InitializeComponent();

  private async void MgaMdiChild_Loaded(object sender, RoutedEventArgs e)
  {
    await ((CheckFinderViewModel) ((FrameworkElement) this).DataContext).InitializeAsync();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.TechTools;component/views/checkfinderview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        ((FrameworkElement) target).Loaded += new RoutedEventHandler(this.MgaMdiChild_Loaded);
        break;
      case 2:
        this.BusyBar = (BusyIndicator) target;
        break;
      case 3:
        this.DpDateFrom = (MgaDatePicker) target;
        break;
      case 4:
        this.DpDateTo = (MgaDatePicker) target;
        break;
      case 5:
        this.ChbInvoice = (CheckBox) target;
        break;
      case 6:
        this.ChbClaims = (CheckBox) target;
        break;
      case 7:
        this.ChbOperating = (CheckBox) target;
        break;
      case 8:
        this.CboCheckPrinterSettings = (ComboBox) target;
        break;
      case 9:
        this.BGetChecks = (Button) target;
        break;
      case 10:
        this.BConfigureAccountingPrinters = (Button) target;
        break;
      case 11:
        this.DgChecks = (DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

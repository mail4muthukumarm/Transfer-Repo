// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Views.DynamicReportsTestingView
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.ExtensionMethods;
using Mga.Wpf.Ims.Interop;
using MgaSystems.IMS.TechTools.Models;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Xceed.Wpf.Toolkit;

#nullable disable
namespace MgaSystems.IMS.TechTools.Views;

public partial class DynamicReportsTestingView : MgaMdiChild, IComponentConnector
{
  internal BusyIndicator BusyBar;
  internal Grid ContentGrid;
  internal TextBox ControlID;
  internal ComboBox cboQuoteIDs;
  internal CollectionViewSource reportsView;
  internal ComboBox cboTests;
  private bool _contentLoaded;

  public DynamicReportsTestingView() => this.InitializeComponent();

  private void Reports_OnFilter(object sender, FilterEventArgs e)
  {
    e.Accepted = string.IsNullOrEmpty(this.cboTests.Text) || StringExtensions.ContainsCaseInsensitive(((ReportModel) e.Item).TestName, this.cboTests.Text);
  }

  private void CboTests_OnKeyUp(object sender, KeyEventArgs e) => this.reportsView?.View.Refresh();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.TechTools;component/views/dynamicreportstestingview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.BusyBar = (BusyIndicator) target;
        break;
      case 2:
        this.ContentGrid = (Grid) target;
        break;
      case 3:
        this.ControlID = (TextBox) target;
        break;
      case 4:
        this.cboQuoteIDs = (ComboBox) target;
        break;
      case 5:
        this.reportsView = (CollectionViewSource) target;
        this.reportsView.Filter += new FilterEventHandler(this.Reports_OnFilter);
        break;
      case 6:
        this.cboTests = (ComboBox) target;
        this.cboTests.KeyUp += new KeyEventHandler(this.CboTests_OnKeyUp);
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

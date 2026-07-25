// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Views.RaterFinderView
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Controls;
using Mga.Wpf.Ims.Interop;
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

public partial class RaterFinderView : MgaMdiChild, IComponentConnector
{
  internal BusyIndicator BusyBar;
  internal ComboBox CboRatingType;
  internal MgaDatePicker DpDateFrom;
  internal MgaDatePicker DpDateTo;
  internal ComboBox CboByBinding;
  internal ComboBox CboByDescription;
  internal Button BSearch;
  internal DataGrid DgQuoteDetails;
  private bool _contentLoaded;

  public RaterFinderView() => this.InitializeComponent();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.TechTools;component/views/raterfinderview.xaml", UriKind.Relative));
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
        this.CboRatingType = (ComboBox) target;
        break;
      case 3:
        this.DpDateFrom = (MgaDatePicker) target;
        break;
      case 4:
        this.DpDateTo = (MgaDatePicker) target;
        break;
      case 5:
        this.CboByBinding = (ComboBox) target;
        break;
      case 6:
        this.CboByDescription = (ComboBox) target;
        break;
      case 7:
        this.BSearch = (Button) target;
        break;
      case 8:
        this.DgQuoteDetails = (DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.InsCipher.Administration.Windows.MappingConfiguration
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using MgaSystems.IMS.Policies.InsCipher.Administration.Data;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.InsCipher.Administration.Windows;

public partial class MappingConfiguration : MgaMdiChild, IComponentConnector
{
  internal MappingConfiguration mainWindow;
  internal TabControl dataTab;
  internal DataGrid LineCoverageGrid;
  private bool _contentLoaded;

  public MappingConfiguration()
  {
    this.InitializeComponent();
    if (Information.IsDesignMode || !(((DataSourceProvider) ((FrameworkElement) this).FindResource((object) "mapData")).Data is MappingDataManager data))
      return;
    data.InitializeData();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/inscipher/administration/windows/mappingconfiguration.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.mainWindow = (MappingConfiguration) target;
        break;
      case 2:
        this.dataTab = (TabControl) target;
        break;
      case 3:
        this.LineCoverageGrid = (DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

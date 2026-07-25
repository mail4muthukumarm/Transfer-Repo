// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Views.UserTaggingAdmin
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Excel.Views;

public class UserTaggingAdmin : MgaMdiChild, IComponentConnector
{
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal UserTaggingAdmin mainWindow;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal TextBox dataStoreNameFilter;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal ListView dataStoreList;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal DataGrid grid;
  private bool _contentLoaded;

  public UserTaggingAdmin() => this.InitializeComponent();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/views/usertaggingadmin.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.mainWindow = (UserTaggingAdmin) target;
        break;
      case 2:
        this.dataStoreNameFilter = (TextBox) target;
        break;
      case 3:
        this.dataStoreList = (ListView) target;
        break;
      case 4:
        this.grid = (DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

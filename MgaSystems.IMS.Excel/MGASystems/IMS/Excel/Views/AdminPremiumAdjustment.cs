// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Views.AdminPremiumAdjustment
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using MgaSystems.IMS.Excel.Data.PremiumAdmin;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Excel.Views;

public class AdminPremiumAdjustment : MgaMdiChild, IComponentConnector
{
  private bool _contentLoaded;

  public AdminPremiumAdjustment(Guid quoteGuid)
  {
    this.InitializeComponent();
    ((FrameworkElement) this).DataContext = (object) new PremiumDataManager(quoteGuid);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/views/adminpremiumadjustment.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  void IComponentConnector.Connect(int connectionId, object target) => this._contentLoaded = true;
}

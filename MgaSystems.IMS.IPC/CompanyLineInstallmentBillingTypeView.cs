// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.CompanyLineInstallmentBillingTypeView
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Mga.Wpf.Ims.Interop;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class CompanyLineInstallmentBillingTypeView : MgaMdiChild, IComponentConnector
{
  private bool _contentLoaded;

  public CompanyLineInstallmentBillingTypeView() => this.InitializeComponent();

  [field: AccessedThroughProperty("mainWindow")]
  [field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal virtual CompanyLineInstallmentBillingTypeView mainWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.IPC;component/companies/company%20lines/billing%20types/companylineinstallmentbillingtypeview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.mainWindow = (CompanyLineInstallmentBillingTypeView) target;
    else
      this._contentLoaded = true;
  }
}

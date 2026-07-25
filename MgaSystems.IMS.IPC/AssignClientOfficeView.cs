// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.AssignClientOfficeView
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Data.Binding;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class AssignClientOfficeView : MgaMdiChild, IComponentConnector, IStyleConnector
{
  private readonly Guid insuredGuid;
  private bool _contentLoaded;

  public ObservableCollection<InsuredClientOffice> Offices { get; set; }

  public InsuredClientOffice SelectedOffice { get; set; }

  public AssignClientOfficeView Create(
    ObservableCollection<InsuredClientOffice> insuredOffices,
    Guid insuredGuid,
    string insuredName)
  {
    return NotifyProxyTypeManager.Allocate<AssignClientOfficeView>(new object[3]
    {
      (object) insuredOffices,
      (object) insuredGuid,
      (object) insuredName
    });
  }

  public AssignClientOfficeView(
    ObservableCollection<InsuredClientOffice> insuredOffices,
    Guid insuredGd,
    string insuredName)
  {
    this.InitializeComponent();
    this.insuredGuid = insuredGd;
    this.txtInsuredInfo.Text = $"Assign [{insuredName}] --> Available Client Offices";
    this.Offices = insuredOffices;
    ((FrameworkElement) this).DataContext = (object) this;
  }

  private void chkAllowView_Checked(object sender, RoutedEventArgs e)
  {
    if (this.SelectedOffice == null)
      return;
    InsuredClientOffice.UpdateClientOffice(this.insuredGuid, this.SelectedOffice.OfficeGuid, true);
  }

  private void chkAllowView_Unchecked(object sender, RoutedEventArgs e)
  {
    if (this.SelectedOffice == null)
      return;
    InsuredClientOffice.UpdateClientOffice(this.insuredGuid, this.SelectedOffice.OfficeGuid, false);
  }

  [field: AccessedThroughProperty("mainWindow")]
  [field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal virtual AssignClientOfficeView mainWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsuredInfo")]
  [field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal virtual TextBlock txtInsuredInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgClientOffices")]
  [field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal virtual DataGrid dgClientOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.IPC;component/insureds/assign%20client%20offices/assignclientofficeview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.mainWindow = (AssignClientOfficeView) target;
        break;
      case 2:
        this.txtInsuredInfo = (TextBlock) target;
        break;
      case 3:
        this.dgClientOffices = (DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  public void System_Windows_Markup_IStyleConnector_Connect(int connectionId, object target)
  {
    if (connectionId != 4)
      return;
    ((ToggleButton) target).Checked += new RoutedEventHandler(this.chkAllowView_Checked);
    ((ToggleButton) target).Unchecked += new RoutedEventHandler(this.chkAllowView_Unchecked);
  }
}

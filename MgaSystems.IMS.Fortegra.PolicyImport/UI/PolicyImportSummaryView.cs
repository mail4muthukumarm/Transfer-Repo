// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportSummaryView
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI;

[SecureResource("{F92C98DB-0779-4713-A09D-CEB8162686B4}", "Fortegra Policy Import Admin", "Controls access to the policy import tool", "Fortegra")]
public class PolicyImportSummaryView : MgaMdiChild, IComponentConnector, IStyleConnector
{
  public const string AccessSecurityGuid = "{F92C98DB-0779-4713-A09D-CEB8162686B4}";
  private readonly PolicyImportSummaryViewModel policyImportSummaryViewModel = PolicyImportSummaryViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
  internal DataGrid ImportSourceGrid;
  internal DataGrid ImportSummaryGrid;
  private bool _contentLoaded;

  public PolicyImportSummaryView()
  {
    this.InitializeComponent();
    ((FrameworkElement) this).DataContext = (object) this.policyImportSummaryViewModel;
  }

  private void ShowImportPreprocessErrorHandler(object sender, RoutedEventArgs e)
  {
    if (!(((FrameworkElement) this).DataContext is PolicyImportSummaryViewModel dataContext))
      return;
    dataContext.ShowImportPreprocessErrors(sender, e);
  }

  private void MgaMdiChild_Loaded(object sender, RoutedEventArgs e)
  {
    this.policyImportSummaryViewModel.Initialize();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.Ims.Fortegra.PolicyImport;component/ui/policyimportsummary/policyimportsummaryview.xaml", UriKind.Relative));
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
        this.ImportSourceGrid = (DataGrid) target;
        break;
      case 3:
        this.ImportSummaryGrid = (DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IStyleConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 4)
      return;
    ((Style) target).Setters.Add((SetterBase) new EventSetter()
    {
      Event = Hyperlink.ClickEvent,
      Handler = (Delegate) new RoutedEventHandler(this.ShowImportPreprocessErrorHandler)
    });
  }
}

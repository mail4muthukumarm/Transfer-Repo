// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportDetail.PolicyImportDetailView
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MgaSystems.Ims.Fortegra.PolicyImport.Data;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI.PolicyImportDetail;

public partial class PolicyImportDetailView : MgaMdiChild, IComponentConnector
{
  private readonly PolicyImportDetailViewModel policyImportDetailViewModel;
  internal PolicyImportDetailView clos;
  internal System.Windows.Controls.ProgressBar pgExcelToXMLConvert;
  internal System.Windows.Controls.ProgressBar pgImportingFiles;
  internal System.Windows.Controls.DataGrid ImportDetailGrid;
  private bool _contentLoaded;

  public PolicyImportDetailView() => this.InitializeComponent();

  public PolicyImportDetailView(
    WinMsgBoxService msg,
    PolicyImportDataManager pidm,
    ImportSource importSource,
    bool newImportMode)
    : this()
  {
    ((FrameworkElement) this).DataContext = (object) (this.policyImportDetailViewModel = PolicyImportDetailViewModel.Create((IWinMsgBoxService) msg, pidm, importSource, newImportMode));
  }

  public PolicyImportDetailView(
    WinMsgBoxService msg,
    PolicyImportDataManager pidm,
    ImportSource importSource,
    bool newImportMode,
    int importLogID)
    : this()
  {
    ((FrameworkElement) this).DataContext = (object) (this.policyImportDetailViewModel = PolicyImportDetailViewModel.Create((IWinMsgBoxService) msg, pidm, importSource, newImportMode, importLogID));
  }

  protected override void OnFormClosing(FormClosingEventArgs e)
  {
    base.OnFormClosing(e);
    this.policyImportDetailViewModel.CancelAllProcessing();
  }

  private async void MgaMdiChild_Loaded(object sender, RoutedEventArgs e)
  {
    await this.policyImportDetailViewModel.InitializeAsync();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    System.Windows.Application.LoadComponent((object) this, new Uri("/MgaSystems.Ims.Fortegra.PolicyImport;component/ui/policyimportdetail/policyimportdetailview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.clos = (PolicyImportDetailView) target;
        ((FrameworkElement) this.clos).Loaded += new RoutedEventHandler(this.MgaMdiChild_Loaded);
        break;
      case 2:
        this.pgExcelToXMLConvert = (System.Windows.Controls.ProgressBar) target;
        break;
      case 3:
        this.pgImportingFiles = (System.Windows.Controls.ProgressBar) target;
        break;
      case 4:
        this.ImportDetailGrid = (System.Windows.Controls.DataGrid) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

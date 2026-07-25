// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Views.ExcelRatingAdmin2
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.IMS.Excel.Data.Administration2;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Excel.Views;

public class ExcelRatingAdmin2 : MgaMdiChild, IComponentConnector, IStyleConnector
{
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal ExcelRatingAdmin2 mainWindow;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal System.Windows.Controls.TreeView treeView;
  private bool _contentLoaded;

  public ExcelRatingAdmin2() => this.InitializeComponent();

  protected override void OnFormClosing(FormClosingEventArgs e)
  {
    if ((((FrameworkElement) this).DataContext is ExcelAdministrationData dataContext ? (dataContext.IsUploadingSpreadSheet ? 1 : 0) : 0) != 0)
    {
      int num = (int) System.Windows.MessageBox.Show("Please wait until your changes have completed saving", "Save in progress", MessageBoxButton.OK, MessageBoxImage.Asterisk);
      e.Cancel = true;
    }
    base.OnFormClosing(e);
  }

  private void mappingsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
  {
    ExcelAdministrationData dataContext = ((FrameworkElement) this).DataContext as ExcelAdministrationData;
    if (e.RemovedItems.Count > 0)
      dataContext.SelectedExcelMappingList.RemoveAll((Predicate<ExcelMapping>) (m => e.RemovedItems.OfType<ExcelMapping>().Any<ExcelMapping>()));
    if (e.AddedItems.Count <= 0)
      return;
    dataContext.SelectedExcelMappingList.AddRange(e.AddedItems.OfType<ExcelMapping>());
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    System.Windows.Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/views/excelratingadmin2.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId == 2)
        this.treeView = (System.Windows.Controls.TreeView) target;
      else
        this._contentLoaded = true;
    }
    else
      this.mainWindow = (ExcelRatingAdmin2) target;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  void IStyleConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 3)
      return;
    ((Selector) target).SelectionChanged += new SelectionChangedEventHandler(this.mappingsGrid_SelectionChanged);
  }
}

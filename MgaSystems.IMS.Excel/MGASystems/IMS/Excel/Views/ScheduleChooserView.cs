// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Views.ScheduleChooserView
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
using MgaSystems.IMS.Excel.Data.ScheduleChooser;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Excel.Views;

public class ScheduleChooserView : MgaMdiChild, IComponentConnector
{
  private readonly ScheduleChooserDataManager scheduleChooserDataManager;
  private bool _contentLoaded;

  public ScheduleChooserView(
    ScheduleChooserDataManager scheduleChooserDataManager)
  {
    this.scheduleChooserDataManager = scheduleChooserDataManager;
    ((FrameworkElement) this).DataContext = (object) this.scheduleChooserDataManager;
    this.InitializeComponent();
  }

  private void Cancel_Click(object sender, RoutedEventArgs e) => this.Form.Close();

  private void Ok_Click(object sender, RoutedEventArgs e)
  {
    if (!this.scheduleChooserDataManager.IsValid || MessageBox.Show("Are you sure you want to associate this schedule?", "Please confirm association", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
      return;
    object[] objArray1 = new object[10];
    objArray1[0] = (object) "@raterFactorSetGuid";
    objArray1[1] = (object) this.scheduleChooserDataManager.RaterFactorsetGuid;
    objArray1[2] = (object) "@scheduleFactorSetGuid";
    Guid? scheduleFactorSet = this.scheduleChooserDataManager.ScheduleFactorSet;
    objArray1[3] = (object) scheduleFactorSet.Value;
    objArray1[4] = (object) "@rowStartIndex";
    objArray1[5] = (object) this.scheduleChooserDataManager.StartRowIndex;
    objArray1[6] = (object) "@setinelColumnIndex";
    objArray1[7] = (object) this.scheduleChooserDataManager.SetinelColumnIndex;
    objArray1[8] = (object) "@maxRowsToRead";
    objArray1[9] = (object) this.scheduleChooserDataManager.MaxRowsToRead;
    DefaultDatabase.ExecuteNonQuery("ExcelRating_AssociateScheduleToRaterByID", objArray1);
    if (!this.scheduleChooserDataManager.IsGenerateRepeaterTagsChecked)
      return;
    object[] objArray2 = new object[2]
    {
      (object) "@scheduleFactorSetGuid",
      null
    };
    scheduleFactorSet = this.scheduleChooserDataManager.ScheduleFactorSet;
    objArray2[1] = (object) scheduleFactorSet.Value;
    DefaultDatabase.ExecuteNonQuery("ExcelRating_CreateRepeaterTagsForSchedule_Test", objArray2);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/views/schedulechooserview.xaml", UriKind.Relative));
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
        ((ButtonBase) target).Click += new RoutedEventHandler(this.Ok_Click);
      else
        this._contentLoaded = true;
    }
    else
      ((ButtonBase) target).Click += new RoutedEventHandler(this.Cancel_Click);
  }
}

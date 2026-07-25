// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.ExcelFilePicker.ExcelFileList
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Excel.Rating.ExcelFilePicker;

public class ExcelFileList : Window, IComponentConnector
{
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal ListView fileList;
  private bool _contentLoaded;

  public ExcelFileList(ExcelFileListManager excelFileListManager)
  {
    this.InitializeComponent();
    this.DataContext = (object) excelFileListManager;
  }

  private void Button_Click(object sender, RoutedEventArgs e)
  {
    this.DialogResult = new bool?(true);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/rating/excelfilepicker/excelfilelist.xaml", UriKind.Relative));
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
        ((ButtonBase) target).Click += new RoutedEventHandler(this.Button_Click);
      else
        this._contentLoaded = true;
    }
    else
      this.fileList = (ListView) target;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Views.ExternalExcelSaveOptions
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Data.Export;
using MGASystems.IMS.Excel.Data.StandardRating;
using MGASystems.IMS.Excel.Rating;
using MgaSystems.IMS.Excel.Views;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Excel.Views;

public class ExternalExcelSaveOptions : Window, IComponentConnector
{
  private bool onClosingFired;
  private readonly ExcelRater excelRater;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal CheckBox shouldIgnoreMappingErrors;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal ListBox errorList;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal CheckBox shouldUpdateQuote;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal CheckBox shouldCopyToDocHandler;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal Expander mainExpander;
  private bool _contentLoaded;

  public ExcelStandardRatingData RatingData { get; }

  public Guid QuoteGuid { get; }

  public ExternalExcelSaveOptions(ExcelStandardRatingData ratingData, ExcelRater excelRater)
  {
    this.excelRater = excelRater;
    this.RatingData = ratingData;
    this.RatingData.ExcelFile.PropertyChanged += new PropertyChangedEventHandler(this.ExcelFile_PropertyChanged);
    this.DataContext = (object) this.RatingData;
    this.Title = $"MGA Systems Excel Rating [{Path.GetFileName(ratingData.ExcelFile.FullPath)}]";
    this.QuoteGuid = excelRater.QuoteGuid;
    this.InitializeComponent();
    this.shouldCopyToDocHandler.IsChecked = new bool?(SystemSettings.GetSetting<bool>("ExcelRating.DefaultCopyToDocHandler", false));
  }

  protected override void OnClosed(EventArgs e)
  {
    if (!this.onClosingFired)
      DisplayUI.DisplayExternalExcelSaveOptions(this.RatingData, this.excelRater);
    base.OnClosed(e);
  }

  protected override void OnClosing(CancelEventArgs e)
  {
    this.onClosingFired = true;
    base.OnClosing(e);
  }

  private void SaveWithoutExit_Click(object sender, RoutedEventArgs e) => this.Close();

  private void Save_Click(object sender, RoutedEventArgs e)
  {
    if (this.RatingData.ExcelFile.IsDownloading)
      return;
    bool? isChecked = this.shouldIgnoreMappingErrors.IsChecked;
    bool flag1 = false;
    if (isChecked.GetValueOrDefault() == flag1 & isChecked.HasValue)
    {
      isChecked = this.shouldCopyToDocHandler.IsChecked;
      bool flag2 = true;
      if (isChecked.GetValueOrDefault() == flag2 & isChecked.HasValue)
      {
        for (int index = 0; !File.Exists(this.RatingData.ExcelFile.FullPath) && index < 5; ++index)
          Thread.Sleep(TimeSpan.FromSeconds(Math.Pow((double) (index + 1), 3.0) / 20.0));
        if (File.Exists(this.RatingData.ExcelFile.FullPath))
        {
          if (SystemSettings.GetSetting<bool>("ExcelRating.UseDefaultDocumentFolder"))
            DocumentManager.FileAddWithBind(this.RatingData.ExcelFile.FullPath, SystemSettings.GetSetting<int>("ExcelRating.DefaultRatingDocumentFolderID"), string.Empty, (ISupportDocumentSystem) this.excelRater.Quote, true);
          else
            DocumentManager.FileAddWithBind(this.RatingData.ExcelFile.FullPath, (ISupportDocumentSystem) this.excelRater.Quote, true);
        }
        else
        {
          int num = (int) MessageBox.Show($"The file located at {this.RatingData.ExcelFile.FullPath} is currently not accessible and cannot be copied to the document handler.", "Document Handler Copy Interupted", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
      }
    }
    isChecked = this.shouldIgnoreMappingErrors.IsChecked;
    bool flag3 = true;
    if (isChecked.GetValueOrDefault() == flag3 & isChecked.HasValue)
      this.RatingData.ExcelFile.Update(this.RatingData.ExcelMappings, false, this.RatingData.DatabaseTableName);
    else
      this.RatingData.ExcelFile.Update(this.RatingData.ExcelMappings, this.RatingData.DatabaseTableName);
  }

  private void ExcelFile_PropertyChanged(object sender, PropertyChangedEventArgs e)
  {
    if (!(e.PropertyName == "UpdateErrors"))
      return;
    ExcelFile excelFile = (ExcelFile) sender;
    this.excelRater.PrepareAndRateOption(excelFile.HasUpdateErrors);
    if (excelFile.HasUpdateErrors)
      return;
    this.Close();
  }

  private void Hyperlink_Click(object sender, RoutedEventArgs e)
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    bool? nullable = saveFileDialog.ShowDialog();
    bool flag = true;
    if (!(nullable.GetValueOrDefault() == flag & nullable.HasValue))
      return;
    ICollectionView defaultView = CollectionViewSource.GetDefaultView((object) this.errorList.ItemsSource);
    if (defaultView == null)
      return;
    ViewSourceToExcel.Export(defaultView, saveFileDialog.FileName);
  }

  private void Window_Loaded(object sender, RoutedEventArgs e)
  {
    this.mainExpander.IsExpanded = this.RatingData.ExcelFile.HasUpdateErrors;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/views/externalexcelsaveoptions.xaml", UriKind.Relative));
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
        ((FrameworkElement) target).Loaded += new RoutedEventHandler(this.Window_Loaded);
        break;
      case 2:
        this.shouldIgnoreMappingErrors = (CheckBox) target;
        break;
      case 3:
        ((Hyperlink) target).Click += new RoutedEventHandler(this.Hyperlink_Click);
        break;
      case 4:
        this.errorList = (ListBox) target;
        break;
      case 5:
        this.shouldUpdateQuote = (CheckBox) target;
        break;
      case 6:
        this.shouldCopyToDocHandler = (CheckBox) target;
        break;
      case 7:
        this.mainExpander = (Expander) target;
        break;
      case 8:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.Save_Click);
        break;
      case 9:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.SaveWithoutExit_Click);
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

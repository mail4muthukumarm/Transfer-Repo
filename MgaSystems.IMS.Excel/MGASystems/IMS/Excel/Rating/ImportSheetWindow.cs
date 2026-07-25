// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.ImportSheetWindow
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.DragDrop;
using Mga.Wpf.Ims.Notes.Data;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.IMS.Excel.Rating.ExcelFilePicker;
using MGASystems.IMS.NoteDocuments.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Excel.Rating;

public class ImportSheetWindow : Window, IComponentConnector
{
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal Button ImportFromWindowsButton;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal Button ImportFromIMSButton;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal Button EditExistingFileButton;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal Button CancelButton;
  private bool _contentLoaded;

  public ImportSheetWindowResult ButtonResult { get; private set; }

  public ExcelFileListManager ExcelFileListManager { get; private set; }

  public string DroppedFileName { get; private set; }

  public ImportSheetWindow(Quote quote)
  {
    ImportSheetWindow importSheetWindow = this;
    this.InitializeComponent();
    Utility.ExecuteThread((DoWorkEventHandler) ((s, e) =>
    {
      if (Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.FilterEntitiesOnly"))
        e.Result = (object) ExcelFileListManager.FromQuoteId(quote.QuoteID);
      else
        e.Result = (object) ExcelFileListManager.FromControlNo(quote.ControlNo);
    }), (RunWorkerCompletedEventHandler) ((s, e) =>
    {
      importSheetWindow.ExcelFileListManager = e.Result as ExcelFileListManager;
      if (importSheetWindow.ExcelFileListManager == null || importSheetWindow.ExcelFileListManager.ExcelFiles.Count <= 0)
        return;
      importSheetWindow.ImportFromIMSButton.Visibility = Visibility.Visible;
    }), (ProgressChangedEventHandler) null);
  }

  private void Button_Click(object sender, RoutedEventArgs e)
  {
    this.ButtonResult = (ImportSheetWindowResult) Enum.Parse(typeof (ImportSheetWindowResult), ((FrameworkElement) sender).Name);
    this.DialogResult = new bool?(this.ButtonResult != 0);
  }

  private void Window_DragOver(object sender, DragEventArgs e)
  {
    e.Handled = true;
    e.Effects = DragDropEffects.None;
    if (((IEnumerable<string>) e.Data.GetFormats()).Contains<string>(DataFormats.FileDrop) && (e.Data.GetData(DataFormats.FileDrop) is string[] data ? (((IEnumerable<string>) data).Any<string>((Func<string, bool>) (fileName => Path.GetExtension(fileName).StartsWith(".xls", StringComparison.InvariantCultureIgnoreCase))) ? 1 : 0) : 0) != 0)
    {
      e.Effects = DragDropEffects.Copy;
    }
    else
    {
      if (!((IEnumerable<string>) OleData.GetFileNames(e.Data)).Any<string>((Func<string, bool>) (fileName => Path.GetExtension(fileName).StartsWith(".xls", StringComparison.InvariantCultureIgnoreCase))))
        return;
      e.Effects = DragDropEffects.Copy;
    }
  }

  private void Window_Drop(object sender, DragEventArgs e)
  {
    if (((IEnumerable<string>) e.Data.GetFormats()).Contains<string>(DataFormats.FileDrop) && (e.Data.GetData(DataFormats.FileDrop) is string[] data1 ? (((IEnumerable<string>) data1).Any<string>((Func<string, bool>) (fileName => Path.GetExtension(fileName).StartsWith(".xls", StringComparison.InvariantCultureIgnoreCase))) ? 1 : 0) : 0) != 0)
    {
      string path = ((IEnumerable<string>) (e.Data.GetData(DataFormats.FileDrop) as string[])).FirstOrDefault<string>((Func<string, bool>) (fileName => Path.GetExtension(fileName).StartsWith(".xls", StringComparison.InvariantCultureIgnoreCase)));
      if (path == null || !File.Exists(path))
        return;
      this.DroppedFileName = path;
      this.ButtonResult = ImportSheetWindowResult.ImportFromFileDrop;
      this.DialogResult = new bool?(true);
    }
    else
    {
      ByteData byteData = OleData.GetByteData(e.Data).FirstOrDefault<ByteData>((Func<ByteData, bool>) (data => Path.GetExtension(data.FileName).StartsWith(".xls", StringComparison.InvariantCultureIgnoreCase)));
      if (byteData == null)
        return;
      this.DroppedFileName = new Document(Path.GetFileName(byteData.FileName), byteData.GetBytes()).SaveDocumentToTemp();
      this.ButtonResult = ImportSheetWindowResult.ImportFromFileDrop;
      this.DialogResult = new bool?(true);
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/rating/importsheetwindow.xaml", UriKind.Relative));
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
        ((UIElement) target).DragOver += new DragEventHandler(this.Window_DragOver);
        ((UIElement) target).Drop += new DragEventHandler(this.Window_Drop);
        break;
      case 2:
        this.ImportFromWindowsButton = (Button) target;
        this.ImportFromWindowsButton.Click += new RoutedEventHandler(this.Button_Click);
        break;
      case 3:
        this.ImportFromIMSButton = (Button) target;
        this.ImportFromIMSButton.Click += new RoutedEventHandler(this.Button_Click);
        break;
      case 4:
        this.EditExistingFileButton = (Button) target;
        this.EditExistingFileButton.Click += new RoutedEventHandler(this.Button_Click);
        break;
      case 5:
        this.CancelButton = (Button) target;
        this.CancelButton.Click += new RoutedEventHandler(this.Button_Click);
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

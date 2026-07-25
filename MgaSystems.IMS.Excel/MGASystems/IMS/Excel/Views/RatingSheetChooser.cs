// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Views.RatingSheetChooser
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data;
using MGASystems.IMS.Excel.Data;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Excel.Views;

public class RatingSheetChooser : Window, IComponentConnector
{
  private readonly bool renewal;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal RatingSheetChooser mainWindow;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal ListView quoteList;
  private bool _contentLoaded;

  public RatingSheetChooser(ExcelQuoteCollection excelQuotes, bool renewal)
  {
    this.renewal = renewal;
    this.DataContext = (object) excelQuotes;
    this.InitializeComponent();
  }

  private void SaveWithoutExit_Click(object sender, RoutedEventArgs e) => this.Close();

  private void Save_Click(object sender, RoutedEventArgs e)
  {
    if (!(this.quoteList.SelectedItem is ExcelQuote selectedItem))
      return;
    if (this.renewal)
    {
      Guid? nullable = (Guid?) DefaultDatabase.ExecuteScalar(CommandType.Text, "select factorsetguid from tblQuoteDetails where quoteGuid = @quoteGuid and factorsetguid is not null", new object[2]
      {
        (object) "@quoteGuid",
        (object) selectedItem.Parent.DestinationQuoteGuid
      });
      if (nullable.HasValue && nullable.Value != selectedItem.FactorSetGuid)
      {
        if (MessageBox.Show("The spreadsheet you selected to copy does not match the spreadsheet template selected on this quote. Proceed anyway?", "The Spreadsheet template has changed on this renewal", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
          DefaultDatabase.ExecuteNonQuery("ExcelRating_CopyRatingSheetInformation", new object[4]
          {
            (object) "@sourceQuote",
            (object) selectedItem.QuoteGuid,
            (object) "@destinationQuote",
            (object) selectedItem.Parent.DestinationQuoteGuid
          });
      }
      else
        DefaultDatabase.ExecuteNonQuery("ExcelRating_CopyRatingSheetInformation", new object[4]
        {
          (object) "@sourceQuote",
          (object) selectedItem.QuoteGuid,
          (object) "@destinationQuote",
          (object) selectedItem.Parent.DestinationQuoteGuid
        });
    }
    else
      DefaultDatabase.ExecuteNonQuery("ExcelRating_CopyRatingSheetInformation", new object[4]
      {
        (object) "@sourceQuote",
        (object) selectedItem.QuoteGuid,
        (object) "@destinationQuote",
        (object) selectedItem.Parent.DestinationQuoteGuid
      });
    this.Close();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Excel;component/views/ratingsheetchooser.xaml", UriKind.Relative));
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
        this.mainWindow = (RatingSheetChooser) target;
        break;
      case 2:
        this.quoteList = (ListView) target;
        break;
      case 3:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.Save_Click);
        break;
      case 4:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.SaveWithoutExit_Click);
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

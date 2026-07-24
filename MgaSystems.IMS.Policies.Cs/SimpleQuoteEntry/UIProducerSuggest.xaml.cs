// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.UI.ProducerSuggest
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.ValueConverters;
using MGASystems.Common.ErrorHandling;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.UI;

public partial class ProducerSuggest : UserControl, IComponentConnector
{
  private readonly TextBox textBox;
  internal Popup suggestionPopup;
  internal ListBox suggestionList;
  private bool _contentLoaded;

  public object SelectedItem
  {
    get => this.suggestionList.SelectedItem;
    set => this.suggestionList.SelectedItem = value;
  }

  public int SelectedIndex
  {
    get => this.suggestionList.SelectedIndex;
    set => this.suggestionList.SelectedIndex = value;
  }

  public int SuggestionCount => this.suggestionList.Items.Count;

  public bool IsShowing => this.suggestionPopup.IsOpen;

  public bool IsOpenForSuggestions { get; set; }

  public ProducerSuggest(TextBox txtBox)
  {
    this.InitializeComponent();
    this.textBox = txtBox;
    Style style = new Style(typeof (ListBox));
    Trigger trigger1 = new Trigger()
    {
      Property = UIElement.IsMouseOverProperty,
      Value = (object) false
    };
    trigger1.Setters.Add((SetterBase) new Setter(FrameworkElement.MinWidthProperty, (object) new Binding()
    {
      Source = (object) this.textBox,
      Path = new PropertyPath("ActualWidth", Array.Empty<object>()),
      Converter = (IValueConverter) new AdjustDoubleConverter(),
      ConverterParameter = (object) "+20"
    }));
    style.Triggers.Add((TriggerBase) trigger1);
    Trigger trigger2 = new Trigger()
    {
      Property = UIElement.IsMouseOverProperty,
      Value = (object) true
    };
    trigger2.Setters.Add((SetterBase) new Setter(FrameworkElement.MaxWidthProperty, (object) new Binding()
    {
      Source = (object) this.suggestionList,
      Path = new PropertyPath("ActualWidth", Array.Empty<object>())
    }));
    style.Triggers.Add((TriggerBase) trigger2);
    this.suggestionList.Style = style;
    this.suggestionPopup.PlacementTarget = (UIElement) this.textBox;
    this.suggestionPopup.IsOpen = false;
  }

  public void Show(ObservableCollection<SuggestionWithStatus> list)
  {
    try
    {
      if (list.Count > 0 && (this.textBox.IsKeyboardFocusWithin || this.IsKeyboardFocusWithin))
      {
        this.suggestionList.ItemsSource = (IEnumerable) list;
        this.suggestionList.SelectedIndex = 0;
        this.suggestionPopup.IsOpen = true;
        this.IsOpenForSuggestions = true;
      }
      else
        this.Hide();
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
    }
  }

  public void Hide()
  {
    this.suggestionList.ItemsSource = (IEnumerable) null;
    this.suggestionList.SelectedItem = (object) null;
    this.suggestionPopup.IsOpen = false;
    this.IsOpenForSuggestions = false;
  }

  public void ScrollIntoView(object item) => this.suggestionList.ScrollIntoView(item);

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/simplequoteentry/ui/producersuggest.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId == 2)
        this.suggestionList = (ListBox) target;
      else
        this._contentLoaded = true;
    }
    else
      this.suggestionPopup = (Popup) target;
  }
}

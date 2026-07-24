// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.UI.SuggestProducerByLoc
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Data;
using MGASystems.Common;
using MGASystems.Data;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;
using MGASystems.IMS.Security;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.UI;

public class SuggestProducerByLoc : TextBox
{
  protected ProducerSuggest suggestionBox;
  protected string textBoundProperty = string.Empty;
  protected bool isSelectionMade;
  public ObservableCollection<SuggestionWithStatus> suggestionList;
  public BackgroundWorker bwSearch = new BackgroundWorker();
  private System.Timers.Timer withEventsField_runSearchTimer;
  public static readonly DependencyProperty CodeProperty = DependencyProperty.Register(nameof (Code), typeof (string), typeof (SuggestProducerByLoc), (PropertyMetadata) new FrameworkPropertyMetadata((object) string.Empty, new PropertyChangedCallback(SuggestProducerByLoc.OnCodeChanged)));
  public static readonly DependencyProperty SelectedValueProperty = DependencyProperty.Register(nameof (SelectedValue), typeof (object), typeof (SuggestProducerByLoc), (PropertyMetadata) new FrameworkPropertyMetadata((object) null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(SuggestProducerByLoc.OnSelectedValueChanged)));
  public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(nameof (SelectedItem), typeof (object), typeof (SuggestProducerByLoc), (PropertyMetadata) new FrameworkPropertyMetadata((object) null, new PropertyChangedCallback(SuggestProducerByLoc.OnSelectedItemChanged)));
  public static readonly DependencyProperty MaxSuggestionsProperty = DependencyProperty.Register(nameof (MaxSuggestions), typeof (int), typeof (SuggestProducerByLoc), (PropertyMetadata) new FrameworkPropertyMetadata((object) 0, new PropertyChangedCallback(SuggestProducerByLoc.OnMaxSuggestionsChanged)));
  public static readonly DependencyProperty ShowAllWithPercentProperty = DependencyProperty.Register(nameof (ShowAllWithPercent), typeof (bool), typeof (SuggestProducerByLoc), (PropertyMetadata) new FrameworkPropertyMetadata((object) true, new PropertyChangedCallback(SuggestProducerByLoc.OnShowAllWithPercentChanged)));
  protected string searchText = string.Empty;
  private bool lostFocusSearch;
  protected IEnumerable<SuggestItemsSource> suggestSource;
  protected int maxSuggestionsToShow;
  protected bool showAllItems;

  public event EventHandler SuggestionSelected;

  public event EventHandler<RunWorkerCompletedEventArgs> SearchComplete;

  public event EventHandler<RunWorkerCompletedEventArgs> LFSearchComplete;

  public event PropertyChangedEventHandler PropertyChanged;

  private System.Timers.Timer RunSearchTimer
  {
    get => this.withEventsField_runSearchTimer;
    set
    {
      if (this.withEventsField_runSearchTimer != null)
        this.withEventsField_runSearchTimer.Elapsed -= new ElapsedEventHandler(this.runSearchTimer_Elapsed);
      this.withEventsField_runSearchTimer = value;
      if (this.withEventsField_runSearchTimer == null)
        return;
      this.withEventsField_runSearchTimer.Elapsed += new ElapsedEventHandler(this.runSearchTimer_Elapsed);
    }
  }

  public SuggestionWithStatus SelectedSuggestion
  {
    get => (SuggestionWithStatus) this.suggestionBox.SelectedItem;
    set => this.suggestionBox.SelectedItem = (object) value;
  }

  public SuggestProducerByLoc()
  {
    this.Initialized += new EventHandler(this.SuggestProducerByLoc_Initialized);
    this.Loaded += new RoutedEventHandler(this.SuggestProducerByLoc_Loaded);
    this.Unloaded += new RoutedEventHandler(this.SuggestProducerByLoc_Unloaded);
    this.suggestionList = new ObservableCollection<SuggestionWithStatus>();
    this.bwSearch.DoWork += new DoWorkEventHandler(this.bwSearch_DoWork);
    this.bwSearch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bwSearch_RunWorkerCompleted);
    this.bwSearch.WorkerSupportsCancellation = true;
    this.RunSearchTimer = new System.Timers.Timer(500.0)
    {
      AutoReset = false
    };
  }

  public string Code
  {
    get => (string) this.GetValue(SuggestProducerByLoc.CodeProperty);
    set => this.SetValue(SuggestProducerByLoc.CodeProperty, (object) value);
  }

  private static void OnCodeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    (d as SuggestProducerByLoc).UpdateCode(e.NewValue as string);
  }

  public object SelectedValue
  {
    get => this.GetValue(SuggestProducerByLoc.SelectedValueProperty);
    set => this.SetValue(SuggestProducerByLoc.SelectedValueProperty, value);
  }

  private static void OnSelectedValueChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
  {
    SuggestProducerByLoc suggestProducerByLoc = (SuggestProducerByLoc) d;
    string newValue = (string) e.NewValue;
    string str = suggestProducerByLoc.SetTextOnValueChange(newValue);
    if (str == null)
      return;
    suggestProducerByLoc.Text = str;
  }

  public object SelectedItem
  {
    get => this.GetValue(SuggestProducerByLoc.SelectedItemProperty);
    set => this.SetValue(SuggestProducerByLoc.SelectedItemProperty, value);
  }

  private static void OnSelectedItemChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
  {
    SuggestProducerByLoc suggestProducerByLoc = (SuggestProducerByLoc) d;
    if (e.NewValue == null)
      return;
    suggestProducerByLoc.SelectedItem = e.NewValue;
  }

  public int MaxSuggestions
  {
    get => (int) this.GetValue(SuggestProducerByLoc.MaxSuggestionsProperty);
    set => this.SetValue(SuggestProducerByLoc.MaxSuggestionsProperty, (object) value);
  }

  private static void OnMaxSuggestionsChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
  {
  }

  public bool ShowAllWithPercent
  {
    get => (bool) this.GetValue(SuggestProducerByLoc.ShowAllWithPercentProperty);
    set => this.SetValue(SuggestProducerByLoc.ShowAllWithPercentProperty, (object) value);
  }

  private static void OnShowAllWithPercentChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
  {
  }

  private void SuggestProducerByLoc_Initialized(object sender, EventArgs e)
  {
    this.suggestionBox = new ProducerSuggest((TextBox) this);
    Binding binding = BindingOperations.GetBinding((DependencyObject) this, TextBox.TextProperty);
    if (binding != null)
      this.textBoundProperty = binding.Path.Path;
    this.SearchComplete += new EventHandler<RunWorkerCompletedEventArgs>(this.backgroundSearcher_SearchComplete);
  }

  private void SuggestProducerByLoc_Loaded(object sender, EventArgs e) => this.AddEventHandlers();

  private void SuggestProducerByLoc_Unloaded(object sender, RoutedEventArgs e)
  {
    this.RemoveEventHandlers();
  }

  private void SuggestProducerByLoc_PreviewKeyUp(object sender, KeyEventArgs e)
  {
    if (e.Key == Key.Down && !this.suggestionBox.IsShowing)
    {
      this.ShowSuggestions();
      e.Handled = true;
    }
    else if (e.Key == Key.Escape)
    {
      this.suggestionBox.Hide();
      e.Handled = true;
    }
    else
    {
      if (!this.IsTextChanging(e.Key))
        return;
      this.SelectedItem = (object) null;
      this.isSelectionMade = false;
      bool runSearch = this.Text.Length > 0;
      this.OnTextChanged(this.Text, runSearch);
      if (runSearch)
        return;
      this.suggestionBox.Hide();
    }
  }

  private void SuggestProducerByLoc_PreviewKeyDown(object sender, KeyEventArgs e)
  {
    if (!this.suggestionBox.IsShowing)
      return;
    if (e.Key == Key.Up && this.suggestionBox.SelectedIndex > 0)
    {
      --this.suggestionBox.SelectedIndex;
      this.suggestionBox.ScrollIntoView(this.suggestionBox.SelectedItem);
    }
    if (e.Key == Key.Down && this.suggestionBox.SelectedIndex < this.suggestionBox.SuggestionCount - 1)
    {
      ++this.suggestionBox.SelectedIndex;
      this.suggestionBox.ScrollIntoView(this.suggestionBox.SelectedItem);
    }
    if (e.Key != Key.Return && e.Key != Key.Tab)
      return;
    this.OnSuggestionSelected(new EventArgs());
    if (e.Key != Key.Return)
      return;
    e.Handled = true;
  }

  private void SuggestProducerByLoc_MouseLeftButtonUp(object sender, RoutedEventArgs e)
  {
    this.OnSuggestionSelected(new EventArgs());
  }

  private void SuggestProducerByLoc_LostFocus(object sender, RoutedEventArgs e)
  {
    if (this.suggestionBox.IsKeyboardFocusWithin)
      return;
    if (!this.isSelectionMade)
      this.OnLostFocusNoSelection();
    this.suggestionBox.Hide();
  }

  private void OnSuggestionSelected(EventArgs e)
  {
    this.isSelectionMade = true;
    this.OnFocusSelection();
    EventHandler suggestionSelected = this.SuggestionSelected;
    if (suggestionSelected != null)
      suggestionSelected((object) this, e);
    this.suggestionBox.Hide();
    this.CaretIndex = this.Text.Length;
  }

  public event EventHandler CodeHit;

  protected void OnCodeHit(EventArgs e)
  {
    if (this.CodeHit != null)
      this.CodeHit((object) this, e);
    else
      this.SelectedItem = this.SelectedSuggestion.SelectedObject;
  }

  public virtual void ClearValue()
  {
    this.Clear();
    this.ClearCodeData();
    this.SetSearchCode(string.Empty, false, false, this.MaxSuggestions);
    this.isSelectionMade = false;
  }

  public virtual string SetTextOnValueChange(string newValue) => (string) null;

  public virtual void ShowSuggestList()
  {
    this.lostFocusSearch = false;
    this.searchText = "%";
    this.showAllItems = true;
    this.maxSuggestionsToShow = -1;
    this.SearchFieldUpdated(true);
  }

  private void ClearCodeData() => this.Code = string.Empty;

  protected void UpdateCode(string newVal)
  {
    if (!this.Text.Equals(newVal))
      this.Text = newVal;
    this.SetSearchCode(newVal, false, false, this.MaxSuggestions);
  }

  protected void OnTextChanged(string newText, bool runSearch)
  {
    this.Code = newText;
    this.isSelectionMade = false;
    this.SetSearchCode(newText, runSearch, false, this.MaxSuggestions);
  }

  protected void OnLostFocusNoSelection()
  {
    if (this.Text.Trim().Length == 0)
    {
      this.ClearValue();
    }
    else
    {
      if (this.suggestionList != null && this.suggestionList.Count > 0)
      {
        foreach (SuggestionWithStatus suggestion in (Collection<SuggestionWithStatus>) this.suggestionList)
        {
          if (this.Text.Trim().Equals(suggestion.Code))
          {
            this.SelectedSuggestion = suggestion;
            if (this.SelectedSuggestion != null)
            {
              this.Code = this.SelectedSuggestion.Code;
              this.Text = this.SelectedSuggestion.DisplayValue;
              this.OnCodeHit(new EventArgs());
              return;
            }
          }
        }
      }
      this.SetSearchCode(this.Text, true, true, this.MaxSuggestions);
      this.LFSearchComplete += new EventHandler<RunWorkerCompletedEventArgs>(this.backgroundSearcherLF_SearchComplete);
    }
  }

  private void AddEventHandlers()
  {
    this.PreviewKeyDown += new KeyEventHandler(this.SuggestProducerByLoc_PreviewKeyDown);
    this.PreviewKeyUp += new KeyEventHandler(this.SuggestProducerByLoc_PreviewKeyUp);
    this.LostFocus += new RoutedEventHandler(this.SuggestProducerByLoc_LostFocus);
    this.suggestionBox.MouseLeftButtonUp += new MouseButtonEventHandler(this.SuggestProducerByLoc_MouseLeftButtonUp);
  }

  private void RemoveEventHandlers()
  {
    this.PreviewKeyDown -= new KeyEventHandler(this.SuggestProducerByLoc_PreviewKeyDown);
    this.PreviewKeyUp -= new KeyEventHandler(this.SuggestProducerByLoc_PreviewKeyUp);
    this.LostFocus -= new RoutedEventHandler(this.SuggestProducerByLoc_LostFocus);
    this.suggestionBox.MouseLeftButtonUp -= new MouseButtonEventHandler(this.SuggestProducerByLoc_MouseLeftButtonUp);
  }

  protected bool IsTextChanging(Key key)
  {
    switch (key)
    {
      case Key.Cancel:
      case Key.LineFeed:
      case Key.Clear:
      case Key.Return:
      case Key.Pause:
      case Key.Capital:
      case Key.KanaMode:
      case Key.JunjaMode:
      case Key.FinalMode:
      case Key.Escape:
      case Key.ImeConvert:
      case Key.ImeModeChange:
      case Key.Prior:
      case Key.Next:
      case Key.End:
      case Key.Home:
      case Key.Left:
      case Key.Up:
      case Key.Right:
      case Key.Down:
      case Key.Select:
      case Key.Print:
      case Key.Execute:
      case Key.Snapshot:
      case Key.Insert:
      case Key.Help:
      case Key.LWin:
      case Key.RWin:
      case Key.Apps:
      case Key.Sleep:
      case Key.F1:
      case Key.F2:
      case Key.F3:
      case Key.F4:
      case Key.F6:
      case Key.F7:
      case Key.F8:
      case Key.F9:
      case Key.F10:
      case Key.F11:
      case Key.F12:
      case Key.F13:
      case Key.F14:
      case Key.F15:
      case Key.F16:
      case Key.F17:
      case Key.F18:
      case Key.F19:
      case Key.F20:
      case Key.F21:
      case Key.F22:
      case Key.F23:
      case Key.F24:
      case Key.NumLock:
      case Key.Scroll:
      case Key.LeftShift:
      case Key.RightShift:
      case Key.LeftCtrl:
      case Key.RightCtrl:
      case Key.LeftAlt:
      case Key.RightAlt:
      case Key.BrowserBack:
      case Key.BrowserForward:
      case Key.BrowserRefresh:
      case Key.BrowserStop:
      case Key.BrowserSearch:
      case Key.BrowserFavorites:
      case Key.BrowserHome:
      case Key.VolumeMute:
      case Key.VolumeDown:
      case Key.VolumeUp:
      case Key.MediaNextTrack:
      case Key.MediaPreviousTrack:
      case Key.MediaStop:
      case Key.MediaPlayPause:
      case Key.LaunchMail:
      case Key.SelectMedia:
      case Key.LaunchApplication1:
      case Key.LaunchApplication2:
      case Key.ImeProcessed:
      case Key.System:
      case Key.OemAttn:
      case Key.OemFinish:
      case Key.OemCopy:
      case Key.OemAuto:
      case Key.OemEnlw:
      case Key.OemBackTab:
      case Key.Attn:
      case Key.CrSel:
      case Key.ExSel:
      case Key.EraseEof:
      case Key.Play:
      case Key.Zoom:
      case Key.NoName:
      case Key.Pa1:
      case Key.OemClear:
      case Key.DeadCharProcessed:
        return false;
      case Key.Tab:
        return this.suggestionBox.IsShowing;
      default:
        return true;
    }
  }

  protected void OnFocusSelection()
  {
    if (this.SelectedSuggestion == null)
      return;
    this.Code = this.SelectedSuggestion.Code;
    this.Text = this.SelectedSuggestion.DisplayValue;
    this.OnCodeHit(new EventArgs());
  }

  protected void ShowSuggestions() => this.suggestionBox.Show(this.suggestionList);

  public string GetSearchCode() => this.searchText;

  public void SetSearchCode(string value, bool booRunSearch, bool lfSearch, int maxSuggests)
  {
    this.lostFocusSearch = lfSearch;
    this.searchText = value;
    this.showAllItems = this.ShowAllWithPercent && this.searchText == "%";
    this.maxSuggestionsToShow = this.showAllItems || maxSuggests == 0 ? -1 : maxSuggests;
    this.SearchFieldUpdated(booRunSearch);
  }

  public void SetSearchCode(
    string value,
    bool booRunSearch,
    IEnumerable<SuggestItemsSource> sourceList,
    int maxSuggests,
    int itemCount,
    bool lfSearch)
  {
    this.lostFocusSearch = lfSearch;
    this.searchText = value;
    this.showAllItems = this.ShowAllWithPercent && this.searchText == "%";
    this.suggestSource = sourceList;
    this.maxSuggestionsToShow = this.showAllItems || maxSuggests == 0 ? itemCount : maxSuggests;
    this.SearchFieldUpdated(booRunSearch);
  }

  private void bwSearch_DoWork(object sender, DoWorkEventArgs e)
  {
    this.Dispatcher.Invoke((Action) (() => this.suggestionList.Clear()));
    this.BuildSuggestionList();
  }

  public void BuildSuggestionList()
  {
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spSuggestSubmissionProducers", new object[8]
    {
      (object) "@Name",
      (object) this.searchText,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@ViewAllProducers",
      (object) SecurityManager.Instance.AssertPermission(new Guid("{2D117606-DE51-4902-B36F-C415C27F52E0}")),
      (object) "@MaxSuggestions",
      (object) this.maxSuggestionsToShow
    }).Rows)
    {
      SuggestionProducer suggestionProducer = new SuggestionProducer()
      {
        ProducerLocationGuid = row.Field<Guid>("ProducerLocationGuid"),
        ProducerName = row.Field<string>("Name"),
        StatusID = row.Field<byte>("StatusID"),
        ProducerContactID = row.Field<int>("ProducerContactID"),
        ProducerContact = row.Field<string>("ProducerContact"),
        ContactStatusID = row.Field<byte>("ContactStatusID"),
        ProducerContactGuid = row.Field<Guid>("ProducerContactGuid"),
        ProducerLocationID = row.Field<int>("ProducerLocationID")
      };
      SuggestionWithStatus sItem = SuggestionWithStatus.GetSuggestionCodeDescription((object) $"{suggestionProducer.ProducerName} - {suggestionProducer.ProducerContact}", (object) this.searchText);
      sItem.DisplayValue = $"{suggestionProducer.ProducerName} - {suggestionProducer.ProducerContact}";
      sItem.Code = suggestionProducer.ProducerName;
      sItem.SelectedObject = (object) suggestionProducer;
      sItem.StatusID = Math.Max(suggestionProducer.StatusID, suggestionProducer.ContactStatusID);
      this.Dispatcher.Invoke((Action) (() => this.suggestionList.Add(sItem)));
    }
  }

  private void bwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    if (e.Error != null && !Application.Current.Dispatcher.CheckAccess())
      Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (Delegate) new Action<Exception>(this.WorkerThreadException), (object) e.Error);
    if (!this.lostFocusSearch)
      this.OnSearchComplete(e);
    else
      this.OnLostFocusSearchComplete(e);
  }

  private void backgroundSearcher_SearchComplete(object sender, RunWorkerCompletedEventArgs e)
  {
    this.Dispatcher.Invoke((Delegate) new Action(this.ShowSuggestions), (object[]) null);
  }

  protected void SearchFieldUpdated(bool booRunSearch)
  {
    if (this.RunSearchTimer == null)
      return;
    if (booRunSearch)
    {
      if (!this.RunSearchTimer.Enabled)
        this.RunSearchTimer.Enabled = true;
      this.RunSearch();
    }
    else
      this.RunSearchTimer.Enabled = false;
  }

  private void RunSearch()
  {
    this.RunSearchTimer.Stop();
    this.RunSearchTimer.Start();
  }

  private void runSearchTimer_Elapsed(object sender, EventArgs e)
  {
    if (this.bwSearch.IsBusy)
      this.bwSearch.CancelAsync();
    while (this.bwSearch.CancellationPending)
      Thread.Sleep(500);
    this.bwSearch.RunWorkerAsync();
  }

  protected void WorkerThreadException(Exception ex) => ExceptionDispatchInfo.Capture(ex).Throw();

  protected virtual void OnSearchComplete(RunWorkerCompletedEventArgs e)
  {
    EventHandler<RunWorkerCompletedEventArgs> searchComplete = this.SearchComplete;
    if (searchComplete == null)
      return;
    searchComplete((object) this, e);
  }

  protected virtual void OnLostFocusSearchComplete(RunWorkerCompletedEventArgs e)
  {
    EventHandler<RunWorkerCompletedEventArgs> lfSearchComplete = this.LFSearchComplete;
    if (lfSearchComplete == null)
      return;
    lfSearchComplete((object) this, e);
  }

  private void ShowSuggestList_MouseDown(object sender, MouseButtonEventArgs e)
  {
    this.ShowSuggestList();
  }

  public void OnDemandSearch() => this.RunSearch();

  public void CancelTimer()
  {
    if (this.bwSearch != null && this.bwSearch.IsBusy)
      this.bwSearch.CancelAsync();
    if (this.RunSearchTimer != null)
    {
      this.RunSearchTimer.Stop();
      this.RunSearchTimer.Enabled = false;
      this.RunSearchTimer = (System.Timers.Timer) null;
    }
    if (this.bwSearch == null)
      return;
    this.bwSearch.Dispose();
    this.bwSearch = (BackgroundWorker) null;
  }

  public override void OnApplyTemplate()
  {
    base.OnApplyTemplate();
    if (!(this.GetTemplateChild("PART_ShowSuggestionsBorder") is Border templateChild))
      return;
    templateChild.MouseDown += new MouseButtonEventHandler(this.ShowSuggestList_MouseDown);
  }

  private void SuggestBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
  {
    this.ShowSuggestList();
  }

  private void backgroundSearcherLF_SearchComplete(object sender, RunWorkerCompletedEventArgs e)
  {
    if (sender == null)
      return;
    this.Dispatcher.Invoke((Delegate) new Action(this.HandleSuggestionsLF), (object[]) null);
  }

  private void HandleSuggestionsLF()
  {
    if (this.suggestionList != null && this.suggestionList.Count > 0)
    {
      foreach (SuggestionWithStatus suggestion in (Collection<SuggestionWithStatus>) this.suggestionList)
      {
        if (this.Text.Trim().Equals(suggestion.Code))
        {
          this.SelectedSuggestion = suggestion;
          if (this.SelectedSuggestion != null)
          {
            this.Code = this.SelectedSuggestion.Code;
            this.Text = this.SelectedSuggestion.DisplayValue;
            this.LFSearchComplete -= new EventHandler<RunWorkerCompletedEventArgs>(this.backgroundSearcherLF_SearchComplete);
            this.OnCodeHit(new EventArgs());
            return;
          }
        }
      }
    }
    this.LFSearchComplete -= new EventHandler<RunWorkerCompletedEventArgs>(this.backgroundSearcherLF_SearchComplete);
  }
}

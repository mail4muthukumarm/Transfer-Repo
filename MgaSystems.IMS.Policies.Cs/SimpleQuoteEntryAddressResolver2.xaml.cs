// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.AddressResolver2
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry;

public partial class AddressResolver2 : UserControl, IComponentConnector
{
  public static readonly DependencyProperty CountryListProperty = DependencyProperty.Register(nameof (CountryList), typeof (ObservableCollection<ISOCountry>), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) new ObservableCollection<ISOCountry>(), new PropertyChangedCallback(AddressResolver2.OnCountryListChanged)));
  public static readonly DependencyProperty ISOCountryCodeProperty = DependencyProperty.Register(nameof (ISOCountryCode), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnISOCountryCodeChanged)));
  public static readonly DependencyProperty Address1Property = DependencyProperty.Register(nameof (Address1), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnAddress1Changed)));
  public static readonly DependencyProperty Address2Property = DependencyProperty.Register(nameof (Address2), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnAddress2Changed)));
  public static readonly DependencyProperty ZipCodeProperty = DependencyProperty.Register(nameof (ZipCode), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnZipCodeChanged)));
  public static readonly DependencyProperty ZipExtProperty = DependencyProperty.Register(nameof (ZipExt), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnZipExtChanged)));
  public static readonly DependencyProperty CityProperty = DependencyProperty.Register(nameof (City), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnCityChanged)));
  public static readonly DependencyProperty StateProperty = DependencyProperty.Register(nameof (State), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnStateChanged)));
  public static readonly DependencyProperty CountyProperty = DependencyProperty.Register(nameof (County), typeof (string), typeof (AddressResolver2), (PropertyMetadata) new FrameworkPropertyMetadata((object) "", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, new PropertyChangedCallback(AddressResolver2.OnCountyChanged)));
  public static readonly DependencyProperty IsInvalidZipProperty = DependencyProperty.Register(nameof (IsInvalidZip), typeof (bool), typeof (AddressResolver2), new PropertyMetadata((object) false));
  internal AddressResolver2 AddrResolver2;
  internal ComboBox cboCountry;
  internal TextBox txtAddress1;
  internal TextBox txtAddress2;
  internal TextBox txtZip;
  internal TextBox txtZipExt;
  internal TextBox txtCity;
  internal TextBox txtState;
  internal TextBox txtCounty;
  private bool _contentLoaded;

  public ObservableCollection<ISOCountry> CountryList
  {
    get => (ObservableCollection<ISOCountry>) this.GetValue(AddressResolver2.CountryListProperty);
    set => this.SetValue(AddressResolver2.CountryListProperty, (object) value);
  }

  private static void OnCountryListChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    (d as AddressResolver2).cboCountry.ItemsSource = (IEnumerable) e.NewValue;
  }

  public string ISOCountryCode
  {
    get => (string) this.GetValue(AddressResolver2.ISOCountryCodeProperty);
    set => this.SetValue(AddressResolver2.ISOCountryCodeProperty, (object) value);
  }

  private static void OnISOCountryCodeChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateCountry((string) e.NewValue);
  }

  public string Address1
  {
    get => (string) this.GetValue(AddressResolver2.Address1Property);
    set => this.SetValue(AddressResolver2.Address1Property, (object) value);
  }

  private static void OnAddress1Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateAddress1((string) e.NewValue);
  }

  public string Address2
  {
    get => (string) this.GetValue(AddressResolver2.Address2Property);
    set => this.SetValue(AddressResolver2.Address2Property, (object) value);
  }

  private static void OnAddress2Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateAddress2((string) e.NewValue);
  }

  public string ZipCode
  {
    get => (string) this.GetValue(AddressResolver2.ZipCodeProperty);
    set => this.SetValue(AddressResolver2.ZipCodeProperty, (object) value);
  }

  private static void OnZipCodeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    AddressResolver2 addressResolver2 = (AddressResolver2) d;
    string zipCode = (string) e.NewValue;
    if (zipCode == null)
      return;
    if (zipCode.Length == 5)
    {
      ZipResolver zipResolver = new ZipResolver();
      zipResolver.ResolveZipCode(zipCode);
      addressResolver2.City = zipResolver.City;
      addressResolver2.County = zipResolver.County;
      addressResolver2.State = zipResolver.State;
      zipCode = zipResolver.ZipCode;
      addressResolver2.IsInvalidZip = zipResolver.IsUnknownZipCode;
    }
    addressResolver2.UpdateZipCode(zipCode);
  }

  public string ZipExt
  {
    get => (string) this.GetValue(AddressResolver2.ZipExtProperty);
    set => this.SetValue(AddressResolver2.ZipExtProperty, (object) value);
  }

  private static void OnZipExtChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateZipExt((string) e.NewValue);
  }

  public string City
  {
    get => (string) this.GetValue(AddressResolver2.CityProperty);
    set => this.SetValue(AddressResolver2.CityProperty, (object) value);
  }

  private static void OnCityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateCity((string) e.NewValue);
  }

  public string State
  {
    get => (string) this.GetValue(AddressResolver2.StateProperty);
    set => this.SetValue(AddressResolver2.StateProperty, (object) value);
  }

  private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateState((string) e.NewValue);
  }

  public string County
  {
    get => (string) this.GetValue(AddressResolver2.CountyProperty);
    set => this.SetValue(AddressResolver2.CountyProperty, (object) value);
  }

  private static void OnCountyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  {
    ((AddressResolver2) d).UpdateCounty((string) e.NewValue);
  }

  public bool IsInvalidZip
  {
    get => (bool) this.GetValue(AddressResolver2.IsInvalidZipProperty);
    set => this.SetValue(AddressResolver2.IsInvalidZipProperty, (object) value);
  }

  public AddressResolver2() => this.InitializeComponent();

  private void UpdateCountry(string country) => this.cboCountry.SelectedValue = (object) country;

  private void UpdateAddress1(string addr1) => this.txtAddress1.Text = addr1;

  private void UpdateAddress2(string addr2) => this.txtAddress2.Text = addr2;

  private void UpdateZipCode(string zipCode) => this.txtZip.Text = zipCode;

  private void UpdateZipExt(string zipExt) => this.txtZipExt.Text = zipExt;

  private void UpdateCity(string city) => this.txtCity.Text = city;

  private void UpdateState(string state) => this.txtState.Text = state;

  private void UpdateCounty(string county) => this.txtCounty.Text = county;

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/simplequoteentry/addressresolver2.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.AddrResolver2 = (AddressResolver2) target;
        break;
      case 2:
        this.cboCountry = (ComboBox) target;
        break;
      case 3:
        this.txtAddress1 = (TextBox) target;
        break;
      case 4:
        this.txtAddress2 = (TextBox) target;
        break;
      case 5:
        this.txtZip = (TextBox) target;
        break;
      case 6:
        this.txtZipExt = (TextBox) target;
        break;
      case 7:
        this.txtCity = (TextBox) target;
        break;
      case 8:
        this.txtState = (TextBox) target;
        break;
      case 9:
        this.txtCounty = (TextBox) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

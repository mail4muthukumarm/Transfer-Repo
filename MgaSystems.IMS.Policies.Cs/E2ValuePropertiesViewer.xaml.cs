// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.PropertiesViewer
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Data;
using MgaSystems.IMS.Policies.E2Value.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value;

public partial class PropertiesViewer : MgaMdiChild, IComponentConnector
{
  private double _progressValue;
  private const string NetrateQuery = "select DISTINCT nr.Address, nr.City, nr.State StateId, states.State, nr.ZipCode , nr2.SquareFeet from NetRate_Quote_Insur_Quote_Locat nr INNER JOIN tblQuotes tq on nr.QuoteID = tq.NetRate_QuoteID INNER JOIN NetRate_Quote_Insur_Quote_Locat_Premi nr2 on nr.LocationID = nr2.LocationID INNER JOIN lstStates states on nr.State = states.StateID where QuoteGuid = @qg";
  private const string UnderwriterQuery = "select DISTINCT LocationGuid, PhysicalBuildingNo, Address1, Address2, City, ul.State as StateId, states.State, Zip, SqFootage from tblUnderwritingLocations ul INNER JOIN lstStates states on ul.State = states.StateID where QuoteGuid = @qg";
  internal DockPanel MainPanel;
  internal ProgressBar progress;
  private bool _contentLoaded;

  public ObservableCollection<Property> properties { get; set; }

  public PropertiesViewer(Guid quoteGuid)
  {
    EnumerableRowCollection<Property> netrateProperties = PropertiesViewer.GetNetrateProperties(quoteGuid);
    EnumerableRowCollection<Property> underwriterProperties = PropertiesViewer.GetUnderwriterProperties(quoteGuid);
    this.properties = new ObservableCollection<Property>();
    EnumerableRowCollection<Property> second = netrateProperties;
    foreach (Property property in underwriterProperties.Union<Property>((IEnumerable<Property>) second))
      this.properties.Add(property);
    this.InitializeComponent();
  }

  private static EnumerableRowCollection<Property> GetUnderwriterProperties(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, "select DISTINCT LocationGuid, PhysicalBuildingNo, Address1, Address2, City, ul.State as StateId, states.State, Zip, SqFootage from tblUnderwritingLocations ul INNER JOIN lstStates states on ul.State = states.StateID where QuoteGuid = @qg", (CommandArgumentType) 0, new object[2]
    {
      (object) "@qg",
      (object) quoteGuid
    }).AsEnumerable().Select<DataRow, Property>((System.Func<DataRow, Property>) (l =>
    {
      Property underwriterProperties = Property.Create(new EstimateProperty()
      {
        address1 = $"{l.Field<string>("PhysicalBuildingNo")} {l.Field<string>("Address1")}",
        address2 = l.Field<string>("Address2"),
        city = l.Field<string>("City"),
        state = Property.ParseState(l.Field<string>("State")),
        zipcode = l.Field<string>("Zip"),
        total_square_footage = (l.Field<int?>("SqFootage") ?? 1).ToString()
      });
      underwriterProperties.LocationGuid = l.Field<Guid>("LocationGuid");
      underwriterProperties.Source = "UWLocations";
      return underwriterProperties;
    }));
  }

  private static EnumerableRowCollection<Property> GetNetrateProperties(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, "select DISTINCT nr.Address, nr.City, nr.State StateId, states.State, nr.ZipCode , nr2.SquareFeet from NetRate_Quote_Insur_Quote_Locat nr INNER JOIN tblQuotes tq on nr.QuoteID = tq.NetRate_QuoteID INNER JOIN NetRate_Quote_Insur_Quote_Locat_Premi nr2 on nr.LocationID = nr2.LocationID INNER JOIN lstStates states on nr.State = states.StateID where QuoteGuid = @qg", (CommandArgumentType) 0, new object[2]
    {
      (object) "@qg",
      (object) quoteGuid
    }).AsEnumerable().Select<DataRow, Property>((System.Func<DataRow, Property>) (l =>
    {
      Property netrateProperties = Property.Create(new EstimateProperty()
      {
        address1 = l.Field<string>("Address"),
        city = l.Field<string>("City"),
        state = Property.ParseState(l.Field<string>("State")),
        zipcode = l.Field<string>("ZipCode"),
        total_square_footage = l.Field<string>("SquareFeet") ?? "1"
      });
      netrateProperties.LocationGuid = Guid.NewGuid();
      netrateProperties.Source = "Netrate";
      return netrateProperties;
    }));
  }

  private void SelectAll_Click(object sender, RoutedEventArgs e)
  {
    foreach (Property property in (Collection<Property>) this.properties)
      property.Include = true;
  }

  private void DeselectAll_Click(object sender, RoutedEventArgs e)
  {
    foreach (Property property in (Collection<Property>) this.properties)
      property.Include = false;
  }

  private async void GetValues_OnClick(object sender, RoutedEventArgs e)
  {
    this.MainPanel.IsEnabled = false;
    await this.MakeRequets();
    this.MainPanel.IsEnabled = true;
    ((DispatcherObject) this).Dispatcher.Invoke<double>((Func<double>) (() => this.progress.Value = 0.0));
  }

  private async Task MakeRequets()
  {
    RequestMaker requestMaker = new RequestMaker(SystemSettings.GetStringSetting("e2value.username"), SystemSettings.GetStringSetting("e2value.password"));
    ((DispatcherObject) this).Dispatcher.Invoke<double>((Func<double>) (() =>
    {
      ProgressBar progress = this.progress;
      ObservableCollection<Property> properties = this.properties;
      double num1;
      double num2 = num1 = (double) (properties.Count<Property>((System.Func<Property, bool>) (p => p.Include)) * 2);
      progress.Maximum = num1;
      return num2;
    }));
    Dictionary<Property, Task<Response>> dictionary = new Dictionary<Property, Task<Response>>();
    foreach (Property key in this.properties.Where<Property>((System.Func<Property, bool>) (p => p.Include)))
    {
      dictionary.Add(key, requestMaker.prontoLiteCommercialAsync(key.InnerProperty));
      ((DispatcherObject) this).Dispatcher.Invoke<double>((Func<double>) (() => ++this.progress.Value));
    }
    foreach (KeyValuePair<Property, Task<Response>> keyValuePair in dictionary)
    {
      KeyValuePair<Property, Task<Response>> task = keyValuePair;
      Response response = await task.Value;
      if (response.statusSpecified && response.status == Status.failure)
      {
        task.Key.IsErrored = true;
        task.Key.ErrorMessage = response.message;
      }
      else
      {
        task.Key.IsErrored = false;
        task.Key.ErrorMessage = (string) null;
        task.Key.structure_cost_range_low = response.cost_details.structure_cost_range_low.total_replacement_cost;
        task.Key.structure_cost_range_med = response.cost_details.structure_cost_range_med.total_replacement_cost;
        task.Key.structure_cost_range_high = response.cost_details.structure_cost_range_high.total_replacement_cost;
        task.Key.acv_range_low = response.acv.acv_range_low;
        task.Key.acv_range_med = response.acv.acv_range_med;
        task.Key.acv_range_high = response.acv.acv_range_high;
      }
      task.Key.Response = response;
      ((DispatcherObject) this).Dispatcher.Invoke<double>((Func<double>) (() => ++this.progress.Value));
      task = new KeyValuePair<Property, Task<Response>>();
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/e2value/propertiesviewer.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.MainPanel = (DockPanel) target;
        break;
      case 2:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.GetValues_OnClick);
        break;
      case 3:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.SelectAll_Click);
        break;
      case 4:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.DeselectAll_Click);
        break;
      case 5:
        this.progress = (ProgressBar) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}

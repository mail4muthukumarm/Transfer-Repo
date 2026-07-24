// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Services.ISTWatchWebService.ISTWatchWebService
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.Services.ISTWatchWebService;

[GeneratedCode("System.Web.Services", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "ISTWatchWebServiceSoap", Namespace = "http://www.intelligentsearch.com/HostedWebServices/")]
[XmlInclude(typeof (TSearchBase))]
public class ISTWatchWebService : SoapHttpClientProtocol
{
  private SendOrPostCallback wsGetAccountInfoOperationCompleted;
  private SendOrPostCallback wsGetBuildDateOperationCompleted;
  private SendOrPostCallback wsISTWatchOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public ISTWatchWebService()
  {
    this.Url = "https://www.intelligentsearch.com/ISTwatchWS/ISTwatchwebservice.asmx";
    if (this.IsLocalFileSystemWebService(this.Url))
    {
      this.UseDefaultCredentials = true;
      this.useDefaultCredentialsSetExplicitly = false;
    }
    else
      this.useDefaultCredentialsSetExplicitly = true;
  }

  public new string Url
  {
    get => base.Url;
    set
    {
      if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
        base.UseDefaultCredentials = false;
      base.Url = value;
    }
  }

  public new bool UseDefaultCredentials
  {
    get => base.UseDefaultCredentials;
    set
    {
      base.UseDefaultCredentials = value;
      this.useDefaultCredentialsSetExplicitly = true;
    }
  }

  public event wsGetAccountInfoCompletedEventHandler wsGetAccountInfoCompleted;

  public event wsGetBuildDateCompletedEventHandler wsGetBuildDateCompleted;

  public event wsISTWatchCompletedEventHandler wsISTWatchCompleted;

  [SoapDocumentMethod("http://www.intelligentsearch.com/HostedWebServices/wsGetAccountInfo", RequestNamespace = "http://www.intelligentsearch.com/HostedWebServices/", ResponseNamespace = "http://www.intelligentsearch.com/HostedWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public WsAccountInfo wsGetAccountInfo(string username, string password)
  {
    return (WsAccountInfo) this.Invoke(nameof (wsGetAccountInfo), new object[2]
    {
      (object) username,
      (object) password
    })[0];
  }

  public void wsGetAccountInfoAsync(string username, string password)
  {
    this.wsGetAccountInfoAsync(username, password, (object) null);
  }

  public void wsGetAccountInfoAsync(string username, string password, object userState)
  {
    if (this.wsGetAccountInfoOperationCompleted == null)
      this.wsGetAccountInfoOperationCompleted = new SendOrPostCallback(this.OnwsGetAccountInfoOperationCompleted);
    this.InvokeAsync("wsGetAccountInfo", new object[2]
    {
      (object) username,
      (object) password
    }, this.wsGetAccountInfoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnwsGetAccountInfoOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.wsGetAccountInfoCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    wsGetAccountInfoCompletedEventHandler infoCompletedEvent = this.wsGetAccountInfoCompletedEvent;
    if (infoCompletedEvent == null)
      return;
    infoCompletedEvent((object) this, new wsGetAccountInfoCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.intelligentsearch.com/HostedWebServices/wsGetBuildDate", RequestNamespace = "http://www.intelligentsearch.com/HostedWebServices/", ResponseNamespace = "http://www.intelligentsearch.com/HostedWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string wsGetBuildDate()
  {
    return Conversions.ToString(this.Invoke(nameof (wsGetBuildDate), new object[0])[0]);
  }

  public void wsGetBuildDateAsync() => this.wsGetBuildDateAsync((object) null);

  public void wsGetBuildDateAsync(object userState)
  {
    if (this.wsGetBuildDateOperationCompleted == null)
      this.wsGetBuildDateOperationCompleted = new SendOrPostCallback(this.OnwsGetBuildDateOperationCompleted);
    this.InvokeAsync("wsGetBuildDate", new object[0], this.wsGetBuildDateOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnwsGetBuildDateOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.wsGetBuildDateCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    wsGetBuildDateCompletedEventHandler dateCompletedEvent = this.wsGetBuildDateCompletedEvent;
    if (dateCompletedEvent == null)
      return;
    dateCompletedEvent((object) this, new wsGetBuildDateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.intelligentsearch.com/HostedWebServices/wsISTWatch", RequestNamespace = "http://www.intelligentsearch.com/HostedWebServices/", ResponseNamespace = "http://www.intelligentsearch.com/HostedWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public WsIstWatch[] wsISTWatch(
    string username,
    string password,
    string name,
    string street,
    string city,
    string country,
    string score_threshold,
    string maximum_results,
    string search_lists,
    string search_rulebase,
    string exclude_vessel,
    string include_alias,
    string extended_search,
    string search_range,
    string sanct_countries_search)
  {
    return (WsIstWatch[]) this.Invoke(nameof (wsISTWatch), new object[15]
    {
      (object) username,
      (object) password,
      (object) name,
      (object) street,
      (object) city,
      (object) country,
      (object) score_threshold,
      (object) maximum_results,
      (object) search_lists,
      (object) search_rulebase,
      (object) exclude_vessel,
      (object) include_alias,
      (object) extended_search,
      (object) search_range,
      (object) sanct_countries_search
    })[0];
  }

  public void wsISTWatchAsync(
    string username,
    string password,
    string name,
    string street,
    string city,
    string country,
    string score_threshold,
    string maximum_results,
    string search_lists,
    string search_rulebase,
    string exclude_vessel,
    string include_alias,
    string extended_search,
    string search_range,
    string sanct_countries_search)
  {
    this.wsISTWatchAsync(username, password, name, street, city, country, score_threshold, maximum_results, search_lists, search_rulebase, exclude_vessel, include_alias, extended_search, search_range, sanct_countries_search, (object) null);
  }

  public void wsISTWatchAsync(
    string username,
    string password,
    string name,
    string street,
    string city,
    string country,
    string score_threshold,
    string maximum_results,
    string search_lists,
    string search_rulebase,
    string exclude_vessel,
    string include_alias,
    string extended_search,
    string search_range,
    string sanct_countries_search,
    object userState)
  {
    if (this.wsISTWatchOperationCompleted == null)
      this.wsISTWatchOperationCompleted = new SendOrPostCallback(this.OnwsISTWatchOperationCompleted);
    this.InvokeAsync("wsISTWatch", new object[15]
    {
      (object) username,
      (object) password,
      (object) name,
      (object) street,
      (object) city,
      (object) country,
      (object) score_threshold,
      (object) maximum_results,
      (object) search_lists,
      (object) search_rulebase,
      (object) exclude_vessel,
      (object) include_alias,
      (object) extended_search,
      (object) search_range,
      (object) sanct_countries_search
    }, this.wsISTWatchOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnwsISTWatchOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.wsISTWatchCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    wsISTWatchCompletedEventHandler watchCompletedEvent = this.wsISTWatchCompletedEvent;
    if (watchCompletedEvent == null)
      return;
    watchCompletedEvent((object) this, new wsISTWatchCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  public new void CancelAsync(object userState)
  {
    base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
  }

  private bool IsLocalFileSystemWebService(string url)
  {
    bool flag;
    if (url == null || (object) url == (object) string.Empty)
    {
      flag = false;
    }
    else
    {
      Uri uri = new Uri(url);
      flag = uri.Port >= 1024 /*0x0400*/ && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
    return flag;
  }
}

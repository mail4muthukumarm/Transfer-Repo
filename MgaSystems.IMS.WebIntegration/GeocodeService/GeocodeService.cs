// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.GeocodeService
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using MgaSystems.IMS.WebIntegration.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.GeocodeService;

[GeneratedCode("System.Web.Services", "4.7.2046.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "BasicHttpBinding_IGeocodeService", Namespace = "http://dev.virtualearth.net/webservices/v1/geocode")]
[XmlInclude(typeof (ResponseBase))]
[XmlInclude(typeof (RequestBase))]
public class GeocodeService : SoapHttpClientProtocol
{
  private SendOrPostCallback GeocodeOperationCompleted;
  private SendOrPostCallback ReverseGeocodeOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public GeocodeService()
  {
    this.Url = Settings.Default.MgaSystems_IMS_WebIntegration_GeocodeService_GeocodeService;
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

  public event GeocodeCompletedEventHandler GeocodeCompleted;

  public event ReverseGeocodeCompletedEventHandler ReverseGeocodeCompleted;

  [SoapDocumentMethod("http://dev.virtualearth.net/webservices/v1/geocode/contracts/IGeocodeService/Geocode", RequestNamespace = "http://dev.virtualearth.net/webservices/v1/geocode/contracts", ResponseNamespace = "http://dev.virtualearth.net/webservices/v1/geocode/contracts", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public GeocodeResponse Geocode([XmlElement(IsNullable = true)] GeocodeRequest request)
  {
    return (GeocodeResponse) this.Invoke(nameof (Geocode), new object[1]
    {
      (object) request
    })[0];
  }

  public void GeocodeAsync(GeocodeRequest request) => this.GeocodeAsync(request, (object) null);

  public void GeocodeAsync(GeocodeRequest request, object userState)
  {
    if (this.GeocodeOperationCompleted == null)
      this.GeocodeOperationCompleted = new SendOrPostCallback(this.OnGeocodeOperationCompleted);
    this.InvokeAsync("Geocode", new object[1]
    {
      (object) request
    }, this.GeocodeOperationCompleted, userState);
  }

  private void OnGeocodeOperationCompleted(object arg)
  {
    if (this.GeocodeCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.GeocodeCompleted((object) this, new GeocodeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  [SoapDocumentMethod("http://dev.virtualearth.net/webservices/v1/geocode/contracts/IGeocodeService/ReverseGeocode", RequestNamespace = "http://dev.virtualearth.net/webservices/v1/geocode/contracts", ResponseNamespace = "http://dev.virtualearth.net/webservices/v1/geocode/contracts", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public GeocodeResponse ReverseGeocode([XmlElement(IsNullable = true)] ReverseGeocodeRequest request)
  {
    return (GeocodeResponse) this.Invoke(nameof (ReverseGeocode), new object[1]
    {
      (object) request
    })[0];
  }

  public void ReverseGeocodeAsync(ReverseGeocodeRequest request)
  {
    this.ReverseGeocodeAsync(request, (object) null);
  }

  public void ReverseGeocodeAsync(ReverseGeocodeRequest request, object userState)
  {
    if (this.ReverseGeocodeOperationCompleted == null)
      this.ReverseGeocodeOperationCompleted = new SendOrPostCallback(this.OnReverseGeocodeOperationCompleted);
    this.InvokeAsync("ReverseGeocode", new object[1]
    {
      (object) request
    }, this.ReverseGeocodeOperationCompleted, userState);
  }

  private void OnReverseGeocodeOperationCompleted(object arg)
  {
    if (this.ReverseGeocodeCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.ReverseGeocodeCompleted((object) this, new ReverseGeocodeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  public new void CancelAsync(object userState) => base.CancelAsync(userState);

  private bool IsLocalFileSystemWebService(string url)
  {
    if (url == null || url == string.Empty)
      return false;
    Uri uri = new Uri(url);
    return uri.Port >= 1024 /*0x0400*/ && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
  }
}

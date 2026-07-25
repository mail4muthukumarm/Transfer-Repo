// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.ImageryService
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
namespace MgaSystems.IMS.WebIntegration.ImageryService;

[GeneratedCode("System.Web.Services", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "BasicHttpBinding_IImageryService", Namespace = "http://dev.virtualearth.net/webservices/v1/imagery")]
[XmlInclude(typeof (ResponseBase))]
[XmlInclude(typeof (RequestBase))]
public class ImageryService : SoapHttpClientProtocol
{
  private SendOrPostCallback GetImageryMetadataOperationCompleted;
  private SendOrPostCallback GetMapUriOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public ImageryService()
  {
    this.Url = Settings.Default.MgaSystems_IMS_WebIntegration_ImageryService_ImageryService;
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

  public event GetImageryMetadataCompletedEventHandler GetImageryMetadataCompleted;

  public event GetMapUriCompletedEventHandler GetMapUriCompleted;

  [SoapDocumentMethod("http://dev.virtualearth.net/webservices/v1/imagery/contracts/IImageryService/GetImageryMetadata", RequestNamespace = "http://dev.virtualearth.net/webservices/v1/imagery/contracts", ResponseNamespace = "http://dev.virtualearth.net/webservices/v1/imagery/contracts", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public ImageryMetadataResponse GetImageryMetadata([XmlElement(IsNullable = true)] ImageryMetadataRequest request)
  {
    return (ImageryMetadataResponse) this.Invoke(nameof (GetImageryMetadata), new object[1]
    {
      (object) request
    })[0];
  }

  public void GetImageryMetadataAsync(ImageryMetadataRequest request)
  {
    this.GetImageryMetadataAsync(request, (object) null);
  }

  public void GetImageryMetadataAsync(ImageryMetadataRequest request, object userState)
  {
    if (this.GetImageryMetadataOperationCompleted == null)
      this.GetImageryMetadataOperationCompleted = new SendOrPostCallback(this.OnGetImageryMetadataOperationCompleted);
    this.InvokeAsync("GetImageryMetadata", new object[1]
    {
      (object) request
    }, this.GetImageryMetadataOperationCompleted, userState);
  }

  private void OnGetImageryMetadataOperationCompleted(object arg)
  {
    if (this.GetImageryMetadataCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.GetImageryMetadataCompleted((object) this, new GetImageryMetadataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  [SoapDocumentMethod("http://dev.virtualearth.net/webservices/v1/imagery/contracts/IImageryService/GetMapUri", RequestNamespace = "http://dev.virtualearth.net/webservices/v1/imagery/contracts", ResponseNamespace = "http://dev.virtualearth.net/webservices/v1/imagery/contracts", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public MapUriResponse GetMapUri([XmlElement(IsNullable = true)] MapUriRequest request)
  {
    return (MapUriResponse) this.Invoke(nameof (GetMapUri), new object[1]
    {
      (object) request
    })[0];
  }

  public void GetMapUriAsync(MapUriRequest request) => this.GetMapUriAsync(request, (object) null);

  public void GetMapUriAsync(MapUriRequest request, object userState)
  {
    if (this.GetMapUriOperationCompleted == null)
      this.GetMapUriOperationCompleted = new SendOrPostCallback(this.OnGetMapUriOperationCompleted);
    this.InvokeAsync("GetMapUri", new object[1]
    {
      (object) request
    }, this.GetMapUriOperationCompleted, userState);
  }

  private void OnGetMapUriOperationCompleted(object arg)
  {
    if (this.GetMapUriCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.GetMapUriCompleted((object) this, new GetMapUriCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
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

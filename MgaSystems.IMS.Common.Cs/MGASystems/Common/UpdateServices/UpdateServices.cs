// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UpdateServices.UpdateServices
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

#nullable disable
namespace MGASystems.Common.UpdateServices;

[GeneratedCode("System.Web.Services", "4.8.9032.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "UpdateServicesSoap", Namespace = "http://MGASystems.com")]
public class UpdateServices : SoapHttpClientProtocol
{
  private SendOrPostCallback GetAvailableUpdatesOperationCompleted;
  private SendOrPostCallback GetRequestedUpdatesOperationCompleted;
  private SendOrPostCallback LogCentralPointEntryOperationCompleted;
  private SendOrPostCallback GetPreReleaseUpdatesOperationCompleted;
  private SendOrPostCallback VerifyUpdaterOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public UpdateServices()
  {
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

  public event GetAvailableUpdatesCompletedEventHandler GetAvailableUpdatesCompleted;

  public event GetRequestedUpdatesCompletedEventHandler GetRequestedUpdatesCompleted;

  public event LogCentralPointEntryCompletedEventHandler LogCentralPointEntryCompleted;

  public event GetPreReleaseUpdatesCompletedEventHandler GetPreReleaseUpdatesCompleted;

  public event VerifyUpdaterCompletedEventHandler VerifyUpdaterCompleted;

  [SoapDocumentMethod("http://MGASystems.com/GetAvailableUpdates", RequestNamespace = "http://MGASystems.com", ResponseNamespace = "http://MGASystems.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public FileInformation[] GetAvailableUpdates(Guid cdKey, FileInformation[] fileCollection)
  {
    return (FileInformation[]) this.Invoke(nameof (GetAvailableUpdates), new object[2]
    {
      (object) cdKey,
      (object) fileCollection
    })[0];
  }

  public void GetAvailableUpdatesAsync(Guid cdKey, FileInformation[] fileCollection)
  {
    this.GetAvailableUpdatesAsync(cdKey, fileCollection, (object) null);
  }

  public void GetAvailableUpdatesAsync(
    Guid cdKey,
    FileInformation[] fileCollection,
    object userState)
  {
    if (this.GetAvailableUpdatesOperationCompleted == null)
      this.GetAvailableUpdatesOperationCompleted = new SendOrPostCallback(this.OnGetAvailableUpdatesOperationCompleted);
    this.InvokeAsync("GetAvailableUpdates", new object[2]
    {
      (object) cdKey,
      (object) fileCollection
    }, this.GetAvailableUpdatesOperationCompleted, userState);
  }

  private void OnGetAvailableUpdatesOperationCompleted(object arg)
  {
    if (this.GetAvailableUpdatesCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.GetAvailableUpdatesCompleted((object) this, new GetAvailableUpdatesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  [SoapDocumentMethod("http://MGASystems.com/GetRequestedUpdates", RequestNamespace = "http://MGASystems.com", ResponseNamespace = "http://MGASystems.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public FileInformation[] GetRequestedUpdates(Guid cdKey, FileInformation[] fileCollection)
  {
    return (FileInformation[]) this.Invoke(nameof (GetRequestedUpdates), new object[2]
    {
      (object) cdKey,
      (object) fileCollection
    })[0];
  }

  public void GetRequestedUpdatesAsync(Guid cdKey, FileInformation[] fileCollection)
  {
    this.GetRequestedUpdatesAsync(cdKey, fileCollection, (object) null);
  }

  public void GetRequestedUpdatesAsync(
    Guid cdKey,
    FileInformation[] fileCollection,
    object userState)
  {
    if (this.GetRequestedUpdatesOperationCompleted == null)
      this.GetRequestedUpdatesOperationCompleted = new SendOrPostCallback(this.OnGetRequestedUpdatesOperationCompleted);
    this.InvokeAsync("GetRequestedUpdates", new object[2]
    {
      (object) cdKey,
      (object) fileCollection
    }, this.GetRequestedUpdatesOperationCompleted, userState);
  }

  private void OnGetRequestedUpdatesOperationCompleted(object arg)
  {
    if (this.GetRequestedUpdatesCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.GetRequestedUpdatesCompleted((object) this, new GetRequestedUpdatesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  [SoapDocumentMethod("http://MGASystems.com/LogCentralPointEntry", RequestNamespace = "http://MGASystems.com", ResponseNamespace = "http://MGASystems.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void LogCentralPointEntry(Guid cdKey, int fileCount)
  {
    this.Invoke(nameof (LogCentralPointEntry), new object[2]
    {
      (object) cdKey,
      (object) fileCount
    });
  }

  public void LogCentralPointEntryAsync(Guid cdKey, int fileCount)
  {
    this.LogCentralPointEntryAsync(cdKey, fileCount, (object) null);
  }

  public void LogCentralPointEntryAsync(Guid cdKey, int fileCount, object userState)
  {
    if (this.LogCentralPointEntryOperationCompleted == null)
      this.LogCentralPointEntryOperationCompleted = new SendOrPostCallback(this.OnLogCentralPointEntryOperationCompleted);
    this.InvokeAsync("LogCentralPointEntry", new object[2]
    {
      (object) cdKey,
      (object) fileCount
    }, this.LogCentralPointEntryOperationCompleted, userState);
  }

  private void OnLogCentralPointEntryOperationCompleted(object arg)
  {
    if (this.LogCentralPointEntryCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.LogCentralPointEntryCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  [SoapDocumentMethod("http://MGASystems.com/GetPreReleaseUpdates", RequestNamespace = "http://MGASystems.com", ResponseNamespace = "http://MGASystems.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public FileInformation[] GetPreReleaseUpdates(Guid cdKey, FileInformation[] fileCollection)
  {
    return (FileInformation[]) this.Invoke(nameof (GetPreReleaseUpdates), new object[2]
    {
      (object) cdKey,
      (object) fileCollection
    })[0];
  }

  public void GetPreReleaseUpdatesAsync(Guid cdKey, FileInformation[] fileCollection)
  {
    this.GetPreReleaseUpdatesAsync(cdKey, fileCollection, (object) null);
  }

  public void GetPreReleaseUpdatesAsync(
    Guid cdKey,
    FileInformation[] fileCollection,
    object userState)
  {
    if (this.GetPreReleaseUpdatesOperationCompleted == null)
      this.GetPreReleaseUpdatesOperationCompleted = new SendOrPostCallback(this.OnGetPreReleaseUpdatesOperationCompleted);
    this.InvokeAsync("GetPreReleaseUpdates", new object[2]
    {
      (object) cdKey,
      (object) fileCollection
    }, this.GetPreReleaseUpdatesOperationCompleted, userState);
  }

  private void OnGetPreReleaseUpdatesOperationCompleted(object arg)
  {
    if (this.GetPreReleaseUpdatesCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.GetPreReleaseUpdatesCompleted((object) this, new GetPreReleaseUpdatesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
  }

  [SoapDocumentMethod("http://MGASystems.com/VerifyUpdater", RequestNamespace = "http://MGASystems.com", ResponseNamespace = "http://MGASystems.com", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public UpdateFileInformation[] VerifyUpdater(string version, Guid cdKey)
  {
    return (UpdateFileInformation[]) this.Invoke(nameof (VerifyUpdater), new object[2]
    {
      (object) version,
      (object) cdKey
    })[0];
  }

  public void VerifyUpdaterAsync(string version, Guid cdKey)
  {
    this.VerifyUpdaterAsync(version, cdKey, (object) null);
  }

  public void VerifyUpdaterAsync(string version, Guid cdKey, object userState)
  {
    if (this.VerifyUpdaterOperationCompleted == null)
      this.VerifyUpdaterOperationCompleted = new SendOrPostCallback(this.OnVerifyUpdaterOperationCompleted);
    this.InvokeAsync("VerifyUpdater", new object[2]
    {
      (object) version,
      (object) cdKey
    }, this.VerifyUpdaterOperationCompleted, userState);
  }

  private void OnVerifyUpdaterOperationCompleted(object arg)
  {
    if (this.VerifyUpdaterCompleted == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    this.VerifyUpdaterCompleted((object) this, new VerifyUpdaterCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
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

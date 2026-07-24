// Decompiled with JetBrains decompiler
// Type: CancellationNotices.LogonService.Logon
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

#nullable disable
namespace CancellationNotices.LogonService;

[GeneratedCode("System.Web.Services", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "LogonSoap", Namespace = "http://tempuri.org/IMSWebServices/Logon")]
public class Logon : SoapHttpClientProtocol
{
  private SendOrPostCallback LoginOperationCompleted;
  private TokenHeader tokenHeaderValueField;
  private SendOrPostCallback GetUserInfoOperationCompleted;
  private SendOrPostCallback LoginUserOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public Logon()
  {
    this.Url = "http://webservices.mgasystems.com/ims_dmi/logon.asmx";
    if (this.IsLocalFileSystemWebService(this.Url))
    {
      this.UseDefaultCredentials = true;
      this.useDefaultCredentialsSetExplicitly = false;
    }
    else
      this.useDefaultCredentialsSetExplicitly = true;
  }

  public TokenHeader TokenHeaderValue
  {
    get => this.tokenHeaderValueField;
    set => this.tokenHeaderValueField = value;
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

  public event LoginCompletedEventHandler LoginCompleted;

  public event GetUserInfoCompletedEventHandler GetUserInfoCompleted;

  public event LoginUserCompletedEventHandler LoginUserCompleted;

  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/Logon/Login", RequestNamespace = "http://tempuri.org/IMSWebServices/Logon", ResponseNamespace = "http://tempuri.org/IMSWebServices/Logon", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public LoginReturn Login(
    string programCode,
    string contactType,
    string email,
    string password,
    string projectName)
  {
    return (LoginReturn) this.Invoke(nameof (Login), new object[5]
    {
      (object) programCode,
      (object) contactType,
      (object) email,
      (object) password,
      (object) projectName
    })[0];
  }

  public IAsyncResult BeginLogin(
    string programCode,
    string contactType,
    string email,
    string password,
    string projectName,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("Login", new object[5]
    {
      (object) programCode,
      (object) contactType,
      (object) email,
      (object) password,
      (object) projectName
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public LoginReturn EndLogin(IAsyncResult asyncResult)
  {
    return (LoginReturn) this.EndInvoke(asyncResult)[0];
  }

  public void LoginAsync(
    string programCode,
    string contactType,
    string email,
    string password,
    string projectName)
  {
    this.LoginAsync(programCode, contactType, email, password, projectName, (object) null);
  }

  public void LoginAsync(
    string programCode,
    string contactType,
    string email,
    string password,
    string projectName,
    object userState)
  {
    if (this.LoginOperationCompleted == null)
      this.LoginOperationCompleted = new SendOrPostCallback(this.OnLoginOperationCompleted);
    this.InvokeAsync("Login", new object[5]
    {
      (object) programCode,
      (object) contactType,
      (object) email,
      (object) password,
      (object) projectName
    }, this.LoginOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnLoginOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.LoginCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    LoginCompletedEventHandler loginCompletedEvent = this.LoginCompletedEvent;
    if (loginCompletedEvent == null)
      return;
    loginCompletedEvent((object) this, new LoginCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/Logon/GetUserInfo", RequestNamespace = "http://tempuri.org/IMSWebServices/Logon", ResponseNamespace = "http://tempuri.org/IMSWebServices/Logon", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public Guid GetUserInfo(string username, string password)
  {
    object obj = this.Invoke(nameof (GetUserInfo), new object[2]
    {
      (object) username,
      (object) password
    })[0];
    return obj == null ? new Guid() : (Guid) obj;
  }

  public IAsyncResult BeginGetUserInfo(
    string username,
    string password,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetUserInfo", new object[2]
    {
      (object) username,
      (object) password
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public Guid EndGetUserInfo(IAsyncResult asyncResult)
  {
    object obj = this.EndInvoke(asyncResult)[0];
    return obj == null ? new Guid() : (Guid) obj;
  }

  public void GetUserInfoAsync(string username, string password)
  {
    this.GetUserInfoAsync(username, password, (object) null);
  }

  public void GetUserInfoAsync(string username, string password, object userState)
  {
    if (this.GetUserInfoOperationCompleted == null)
      this.GetUserInfoOperationCompleted = new SendOrPostCallback(this.OnGetUserInfoOperationCompleted);
    this.InvokeAsync("GetUserInfo", new object[2]
    {
      (object) username,
      (object) password
    }, this.GetUserInfoOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetUserInfoOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetUserInfoCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetUserInfoCompletedEventHandler infoCompletedEvent = this.GetUserInfoCompletedEvent;
    if (infoCompletedEvent == null)
      return;
    infoCompletedEvent((object) this, new GetUserInfoCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/Logon/LoginUser", RequestNamespace = "http://tempuri.org/IMSWebServices/Logon", ResponseNamespace = "http://tempuri.org/IMSWebServices/Logon", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public Guid LoginUser(string userName, string tripleDESEncryptedPassword)
  {
    object obj = this.Invoke(nameof (LoginUser), new object[2]
    {
      (object) userName,
      (object) tripleDESEncryptedPassword
    })[0];
    return obj == null ? new Guid() : (Guid) obj;
  }

  public IAsyncResult BeginLoginUser(
    string userName,
    string tripleDESEncryptedPassword,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("LoginUser", new object[2]
    {
      (object) userName,
      (object) tripleDESEncryptedPassword
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public Guid EndLoginUser(IAsyncResult asyncResult)
  {
    object obj = this.EndInvoke(asyncResult)[0];
    return obj == null ? new Guid() : (Guid) obj;
  }

  public void LoginUserAsync(string userName, string tripleDESEncryptedPassword)
  {
    this.LoginUserAsync(userName, tripleDESEncryptedPassword, (object) null);
  }

  public void LoginUserAsync(string userName, string tripleDESEncryptedPassword, object userState)
  {
    if (this.LoginUserOperationCompleted == null)
      this.LoginUserOperationCompleted = new SendOrPostCallback(this.OnLoginUserOperationCompleted);
    this.InvokeAsync("LoginUser", new object[2]
    {
      (object) userName,
      (object) tripleDESEncryptedPassword
    }, this.LoginUserOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnLoginUserOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.LoginUserCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    LoginUserCompletedEventHandler userCompletedEvent = this.LoginUserCompletedEvent;
    if (userCompletedEvent == null)
      return;
    userCompletedEvent((object) this, new LoginUserCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

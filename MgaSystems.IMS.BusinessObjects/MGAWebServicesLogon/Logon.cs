// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.MGAWebServicesLogon.Logon
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

#nullable disable
namespace MGASystems.BusinessObjects.MGAWebServicesLogon;

[GeneratedCode("System.Web.Services", "4.7.2053.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "LogonSoap", Namespace = "http://tempuri.org/IMSWebServices/Logon")]
public class Logon : SoapHttpClientProtocol
{
  private SendOrPostCallback LoginOperationCompleted;
  private TokenHeader tokenHeaderValueField;
  private SendOrPostCallback ExtendTokenOperationCompleted;
  private SendOrPostCallback GetUserInfoOperationCompleted;
  private SendOrPostCallback UserGuidFromLoginTokenOperationCompleted;
  private SendOrPostCallback LoginUserOperationCompleted;
  private SendOrPostCallback GetEntityDetailsOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public Logon()
  {
    this.Url = "https://webservices.mgasystems.com/ims_development/logon.asmx";
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

  public event ExtendTokenCompletedEventHandler ExtendTokenCompleted;

  public event GetUserInfoCompletedEventHandler GetUserInfoCompleted;

  public event UserGuidFromLoginTokenCompletedEventHandler UserGuidFromLoginTokenCompleted;

  public event LoginUserCompletedEventHandler LoginUserCompleted;

  public event GetEntityDetailsCompletedEventHandler GetEntityDetailsCompleted;

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
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/Logon/ExtendToken", RequestNamespace = "http://tempuri.org/IMSWebServices/Logon", ResponseNamespace = "http://tempuri.org/IMSWebServices/Logon", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool ExtendToken()
  {
    return Conversions.ToBoolean(this.Invoke(nameof (ExtendToken), new object[0])[0]);
  }

  public IAsyncResult BeginExtendToken(AsyncCallback callback, object asyncState)
  {
    return this.BeginInvoke("ExtendToken", new object[0], callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndExtendToken(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ExtendTokenAsync() => this.ExtendTokenAsync((object) null);

  public void ExtendTokenAsync(object userState)
  {
    if (this.ExtendTokenOperationCompleted == null)
      this.ExtendTokenOperationCompleted = new SendOrPostCallback(this.OnExtendTokenOperationCompleted);
    this.InvokeAsync("ExtendToken", new object[0], this.ExtendTokenOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnExtendTokenOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ExtendTokenCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ExtendTokenCompletedEventHandler tokenCompletedEvent = this.ExtendTokenCompletedEvent;
    if (tokenCompletedEvent == null)
      return;
    tokenCompletedEvent((object) this, new ExtendTokenCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/Logon/UserGuidFromLoginToken", RequestNamespace = "http://tempuri.org/IMSWebServices/Logon", ResponseNamespace = "http://tempuri.org/IMSWebServices/Logon", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public Guid UserGuidFromLoginToken(Guid token)
  {
    object obj = this.Invoke(nameof (UserGuidFromLoginToken), new object[1]
    {
      (object) token
    })[0];
    return obj == null ? new Guid() : (Guid) obj;
  }

  public IAsyncResult BeginUserGuidFromLoginToken(
    Guid token,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("UserGuidFromLoginToken", new object[1]
    {
      (object) token
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public Guid EndUserGuidFromLoginToken(IAsyncResult asyncResult)
  {
    object obj = this.EndInvoke(asyncResult)[0];
    return obj == null ? new Guid() : (Guid) obj;
  }

  public void UserGuidFromLoginTokenAsync(Guid token)
  {
    this.UserGuidFromLoginTokenAsync(token, (object) null);
  }

  public void UserGuidFromLoginTokenAsync(Guid token, object userState)
  {
    if (this.UserGuidFromLoginTokenOperationCompleted == null)
      this.UserGuidFromLoginTokenOperationCompleted = new SendOrPostCallback(this.OnUserGuidFromLoginTokenOperationCompleted);
    this.InvokeAsync("UserGuidFromLoginToken", new object[1]
    {
      (object) token
    }, this.UserGuidFromLoginTokenOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnUserGuidFromLoginTokenOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.UserGuidFromLoginTokenCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    UserGuidFromLoginTokenCompletedEventHandler tokenCompletedEvent = this.UserGuidFromLoginTokenCompletedEvent;
    if (tokenCompletedEvent == null)
      return;
    tokenCompletedEvent((object) this, new UserGuidFromLoginTokenCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/Logon/GetEntityDetails", RequestNamespace = "http://tempuri.org/IMSWebServices/Logon", ResponseNamespace = "http://tempuri.org/IMSWebServices/Logon", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public DataTable GetEntityDetails(Guid entityGuid)
  {
    return (DataTable) this.Invoke(nameof (GetEntityDetails), new object[1]
    {
      (object) entityGuid
    })[0];
  }

  public IAsyncResult BeginGetEntityDetails(
    Guid entityGuid,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetEntityDetails", new object[1]
    {
      (object) entityGuid
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public DataTable EndGetEntityDetails(IAsyncResult asyncResult)
  {
    return (DataTable) this.EndInvoke(asyncResult)[0];
  }

  public void GetEntityDetailsAsync(Guid entityGuid)
  {
    this.GetEntityDetailsAsync(entityGuid, (object) null);
  }

  public void GetEntityDetailsAsync(Guid entityGuid, object userState)
  {
    if (this.GetEntityDetailsOperationCompleted == null)
      this.GetEntityDetailsOperationCompleted = new SendOrPostCallback(this.OnGetEntityDetailsOperationCompleted);
    this.InvokeAsync("GetEntityDetails", new object[1]
    {
      (object) entityGuid
    }, this.GetEntityDetailsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetEntityDetailsOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetEntityDetailsCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetEntityDetailsCompletedEventHandler detailsCompletedEvent = this.GetEntityDetailsCompletedEvent;
    if (detailsCompletedEvent == null)
      return;
    detailsCompletedEvent((object) this, new GetEntityDetailsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

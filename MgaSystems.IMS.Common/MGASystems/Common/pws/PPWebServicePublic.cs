// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.pws.PPWebServicePublic
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

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
namespace MGASystems.Common.pws;

[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "PPWebServicePublicSoap", Namespace = "http://CSC.PP/PublicWebServices/")]
public class PPWebServicePublic : SoapHttpClientProtocol
{
  private SendOrPostCallback SecUsersAPIValidateUserLoginWSOperationCompleted;
  private SendOrPostCallback ClientSearchBatchWSOperationCompleted;
  private SendOrPostCallback ClientSearchMultipleWSOperationCompleted;
  private SendOrPostCallback ClientSearchValidateUserAndBatchWSOperationCompleted;
  private SendOrPostCallback ClientSearchWSOperationCompleted;
  private SendOrPostCallback ClientSearchDSWSOperationCompleted;
  private SendOrPostCallback ClientSearchParamWSOperationCompleted;
  private SendOrPostCallback ClientSearchValidateUserAndBatchParamWSOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public PPWebServicePublic()
  {
    this.Url = "https://ofacprdapp1.dxc-ins.com/PPWSPublic/PPWSPublic.asmx";
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

  public event SecUsersAPIValidateUserLoginWSCompletedEventHandler SecUsersAPIValidateUserLoginWSCompleted;

  public event ClientSearchBatchWSCompletedEventHandler ClientSearchBatchWSCompleted;

  public event ClientSearchMultipleWSCompletedEventHandler ClientSearchMultipleWSCompleted;

  public event ClientSearchValidateUserAndBatchWSCompletedEventHandler ClientSearchValidateUserAndBatchWSCompleted;

  public event ClientSearchWSCompletedEventHandler ClientSearchWSCompleted;

  public event ClientSearchDSWSCompletedEventHandler ClientSearchDSWSCompleted;

  public event ClientSearchParamWSCompletedEventHandler ClientSearchParamWSCompleted;

  public event ClientSearchValidateUserAndBatchParamWSCompletedEventHandler ClientSearchValidateUserAndBatchParamWSCompleted;

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/SecUsersAPIValidateUserLoginWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string SecUsersAPIValidateUserLoginWS(string inpData)
  {
    return Conversions.ToString(this.Invoke(nameof (SecUsersAPIValidateUserLoginWS), new object[1]
    {
      (object) inpData
    })[0]);
  }

  public void SecUsersAPIValidateUserLoginWSAsync(string inpData)
  {
    this.SecUsersAPIValidateUserLoginWSAsync(inpData, (object) null);
  }

  public void SecUsersAPIValidateUserLoginWSAsync(string inpData, object userState)
  {
    if (this.SecUsersAPIValidateUserLoginWSOperationCompleted == null)
      this.SecUsersAPIValidateUserLoginWSOperationCompleted = new SendOrPostCallback(this.OnSecUsersAPIValidateUserLoginWSOperationCompleted);
    this.InvokeAsync("SecUsersAPIValidateUserLoginWS", new object[1]
    {
      (object) inpData
    }, this.SecUsersAPIValidateUserLoginWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSecUsersAPIValidateUserLoginWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SecUsersAPIValidateUserLoginWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SecUsersAPIValidateUserLoginWSCompletedEventHandler wsCompletedEvent = this.SecUsersAPIValidateUserLoginWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new SecUsersAPIValidateUserLoginWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchBatchWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ClientSearchBatchWS(string inpData)
  {
    return Conversions.ToString(this.Invoke(nameof (ClientSearchBatchWS), new object[1]
    {
      (object) inpData
    })[0]);
  }

  public void ClientSearchBatchWSAsync(string inpData)
  {
    this.ClientSearchBatchWSAsync(inpData, (object) null);
  }

  public void ClientSearchBatchWSAsync(string inpData, object userState)
  {
    if (this.ClientSearchBatchWSOperationCompleted == null)
      this.ClientSearchBatchWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchBatchWSOperationCompleted);
    this.InvokeAsync("ClientSearchBatchWS", new object[1]
    {
      (object) inpData
    }, this.ClientSearchBatchWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchBatchWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchBatchWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchBatchWSCompletedEventHandler wsCompletedEvent = this.ClientSearchBatchWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new ClientSearchBatchWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchMultipleWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ClientSearchMultipleWS(string inpData)
  {
    return Conversions.ToString(this.Invoke(nameof (ClientSearchMultipleWS), new object[1]
    {
      (object) inpData
    })[0]);
  }

  public void ClientSearchMultipleWSAsync(string inpData)
  {
    this.ClientSearchMultipleWSAsync(inpData, (object) null);
  }

  public void ClientSearchMultipleWSAsync(string inpData, object userState)
  {
    if (this.ClientSearchMultipleWSOperationCompleted == null)
      this.ClientSearchMultipleWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchMultipleWSOperationCompleted);
    this.InvokeAsync("ClientSearchMultipleWS", new object[1]
    {
      (object) inpData
    }, this.ClientSearchMultipleWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchMultipleWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchMultipleWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchMultipleWSCompletedEventHandler wsCompletedEvent = this.ClientSearchMultipleWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new ClientSearchMultipleWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchValidateUserAndBatchWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ClientSearchValidateUserAndBatchWS(string inpData)
  {
    return Conversions.ToString(this.Invoke(nameof (ClientSearchValidateUserAndBatchWS), new object[1]
    {
      (object) inpData
    })[0]);
  }

  public void ClientSearchValidateUserAndBatchWSAsync(string inpData)
  {
    this.ClientSearchValidateUserAndBatchWSAsync(inpData, (object) null);
  }

  public void ClientSearchValidateUserAndBatchWSAsync(string inpData, object userState)
  {
    if (this.ClientSearchValidateUserAndBatchWSOperationCompleted == null)
      this.ClientSearchValidateUserAndBatchWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchValidateUserAndBatchWSOperationCompleted);
    this.InvokeAsync("ClientSearchValidateUserAndBatchWS", new object[1]
    {
      (object) inpData
    }, this.ClientSearchValidateUserAndBatchWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchValidateUserAndBatchWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchValidateUserAndBatchWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchValidateUserAndBatchWSCompletedEventHandler wsCompletedEvent = this.ClientSearchValidateUserAndBatchWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new ClientSearchValidateUserAndBatchWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ClientSearchWS(string inpData)
  {
    return Conversions.ToString(this.Invoke(nameof (ClientSearchWS), new object[1]
    {
      (object) inpData
    })[0]);
  }

  public void ClientSearchWSAsync(string inpData)
  {
    this.ClientSearchWSAsync(inpData, (object) null);
  }

  public void ClientSearchWSAsync(string inpData, object userState)
  {
    if (this.ClientSearchWSOperationCompleted == null)
      this.ClientSearchWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchWSOperationCompleted);
    this.InvokeAsync("ClientSearchWS", new object[1]
    {
      (object) inpData
    }, this.ClientSearchWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchWSCompletedEventHandler wsCompletedEvent = this.ClientSearchWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new ClientSearchWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchDSWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public DataSet ClientSearchDSWS(string inpData)
  {
    return (DataSet) this.Invoke(nameof (ClientSearchDSWS), new object[1]
    {
      (object) inpData
    })[0];
  }

  public void ClientSearchDSWSAsync(string inpData)
  {
    this.ClientSearchDSWSAsync(inpData, (object) null);
  }

  public void ClientSearchDSWSAsync(string inpData, object userState)
  {
    if (this.ClientSearchDSWSOperationCompleted == null)
      this.ClientSearchDSWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchDSWSOperationCompleted);
    this.InvokeAsync("ClientSearchDSWS", new object[1]
    {
      (object) inpData
    }, this.ClientSearchDSWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchDSWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchDSWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchDSWSCompletedEventHandler dswsCompletedEvent = this.ClientSearchDSWSCompletedEvent;
    if (dswsCompletedEvent == null)
      return;
    dswsCompletedEvent((object) this, new ClientSearchDSWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchParamWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ClientSearchParamWS(
    string Last_Name,
    string First_Name,
    string Address,
    string City,
    string State,
    string Zip_Code,
    string Country,
    string Search_Width,
    string Search_Tolerance,
    string ClearDny,
    string ClientRefNo,
    string TransRefNo,
    string TransType,
    int CompanyId,
    int OfficeId,
    int UpdatedBy,
    int ThreshHold)
  {
    return Conversions.ToString(this.Invoke(nameof (ClientSearchParamWS), new object[17]
    {
      (object) Last_Name,
      (object) First_Name,
      (object) Address,
      (object) City,
      (object) State,
      (object) Zip_Code,
      (object) Country,
      (object) Search_Width,
      (object) Search_Tolerance,
      (object) ClearDny,
      (object) ClientRefNo,
      (object) TransRefNo,
      (object) TransType,
      (object) CompanyId,
      (object) OfficeId,
      (object) UpdatedBy,
      (object) ThreshHold
    })[0]);
  }

  public void ClientSearchParamWSAsync(
    string Last_Name,
    string First_Name,
    string Address,
    string City,
    string State,
    string Zip_Code,
    string Country,
    string Search_Width,
    string Search_Tolerance,
    string ClearDny,
    string ClientRefNo,
    string TransRefNo,
    string TransType,
    int CompanyId,
    int OfficeId,
    int UpdatedBy,
    int ThreshHold)
  {
    this.ClientSearchParamWSAsync(Last_Name, First_Name, Address, City, State, Zip_Code, Country, Search_Width, Search_Tolerance, ClearDny, ClientRefNo, TransRefNo, TransType, CompanyId, OfficeId, UpdatedBy, ThreshHold, (object) null);
  }

  public void ClientSearchParamWSAsync(
    string Last_Name,
    string First_Name,
    string Address,
    string City,
    string State,
    string Zip_Code,
    string Country,
    string Search_Width,
    string Search_Tolerance,
    string ClearDny,
    string ClientRefNo,
    string TransRefNo,
    string TransType,
    int CompanyId,
    int OfficeId,
    int UpdatedBy,
    int ThreshHold,
    object userState)
  {
    if (this.ClientSearchParamWSOperationCompleted == null)
      this.ClientSearchParamWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchParamWSOperationCompleted);
    this.InvokeAsync("ClientSearchParamWS", new object[17]
    {
      (object) Last_Name,
      (object) First_Name,
      (object) Address,
      (object) City,
      (object) State,
      (object) Zip_Code,
      (object) Country,
      (object) Search_Width,
      (object) Search_Tolerance,
      (object) ClearDny,
      (object) ClientRefNo,
      (object) TransRefNo,
      (object) TransType,
      (object) CompanyId,
      (object) OfficeId,
      (object) UpdatedBy,
      (object) ThreshHold
    }, this.ClientSearchParamWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchParamWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchParamWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchParamWSCompletedEventHandler wsCompletedEvent = this.ClientSearchParamWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new ClientSearchParamWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://CSC.PP/PublicWebServices/ClientSearchValidateUserAndBatchParamWS", RequestNamespace = "http://CSC.PP/PublicWebServices/", ResponseNamespace = "http://CSC.PP/PublicWebServices/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ClientSearchValidateUserAndBatchParamWS(
    string UserId,
    string Password,
    string LastName,
    string FirstName,
    string Address,
    string City,
    string State,
    string ZipCode,
    string Country,
    string ClientRefNo,
    string TransRefNo,
    string TransType,
    string DateOfBirth)
  {
    return Conversions.ToString(this.Invoke(nameof (ClientSearchValidateUserAndBatchParamWS), new object[13]
    {
      (object) UserId,
      (object) Password,
      (object) LastName,
      (object) FirstName,
      (object) Address,
      (object) City,
      (object) State,
      (object) ZipCode,
      (object) Country,
      (object) ClientRefNo,
      (object) TransRefNo,
      (object) TransType,
      (object) DateOfBirth
    })[0]);
  }

  public void ClientSearchValidateUserAndBatchParamWSAsync(
    string UserId,
    string Password,
    string LastName,
    string FirstName,
    string Address,
    string City,
    string State,
    string ZipCode,
    string Country,
    string ClientRefNo,
    string TransRefNo,
    string TransType,
    string DateOfBirth)
  {
    this.ClientSearchValidateUserAndBatchParamWSAsync(UserId, Password, LastName, FirstName, Address, City, State, ZipCode, Country, ClientRefNo, TransRefNo, TransType, DateOfBirth, (object) null);
  }

  public void ClientSearchValidateUserAndBatchParamWSAsync(
    string UserId,
    string Password,
    string LastName,
    string FirstName,
    string Address,
    string City,
    string State,
    string ZipCode,
    string Country,
    string ClientRefNo,
    string TransRefNo,
    string TransType,
    string DateOfBirth,
    object userState)
  {
    if (this.ClientSearchValidateUserAndBatchParamWSOperationCompleted == null)
      this.ClientSearchValidateUserAndBatchParamWSOperationCompleted = new SendOrPostCallback(this.OnClientSearchValidateUserAndBatchParamWSOperationCompleted);
    this.InvokeAsync("ClientSearchValidateUserAndBatchParamWS", new object[13]
    {
      (object) UserId,
      (object) Password,
      (object) LastName,
      (object) FirstName,
      (object) Address,
      (object) City,
      (object) State,
      (object) ZipCode,
      (object) Country,
      (object) ClientRefNo,
      (object) TransRefNo,
      (object) TransType,
      (object) DateOfBirth
    }, this.ClientSearchValidateUserAndBatchParamWSOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnClientSearchValidateUserAndBatchParamWSOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ClientSearchValidateUserAndBatchParamWSCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ClientSearchValidateUserAndBatchParamWSCompletedEventHandler wsCompletedEvent = this.ClientSearchValidateUserAndBatchParamWSCompletedEvent;
    if (wsCompletedEvent == null)
      return;
    wsCompletedEvent((object) this, new ClientSearchValidateUserAndBatchParamWSCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

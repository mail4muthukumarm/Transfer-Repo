// Decompiled with JetBrains decompiler
// Type: CancellationNotices.DocumentFunctions.DocumentFunctions
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

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
using System.Xml.Serialization;

#nullable disable
namespace CancellationNotices.DocumentFunctions;

[GeneratedCode("System.Web.Services", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "DocumentFunctionsSoap", Namespace = "http://tempuri.org/IMSWebServices/DocumentFunctions")]
public class DocumentFunctions : SoapHttpClientProtocol
{
  private TokenHeader tokenHeaderValueField;
  private SendOrPostCallback InsertDocumentOperationCompleted;
  private SendOrPostCallback InsertDocument1OperationCompleted;
  private SendOrPostCallback InsertDocumentAssociatedToControlGUIDOperationCompleted;
  private SendOrPostCallback InsertDocumentAssociatedToControlGUID1OperationCompleted;
  private SendOrPostCallback InsertDocumentAssociatedToPolicyOperationCompleted;
  private SendOrPostCallback GetFolderListOperationCompleted;
  private SendOrPostCallback VerifyFolderOperationCompleted;
  private SendOrPostCallback InsertDocumentAssociatedToPolicy1OperationCompleted;
  private SendOrPostCallback UploadDocumentNoteBatchOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public DocumentFunctions()
  {
    this.Url = "http://webservices.mgasystems.com/ims_mejames/DocumentFunctions.asmx";
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

  public event InsertDocumentCompletedEventHandler InsertDocumentCompleted;

  public event InsertDocument1CompletedEventHandler InsertDocument1Completed;

  public event InsertDocumentAssociatedToControlGUIDCompletedEventHandler InsertDocumentAssociatedToControlGUIDCompleted;

  public event InsertDocumentAssociatedToControlGUID1CompletedEventHandler InsertDocumentAssociatedToControlGUID1Completed;

  public event InsertDocumentAssociatedToPolicyCompletedEventHandler InsertDocumentAssociatedToPolicyCompleted;

  public event GetFolderListCompletedEventHandler GetFolderListCompleted;

  public event VerifyFolderCompletedEventHandler VerifyFolderCompleted;

  public event InsertDocumentAssociatedToPolicy1CompletedEventHandler InsertDocumentAssociatedToPolicy1Completed;

  public event UploadDocumentNoteBatchCompletedEventHandler UploadDocumentNoteBatchCompleted;

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/InsertTypedDocument", RequestElementName = "InsertTypedDocument", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseElementName = "InsertTypedDocumentResponse", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void InsertDocument(
    Guid userGuid,
    string fileName,
    [XmlElement(DataType = "base64Binary")] byte[] fileData,
    Guid typeGuid,
    string description)
  {
    this.Invoke(nameof (InsertDocument), new object[5]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description
    });
  }

  public IAsyncResult BeginInsertDocument(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("InsertDocument", new object[5]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndInsertDocument(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

  public void InsertDocumentAsync(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description)
  {
    this.InsertDocumentAsync(userGuid, fileName, fileData, typeGuid, description, (object) null);
  }

  public void InsertDocumentAsync(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    object userState)
  {
    if (this.InsertDocumentOperationCompleted == null)
      this.InsertDocumentOperationCompleted = new SendOrPostCallback(this.OnInsertDocumentOperationCompleted);
    this.InvokeAsync("InsertDocument", new object[5]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description
    }, this.InsertDocumentOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnInsertDocumentOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.InsertDocumentCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    InsertDocumentCompletedEventHandler documentCompletedEvent = this.InsertDocumentCompletedEvent;
    if (documentCompletedEvent == null)
      return;
    documentCompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [WebMethod(MessageName = "InsertDocument1")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/InsertDocument", RequestElementName = "InsertDocument", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseElementName = "InsertDocumentResponse", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void InsertDocument(
    Guid userGuid,
    string fileName,
    [XmlElement(DataType = "base64Binary")] byte[] fileData,
    string description,
    string metaXml,
    int folderId)
  {
    this.Invoke("InsertDocument1", new object[6]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) metaXml,
      (object) folderId
    });
  }

  public IAsyncResult BeginInsertDocument1(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    string metaXml,
    int folderId,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("InsertDocument1", new object[6]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) metaXml,
      (object) folderId
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndInsertDocument1(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

  public void InsertDocument1Async(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    string metaXml,
    int folderId)
  {
    this.InsertDocument1Async(userGuid, fileName, fileData, description, metaXml, folderId, (object) null);
  }

  public void InsertDocument1Async(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    string metaXml,
    int folderId,
    object userState)
  {
    if (this.InsertDocument1OperationCompleted == null)
      this.InsertDocument1OperationCompleted = new SendOrPostCallback(this.OnInsertDocument1OperationCompleted);
    this.InvokeAsync("InsertDocument1", new object[6]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) metaXml,
      (object) folderId
    }, this.InsertDocument1OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnInsertDocument1OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.InsertDocument1CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    InsertDocument1CompletedEventHandler document1CompletedEvent = this.InsertDocument1CompletedEvent;
    if (document1CompletedEvent == null)
      return;
    document1CompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/InsertDocumentAssociatedToControlGUID", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void InsertDocumentAssociatedToControlGUID(
    Guid userGuid,
    string fileName,
    [XmlElement(DataType = "base64Binary")] byte[] fileData,
    string description,
    Guid controlGUID,
    string entityName,
    string metaXml,
    int folderID)
  {
    this.Invoke(nameof (InsertDocumentAssociatedToControlGUID), new object[8]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) controlGUID,
      (object) entityName,
      (object) metaXml,
      (object) folderID
    });
  }

  public IAsyncResult BeginInsertDocumentAssociatedToControlGUID(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    Guid controlGUID,
    string entityName,
    string metaXml,
    int folderID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("InsertDocumentAssociatedToControlGUID", new object[8]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) controlGUID,
      (object) entityName,
      (object) metaXml,
      (object) folderID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndInsertDocumentAssociatedToControlGUID(IAsyncResult asyncResult)
  {
    this.EndInvoke(asyncResult);
  }

  public void InsertDocumentAssociatedToControlGUIDAsync(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    Guid controlGUID,
    string entityName,
    string metaXml,
    int folderID)
  {
    this.InsertDocumentAssociatedToControlGUIDAsync(userGuid, fileName, fileData, description, controlGUID, entityName, metaXml, folderID, (object) null);
  }

  public void InsertDocumentAssociatedToControlGUIDAsync(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    Guid controlGUID,
    string entityName,
    string metaXml,
    int folderID,
    object userState)
  {
    if (this.InsertDocumentAssociatedToControlGUIDOperationCompleted == null)
      this.InsertDocumentAssociatedToControlGUIDOperationCompleted = new SendOrPostCallback(this.OnInsertDocumentAssociatedToControlGUIDOperationCompleted);
    this.InvokeAsync("InsertDocumentAssociatedToControlGUID", new object[8]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) controlGUID,
      (object) entityName,
      (object) metaXml,
      (object) folderID
    }, this.InsertDocumentAssociatedToControlGUIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnInsertDocumentAssociatedToControlGUIDOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.InsertDocumentAssociatedToControlGUIDCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    InsertDocumentAssociatedToControlGUIDCompletedEventHandler guidCompletedEvent = this.InsertDocumentAssociatedToControlGUIDCompletedEvent;
    if (guidCompletedEvent == null)
      return;
    guidCompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [WebMethod(MessageName = "InsertDocumentAssociatedToControlGUID1")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/InsertTypedDocumentAssociatedToControlGUID", RequestElementName = "InsertTypedDocumentAssociatedToControlGUID", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseElementName = "InsertTypedDocumentAssociatedToControlGUIDResponse", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void InsertDocumentAssociatedToControlGUID(
    Guid userGuid,
    string fileName,
    [XmlElement(DataType = "base64Binary")] byte[] fileData,
    Guid typeGuid,
    string description,
    Guid controlGUID,
    string entityName)
  {
    this.Invoke("InsertDocumentAssociatedToControlGUID1", new object[7]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description,
      (object) controlGUID,
      (object) entityName
    });
  }

  public IAsyncResult BeginInsertDocumentAssociatedToControlGUID1(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    Guid controlGUID,
    string entityName,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("InsertDocumentAssociatedToControlGUID1", new object[7]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description,
      (object) controlGUID,
      (object) entityName
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndInsertDocumentAssociatedToControlGUID1(IAsyncResult asyncResult)
  {
    this.EndInvoke(asyncResult);
  }

  public void InsertDocumentAssociatedToControlGUID1Async(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    Guid controlGUID,
    string entityName)
  {
    this.InsertDocumentAssociatedToControlGUID1Async(userGuid, fileName, fileData, typeGuid, description, controlGUID, entityName, (object) null);
  }

  public void InsertDocumentAssociatedToControlGUID1Async(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    Guid controlGUID,
    string entityName,
    object userState)
  {
    if (this.InsertDocumentAssociatedToControlGUID1OperationCompleted == null)
      this.InsertDocumentAssociatedToControlGUID1OperationCompleted = new SendOrPostCallback(this.OnInsertDocumentAssociatedToControlGUID1OperationCompleted);
    this.InvokeAsync("InsertDocumentAssociatedToControlGUID1", new object[7]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description,
      (object) controlGUID,
      (object) entityName
    }, this.InsertDocumentAssociatedToControlGUID1OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnInsertDocumentAssociatedToControlGUID1OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.InsertDocumentAssociatedToControlGUID1CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    InsertDocumentAssociatedToControlGUID1CompletedEventHandler d1CompletedEvent = this.InsertDocumentAssociatedToControlGUID1CompletedEvent;
    if (d1CompletedEvent == null)
      return;
    d1CompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/InsertDocumentAssociatedToPolicy", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void InsertDocumentAssociatedToPolicy(
    Guid userGuid,
    string fileName,
    [XmlElement(DataType = "base64Binary")] byte[] fileData,
    string description,
    string policyNumber,
    string entityName)
  {
    this.Invoke(nameof (InsertDocumentAssociatedToPolicy), new object[6]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) policyNumber,
      (object) entityName
    });
  }

  public IAsyncResult BeginInsertDocumentAssociatedToPolicy(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    string policyNumber,
    string entityName,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("InsertDocumentAssociatedToPolicy", new object[6]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) policyNumber,
      (object) entityName
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndInsertDocumentAssociatedToPolicy(IAsyncResult asyncResult)
  {
    this.EndInvoke(asyncResult);
  }

  public void InsertDocumentAssociatedToPolicyAsync(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    string policyNumber,
    string entityName)
  {
    this.InsertDocumentAssociatedToPolicyAsync(userGuid, fileName, fileData, description, policyNumber, entityName, (object) null);
  }

  public void InsertDocumentAssociatedToPolicyAsync(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    string description,
    string policyNumber,
    string entityName,
    object userState)
  {
    if (this.InsertDocumentAssociatedToPolicyOperationCompleted == null)
      this.InsertDocumentAssociatedToPolicyOperationCompleted = new SendOrPostCallback(this.OnInsertDocumentAssociatedToPolicyOperationCompleted);
    this.InvokeAsync("InsertDocumentAssociatedToPolicy", new object[6]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) description,
      (object) policyNumber,
      (object) entityName
    }, this.InsertDocumentAssociatedToPolicyOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnInsertDocumentAssociatedToPolicyOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.InsertDocumentAssociatedToPolicyCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    InsertDocumentAssociatedToPolicyCompletedEventHandler policyCompletedEvent = this.InsertDocumentAssociatedToPolicyCompletedEvent;
    if (policyCompletedEvent == null)
      return;
    policyCompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/GetFolderList", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public DataSet GetFolderList(int parentFolderID)
  {
    return (DataSet) this.Invoke(nameof (GetFolderList), new object[1]
    {
      (object) parentFolderID
    })[0];
  }

  public IAsyncResult BeginGetFolderList(
    int parentFolderID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetFolderList", new object[1]
    {
      (object) parentFolderID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public DataSet EndGetFolderList(IAsyncResult asyncResult)
  {
    return (DataSet) this.EndInvoke(asyncResult)[0];
  }

  public void GetFolderListAsync(int parentFolderID)
  {
    this.GetFolderListAsync(parentFolderID, (object) null);
  }

  public void GetFolderListAsync(int parentFolderID, object userState)
  {
    if (this.GetFolderListOperationCompleted == null)
      this.GetFolderListOperationCompleted = new SendOrPostCallback(this.OnGetFolderListOperationCompleted);
    this.InvokeAsync("GetFolderList", new object[1]
    {
      (object) parentFolderID
    }, this.GetFolderListOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetFolderListOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetFolderListCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetFolderListCompletedEventHandler listCompletedEvent = this.GetFolderListCompletedEvent;
    if (listCompletedEvent == null)
      return;
    listCompletedEvent((object) this, new GetFolderListCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/VerifyFolder", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool VerifyFolder(int folderID)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (VerifyFolder), new object[1]
    {
      (object) folderID
    })[0]);
  }

  public IAsyncResult BeginVerifyFolder(int folderID, AsyncCallback callback, object asyncState)
  {
    return this.BeginInvoke("VerifyFolder", new object[1]
    {
      (object) folderID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndVerifyFolder(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void VerifyFolderAsync(int folderID) => this.VerifyFolderAsync(folderID, (object) null);

  public void VerifyFolderAsync(int folderID, object userState)
  {
    if (this.VerifyFolderOperationCompleted == null)
      this.VerifyFolderOperationCompleted = new SendOrPostCallback(this.OnVerifyFolderOperationCompleted);
    this.InvokeAsync("VerifyFolder", new object[1]
    {
      (object) folderID
    }, this.VerifyFolderOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnVerifyFolderOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.VerifyFolderCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    VerifyFolderCompletedEventHandler folderCompletedEvent = this.VerifyFolderCompletedEvent;
    if (folderCompletedEvent == null)
      return;
    folderCompletedEvent((object) this, new VerifyFolderCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [WebMethod(MessageName = "InsertDocumentAssociatedToPolicy1")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/InsertTypedDocumentAssociatedToPolicy", RequestElementName = "InsertTypedDocumentAssociatedToPolicy", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseElementName = "InsertTypedDocumentAssociatedToPolicyResponse", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void InsertDocumentAssociatedToPolicy(
    Guid userGuid,
    string fileName,
    [XmlElement(DataType = "base64Binary")] byte[] fileData,
    Guid typeGuid,
    string description,
    string policyNumber,
    string entityName)
  {
    this.Invoke("InsertDocumentAssociatedToPolicy1", new object[7]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description,
      (object) policyNumber,
      (object) entityName
    });
  }

  public IAsyncResult BeginInsertDocumentAssociatedToPolicy1(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    string policyNumber,
    string entityName,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("InsertDocumentAssociatedToPolicy1", new object[7]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description,
      (object) policyNumber,
      (object) entityName
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndInsertDocumentAssociatedToPolicy1(IAsyncResult asyncResult)
  {
    this.EndInvoke(asyncResult);
  }

  public void InsertDocumentAssociatedToPolicy1Async(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    string policyNumber,
    string entityName)
  {
    this.InsertDocumentAssociatedToPolicy1Async(userGuid, fileName, fileData, typeGuid, description, policyNumber, entityName, (object) null);
  }

  public void InsertDocumentAssociatedToPolicy1Async(
    Guid userGuid,
    string fileName,
    byte[] fileData,
    Guid typeGuid,
    string description,
    string policyNumber,
    string entityName,
    object userState)
  {
    if (this.InsertDocumentAssociatedToPolicy1OperationCompleted == null)
      this.InsertDocumentAssociatedToPolicy1OperationCompleted = new SendOrPostCallback(this.OnInsertDocumentAssociatedToPolicy1OperationCompleted);
    this.InvokeAsync("InsertDocumentAssociatedToPolicy1", new object[7]
    {
      (object) userGuid,
      (object) fileName,
      (object) fileData,
      (object) typeGuid,
      (object) description,
      (object) policyNumber,
      (object) entityName
    }, this.InsertDocumentAssociatedToPolicy1OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnInsertDocumentAssociatedToPolicy1OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.InsertDocumentAssociatedToPolicy1CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    InsertDocumentAssociatedToPolicy1CompletedEventHandler policy1CompletedEvent = this.InsertDocumentAssociatedToPolicy1CompletedEvent;
    if (policy1CompletedEvent == null)
      return;
    policy1CompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/IMSWebServices/DocumentFunctions/UploadDocumentNoteBatch", RequestNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", ResponseNamespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public void UploadDocumentNoteBatch(DataSet uploadSet)
  {
    this.Invoke(nameof (UploadDocumentNoteBatch), new object[1]
    {
      (object) uploadSet
    });
  }

  public IAsyncResult BeginUploadDocumentNoteBatch(
    DataSet uploadSet,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("UploadDocumentNoteBatch", new object[1]
    {
      (object) uploadSet
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public void EndUploadDocumentNoteBatch(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

  public void UploadDocumentNoteBatchAsync(DataSet uploadSet)
  {
    this.UploadDocumentNoteBatchAsync(uploadSet, (object) null);
  }

  public void UploadDocumentNoteBatchAsync(DataSet uploadSet, object userState)
  {
    if (this.UploadDocumentNoteBatchOperationCompleted == null)
      this.UploadDocumentNoteBatchOperationCompleted = new SendOrPostCallback(this.OnUploadDocumentNoteBatchOperationCompleted);
    this.InvokeAsync("UploadDocumentNoteBatch", new object[1]
    {
      (object) uploadSet
    }, this.UploadDocumentNoteBatchOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnUploadDocumentNoteBatchOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.UploadDocumentNoteBatchCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    UploadDocumentNoteBatchCompletedEventHandler batchCompletedEvent = this.UploadDocumentNoteBatchCompletedEvent;
    if (batchCompletedEvent == null)
      return;
    batchCompletedEvent((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

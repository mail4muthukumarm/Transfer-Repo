// Decompiled with JetBrains decompiler
// Type: MGASystems.ErrorHandling.MgaReportingServices.MGAReportingServices
// Assembly: MgaSystems.IMS.ErrorHandling, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4686CAD5-B68D-4F03-A647-C480B9E54EB4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.ErrorHandling.dll

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
namespace MGASystems.ErrorHandling.MgaReportingServices;

[WebServiceBinding(Name = "MGAReportingServicesSoap", Namespace = "http://tempuri.org/MGACriticalErrorServices/Service1")]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "4.0.30319.17929")]
[DebuggerStepThrough]
public class MGAReportingServices : SoapHttpClientProtocol
{
  private SendOrPostCallback ReportCriticalErrorSqlOperationCompleted;
  private SendOrPostCallback ReportCriticalErrorSqlWithScreenshotOperationCompleted;
  private SendOrPostCallback ReportCriticalErrorOperationCompleted;
  private SendOrPostCallback ReportCriticalError1OperationCompleted;
  private SendOrPostCallback ReportCriticalError2OperationCompleted;
  private SendOrPostCallback ReportCriticalError3OperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public MGAReportingServices()
  {
    this.Url = "http://webservices.mgasystems.com/imscriticalerror/MGACriticalErrorService.asmx";
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

  public event ReportCriticalErrorSqlCompletedEventHandler ReportCriticalErrorSqlCompleted;

  public event ReportCriticalErrorSqlWithScreenshotCompletedEventHandler ReportCriticalErrorSqlWithScreenshotCompleted;

  public event ReportCriticalErrorCompletedEventHandler ReportCriticalErrorCompleted;

  public event ReportCriticalError1CompletedEventHandler ReportCriticalError1Completed;

  public event ReportCriticalError2CompletedEventHandler ReportCriticalError2Completed;

  public event ReportCriticalError3CompletedEventHandler ReportCriticalError3Completed;

  [SoapDocumentMethod("http://tempuri.org/MGACriticalErrorServices/Service1/ReportCriticalErrorSql", RequestNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", ResponseNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool ReportCriticalErrorSql(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string sqlProcedure,
    int sqlLineNumber)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (ReportCriticalErrorSql), new object[8]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) sqlProcedure,
      (object) sqlLineNumber
    })[0]);
  }

  public IAsyncResult BeginReportCriticalErrorSql(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string sqlProcedure,
    int sqlLineNumber,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ReportCriticalErrorSql", new object[8]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) sqlProcedure,
      (object) sqlLineNumber
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndReportCriticalErrorSql(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ReportCriticalErrorSqlAsync(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string sqlProcedure,
    int sqlLineNumber)
  {
    this.ReportCriticalErrorSqlAsync(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, sqlProcedure, sqlLineNumber, (object) null);
  }

  public void ReportCriticalErrorSqlAsync(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string sqlProcedure,
    int sqlLineNumber,
    object userState)
  {
    if (this.ReportCriticalErrorSqlOperationCompleted == null)
      this.ReportCriticalErrorSqlOperationCompleted = new SendOrPostCallback(this.OnReportCriticalErrorSqlOperationCompleted);
    this.InvokeAsync("ReportCriticalErrorSql", new object[8]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) sqlProcedure,
      (object) sqlLineNumber
    }, this.ReportCriticalErrorSqlOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalErrorSqlOperationCompleted(object arg)
  {
    if (this.ReportCriticalErrorSqlCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    ReportCriticalErrorSqlCompletedEventHandler sqlCompletedEvent = this.ReportCriticalErrorSqlCompletedEvent;
    if (sqlCompletedEvent == null)
      return;
    sqlCompletedEvent((object) this, new ReportCriticalErrorSqlCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://tempuri.org/MGACriticalErrorServices/Service1/ReportCriticalErrorSqlWithScreenshot", RequestNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", ResponseNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool ReportCriticalErrorSqlWithScreenshot(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    [XmlElement(DataType = "base64Binary")] byte[] imageBytes,
    string sqlProcedure,
    int sqlLineNumber)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (ReportCriticalErrorSqlWithScreenshot), new object[9]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes,
      (object) sqlProcedure,
      (object) sqlLineNumber
    })[0]);
  }

  public IAsyncResult BeginReportCriticalErrorSqlWithScreenshot(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    string sqlProcedure,
    int sqlLineNumber,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ReportCriticalErrorSqlWithScreenshot", new object[9]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes,
      (object) sqlProcedure,
      (object) sqlLineNumber
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndReportCriticalErrorSqlWithScreenshot(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ReportCriticalErrorSqlWithScreenshotAsync(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    string sqlProcedure,
    int sqlLineNumber)
  {
    this.ReportCriticalErrorSqlWithScreenshotAsync(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, imageBytes, sqlProcedure, sqlLineNumber, (object) null);
  }

  public void ReportCriticalErrorSqlWithScreenshotAsync(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    string sqlProcedure,
    int sqlLineNumber,
    object userState)
  {
    if (this.ReportCriticalErrorSqlWithScreenshotOperationCompleted == null)
      this.ReportCriticalErrorSqlWithScreenshotOperationCompleted = new SendOrPostCallback(this.OnReportCriticalErrorSqlWithScreenshotOperationCompleted);
    this.InvokeAsync("ReportCriticalErrorSqlWithScreenshot", new object[9]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes,
      (object) sqlProcedure,
      (object) sqlLineNumber
    }, this.ReportCriticalErrorSqlWithScreenshotOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalErrorSqlWithScreenshotOperationCompleted(object arg)
  {
    if (this.ReportCriticalErrorSqlWithScreenshotCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    ReportCriticalErrorSqlWithScreenshotCompletedEventHandler screenshotCompletedEvent = this.ReportCriticalErrorSqlWithScreenshotCompletedEvent;
    if (screenshotCompletedEvent == null)
      return;
    screenshotCompletedEvent((object) this, new ReportCriticalErrorSqlWithScreenshotCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://tempuri.org/MGACriticalErrorServices/Service1/ReportCriticalErrorEx", RequestElementName = "ReportCriticalErrorEx", RequestNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", ResponseElementName = "ReportCriticalErrorExResponse", ResponseNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorExResult")]
  public bool ReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (ReportCriticalError), new object[10]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) innerExceptionSource,
      (object) innerExceptionStackTrace,
      (object) innerExceptionTargetSite,
      (object) innerExceptionType
    })[0]);
  }

  public IAsyncResult BeginReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ReportCriticalError", new object[10]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) innerExceptionSource,
      (object) innerExceptionStackTrace,
      (object) innerExceptionTargetSite,
      (object) innerExceptionType
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndReportCriticalError(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ReportCriticalErrorAsync(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType)
  {
    this.ReportCriticalErrorAsync(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, innerExceptionSource, innerExceptionStackTrace, innerExceptionTargetSite, innerExceptionType, (object) null);
  }

  public void ReportCriticalErrorAsync(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType,
    object userState)
  {
    if (this.ReportCriticalErrorOperationCompleted == null)
      this.ReportCriticalErrorOperationCompleted = new SendOrPostCallback(this.OnReportCriticalErrorOperationCompleted);
    this.InvokeAsync("ReportCriticalError", new object[10]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) innerExceptionSource,
      (object) innerExceptionStackTrace,
      (object) innerExceptionTargetSite,
      (object) innerExceptionType
    }, this.ReportCriticalErrorOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalErrorOperationCompleted(object arg)
  {
    if (this.ReportCriticalErrorCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    ReportCriticalErrorCompletedEventHandler errorCompletedEvent = this.ReportCriticalErrorCompletedEvent;
    if (errorCompletedEvent == null)
      return;
    errorCompletedEvent((object) this, new ReportCriticalErrorCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError1")]
  [SoapDocumentMethod("http://tempuri.org/MGACriticalErrorServices/Service1/ReportCriticalErrorWithScreenshotEx", RequestElementName = "ReportCriticalErrorWithScreenshotEx", RequestNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", ResponseElementName = "ReportCriticalErrorWithScreenshotExResponse", ResponseNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorWithScreenshotExResult")]
  public bool ReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    [XmlElement(DataType = "base64Binary")] byte[] imageBytes,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType)
  {
    return Conversions.ToBoolean(this.Invoke("ReportCriticalError1", new object[11]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes,
      (object) innerExceptionSource,
      (object) innerExceptionStackTrace,
      (object) innerExceptionTargetSite,
      (object) innerExceptionType
    })[0]);
  }

  public IAsyncResult BeginReportCriticalError1(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ReportCriticalError1", new object[11]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes,
      (object) innerExceptionSource,
      (object) innerExceptionStackTrace,
      (object) innerExceptionTargetSite,
      (object) innerExceptionType
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndReportCriticalError1(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ReportCriticalError1Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType)
  {
    this.ReportCriticalError1Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, imageBytes, innerExceptionSource, innerExceptionStackTrace, innerExceptionTargetSite, innerExceptionType, (object) null);
  }

  public void ReportCriticalError1Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    string innerExceptionSource,
    string innerExceptionStackTrace,
    string innerExceptionTargetSite,
    string innerExceptionType,
    object userState)
  {
    if (this.ReportCriticalError1OperationCompleted == null)
      this.ReportCriticalError1OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError1OperationCompleted);
    this.InvokeAsync("ReportCriticalError1", new object[11]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes,
      (object) innerExceptionSource,
      (object) innerExceptionStackTrace,
      (object) innerExceptionTargetSite,
      (object) innerExceptionType
    }, this.ReportCriticalError1OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError1OperationCompleted(object arg)
  {
    if (this.ReportCriticalError1CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    ReportCriticalError1CompletedEventHandler error1CompletedEvent = this.ReportCriticalError1CompletedEvent;
    if (error1CompletedEvent == null)
      return;
    error1CompletedEvent((object) this, new ReportCriticalError1CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError2")]
  [SoapDocumentMethod("http://tempuri.org/MGACriticalErrorServices/Service1/ReportCriticalError", RequestElementName = "ReportCriticalError", RequestNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", ResponseElementName = "ReportCriticalErrorResponse", ResponseNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorResult")]
  public bool ReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType)
  {
    return Conversions.ToBoolean(this.Invoke("ReportCriticalError2", new object[6]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType
    })[0]);
  }

  public IAsyncResult BeginReportCriticalError2(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ReportCriticalError2", new object[6]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndReportCriticalError2(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ReportCriticalError2Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType)
  {
    this.ReportCriticalError2Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, (object) null);
  }

  public void ReportCriticalError2Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    object userState)
  {
    if (this.ReportCriticalError2OperationCompleted == null)
      this.ReportCriticalError2OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError2OperationCompleted);
    this.InvokeAsync("ReportCriticalError2", new object[6]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType
    }, this.ReportCriticalError2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError2OperationCompleted(object arg)
  {
    if (this.ReportCriticalError2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    ReportCriticalError2CompletedEventHandler error2CompletedEvent = this.ReportCriticalError2CompletedEvent;
    if (error2CompletedEvent == null)
      return;
    error2CompletedEvent((object) this, new ReportCriticalError2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError3")]
  [SoapDocumentMethod("http://tempuri.org/MGACriticalErrorServices/Service1/ReportCriticalErrorWithScreenshot", RequestElementName = "ReportCriticalErrorWithScreenshot", RequestNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", ResponseElementName = "ReportCriticalErrorWithScreenshotResponse", ResponseNamespace = "http://tempuri.org/MGACriticalErrorServices/Service1", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorWithScreenshotResult")]
  public bool ReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    [XmlElement(DataType = "base64Binary")] byte[] imageBytes)
  {
    return Conversions.ToBoolean(this.Invoke("ReportCriticalError3", new object[7]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes
    })[0]);
  }

  public IAsyncResult BeginReportCriticalError3(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ReportCriticalError3", new object[7]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndReportCriticalError3(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ReportCriticalError3Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes)
  {
    this.ReportCriticalError3Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, imageBytes, (object) null);
  }

  public void ReportCriticalError3Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    object userState)
  {
    if (this.ReportCriticalError3OperationCompleted == null)
      this.ReportCriticalError3OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError3OperationCompleted);
    this.InvokeAsync("ReportCriticalError3", new object[7]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes
    }, this.ReportCriticalError3OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError3OperationCompleted(object arg)
  {
    if (this.ReportCriticalError3CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    ReportCriticalError3CompletedEventHandler error3CompletedEvent = this.ReportCriticalError3CompletedEvent;
    if (error3CompletedEvent == null)
      return;
    error3CompletedEvent((object) this, new ReportCriticalError3CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  public new void CancelAsync(object userState)
  {
    base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
  }

  private bool IsLocalFileSystemWebService(string url)
  {
    if (url == null || (object) url == (object) string.Empty)
      return false;
    Uri uri = new Uri(url);
    return uri.Port >= 1024 /*0x0400*/ && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
  }
}

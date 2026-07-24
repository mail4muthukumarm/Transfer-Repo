// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MgaReportingServices.CriticalErrorService
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
namespace MGASystems.Common.MgaReportingServices;

[GeneratedCode("System.Web.Services", "4.8.9032.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "CriticalErrorServiceSoap", Namespace = "http://internal.mgasystems.com/CriticalErrorService/")]
public class CriticalErrorService : SoapHttpClientProtocol
{
  private SendOrPostCallback ReportCriticalErrorSqlOperationCompleted;
  private SendOrPostCallback ReportCriticalErrorSqlWithScreenshotOperationCompleted;
  private SendOrPostCallback ReportCriticalErrorOperationCompleted;
  private SendOrPostCallback ReportCriticalError2OperationCompleted;
  private SendOrPostCallback ReportCriticalError1OperationCompleted;
  private SendOrPostCallback ReportCriticalError21OperationCompleted;
  private SendOrPostCallback ReportCriticalError3OperationCompleted;
  private SendOrPostCallback ReportCriticalError4OperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public CriticalErrorService()
  {
    this.Url = MySettings.Default.MgaSystems_IMS_Common_MgaReportingServices_MGAReportingServices;
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

  public event ReportCriticalError2CompletedEventHandler ReportCriticalError2Completed;

  public event ReportCriticalError1CompletedEventHandler ReportCriticalError1Completed;

  public event ReportCriticalError21CompletedEventHandler ReportCriticalError21Completed;

  public event ReportCriticalError3CompletedEventHandler ReportCriticalError3Completed;

  public event ReportCriticalError4CompletedEventHandler ReportCriticalError4Completed;

  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorSql", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public int ReportCriticalErrorSql(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    string sqlProcedure,
    int sqlLineNumber)
  {
    return Conversions.ToInteger(this.Invoke(nameof (ReportCriticalErrorSql), new object[8]
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
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalErrorSqlCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalErrorSqlCompletedEventHandler sqlCompletedEvent = this.ReportCriticalErrorSqlCompletedEvent;
    if (sqlCompletedEvent == null)
      return;
    sqlCompletedEvent((object) this, new ReportCriticalErrorSqlCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorSqlWithScreenshot", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public int ReportCriticalErrorSqlWithScreenshot(
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
    return Conversions.ToInteger(this.Invoke(nameof (ReportCriticalErrorSqlWithScreenshot), new object[9]
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
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalErrorSqlWithScreenshotCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalErrorSqlWithScreenshotCompletedEventHandler screenshotCompletedEvent = this.ReportCriticalErrorSqlWithScreenshotCompletedEvent;
    if (screenshotCompletedEvent == null)
      return;
    screenshotCompletedEvent((object) this, new ReportCriticalErrorSqlWithScreenshotCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorEX", RequestElementName = "ReportCriticalErrorEX", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseElementName = "ReportCriticalErrorEXResponse", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorEXResult")]
  public int ReportCriticalError(
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
    return Conversions.ToInteger(this.Invoke(nameof (ReportCriticalError), new object[10]
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
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalErrorCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalErrorCompletedEventHandler errorCompletedEvent = this.ReportCriticalErrorCompletedEvent;
    if (errorCompletedEvent == null)
      return;
    errorCompletedEvent((object) this, new ReportCriticalErrorCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorEX2", RequestElementName = "ReportCriticalErrorEX2", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseElementName = "ReportCriticalErrorEX2Response", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorEX2Result")]
  public int ReportCriticalError2(
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
    return Conversions.ToInteger(this.Invoke(nameof (ReportCriticalError2), new object[10]
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

  public void ReportCriticalError2Async(
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
    this.ReportCriticalError2Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, innerExceptionSource, innerExceptionStackTrace, innerExceptionTargetSite, innerExceptionType, (object) null);
  }

  public void ReportCriticalError2Async(
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
    if (this.ReportCriticalError2OperationCompleted == null)
      this.ReportCriticalError2OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError2OperationCompleted);
    this.InvokeAsync("ReportCriticalError2", new object[10]
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
    }, this.ReportCriticalError2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError2OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalError2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalError2CompletedEventHandler error2CompletedEvent = this.ReportCriticalError2CompletedEvent;
    if (error2CompletedEvent == null)
      return;
    error2CompletedEvent((object) this, new ReportCriticalError2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError1")]
  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorWithScreenshotEx", RequestElementName = "ReportCriticalErrorWithScreenshotEx", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseElementName = "ReportCriticalErrorWithScreenshotExResponse", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorWithScreenshotExResult")]
  public int ReportCriticalError(
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
    return Conversions.ToInteger(this.Invoke("ReportCriticalError1", new object[11]
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
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalError1CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalError1CompletedEventHandler error1CompletedEvent = this.ReportCriticalError1CompletedEvent;
    if (error1CompletedEvent == null)
      return;
    error1CompletedEvent((object) this, new ReportCriticalError1CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError21")]
  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorWithScreenshotEx2", RequestElementName = "ReportCriticalErrorWithScreenshotEx2", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseElementName = "ReportCriticalErrorWithScreenshotEx2Response", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorWithScreenshotEx2Result")]
  public int ReportCriticalError2(
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
    return Conversions.ToInteger(this.Invoke("ReportCriticalError21", new object[11]
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

  public void ReportCriticalError21Async(
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
    this.ReportCriticalError21Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, imageBytes, innerExceptionSource, innerExceptionStackTrace, innerExceptionTargetSite, innerExceptionType, (object) null);
  }

  public void ReportCriticalError21Async(
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
    if (this.ReportCriticalError21OperationCompleted == null)
      this.ReportCriticalError21OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError21OperationCompleted);
    this.InvokeAsync("ReportCriticalError21", new object[11]
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
    }, this.ReportCriticalError21OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError21OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalError21CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalError21CompletedEventHandler error21CompletedEvent = this.ReportCriticalError21CompletedEvent;
    if (error21CompletedEvent == null)
      return;
    error21CompletedEvent((object) this, new ReportCriticalError21CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError3")]
  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalError", RequestElementName = "ReportCriticalError", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseElementName = "ReportCriticalErrorResponse", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorResult")]
  public int ReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType)
  {
    return Conversions.ToInteger(this.Invoke("ReportCriticalError3", new object[6]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType
    })[0]);
  }

  public void ReportCriticalError3Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType)
  {
    this.ReportCriticalError3Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, (object) null);
  }

  public void ReportCriticalError3Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    object userState)
  {
    if (this.ReportCriticalError3OperationCompleted == null)
      this.ReportCriticalError3OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError3OperationCompleted);
    this.InvokeAsync("ReportCriticalError3", new object[6]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType
    }, this.ReportCriticalError3OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError3OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalError3CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalError3CompletedEventHandler error3CompletedEvent = this.ReportCriticalError3CompletedEvent;
    if (error3CompletedEvent == null)
      return;
    error3CompletedEvent((object) this, new ReportCriticalError3CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [WebMethod(MessageName = "ReportCriticalError4")]
  [SoapDocumentMethod("http://internal.mgasystems.com/CriticalErrorService/ReportCriticalErrorWithScreenshot", RequestElementName = "ReportCriticalErrorWithScreenshot", RequestNamespace = "http://internal.mgasystems.com/CriticalErrorService/", ResponseElementName = "ReportCriticalErrorWithScreenshotResponse", ResponseNamespace = "http://internal.mgasystems.com/CriticalErrorService/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("ReportCriticalErrorWithScreenshotResult")]
  public int ReportCriticalError(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    [XmlElement(DataType = "base64Binary")] byte[] imageBytes)
  {
    return Conversions.ToInteger(this.Invoke("ReportCriticalError4", new object[7]
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

  public void ReportCriticalError4Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes)
  {
    this.ReportCriticalError4Async(clientID, userName, primaryErrorMessage, secondaryErrorMessage, stackTrace, exceptionType, imageBytes, (object) null);
  }

  public void ReportCriticalError4Async(
    int clientID,
    string userName,
    string primaryErrorMessage,
    string secondaryErrorMessage,
    string stackTrace,
    string exceptionType,
    byte[] imageBytes,
    object userState)
  {
    if (this.ReportCriticalError4OperationCompleted == null)
      this.ReportCriticalError4OperationCompleted = new SendOrPostCallback(this.OnReportCriticalError4OperationCompleted);
    this.InvokeAsync("ReportCriticalError4", new object[7]
    {
      (object) clientID,
      (object) userName,
      (object) primaryErrorMessage,
      (object) secondaryErrorMessage,
      (object) stackTrace,
      (object) exceptionType,
      (object) imageBytes
    }, this.ReportCriticalError4OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReportCriticalError4OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ReportCriticalError4CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReportCriticalError4CompletedEventHandler error4CompletedEvent = this.ReportCriticalError4CompletedEvent;
    if (error4CompletedEvent == null)
      return;
    error4CompletedEvent((object) this, new ReportCriticalError4CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

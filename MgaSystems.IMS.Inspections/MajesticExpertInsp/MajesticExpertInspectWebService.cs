// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.MajesticExpertInsp.MajesticExpertInspectWebService
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.IMS.Policies.Inspections.My;
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
namespace MGASystems.IMS.Policies.Inspections.MajesticExpertInsp;

[GeneratedCode("System.Web.Services", "4.8.9032.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "Majestic - ExpertInspect Web ServiceSoap", Namespace = "http://legacy.majesticservice.com/ExpertInspectWS")]
public class MajesticExpertInspectWebService : SoapHttpClientProtocol
{
  private SendOrPostCallback ImportRequestOperationCompleted;
  private SendOrPostCallback ValidateRequestOperationCompleted;
  private SendOrPostCallback GetInspectionRequestOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public MajesticExpertInspectWebService()
  {
    this.Url = MySettings.Default.MgaSystems_IMS_Inspections_MajesticExpertInsp_ExpertInspectWS;
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

  public event ImportRequestCompletedEventHandler ImportRequestCompleted;

  public event ValidateRequestCompletedEventHandler ValidateRequestCompleted;

  public event GetInspectionRequestCompletedEventHandler GetInspectionRequestCompleted;

  [SoapDocumentMethod("http://legacy.majesticservice.com/ExpertInspectWS/ImportRequest", RequestNamespace = "http://legacy.majesticservice.com/ExpertInspectWS", ResponseNamespace = "http://legacy.majesticservice.com/ExpertInspectWS", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ImportRequest(string RequestXML)
  {
    return Conversions.ToString(this.Invoke(nameof (ImportRequest), new object[1]
    {
      (object) RequestXML
    })[0]);
  }

  public IAsyncResult BeginImportRequest(
    string RequestXML,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ImportRequest", new object[1]
    {
      (object) RequestXML
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndImportRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void ImportRequestAsync(string RequestXML)
  {
    this.ImportRequestAsync(RequestXML, (object) null);
  }

  public void ImportRequestAsync(string RequestXML, object userState)
  {
    if (this.ImportRequestOperationCompleted == null)
      this.ImportRequestOperationCompleted = new SendOrPostCallback(this.OnImportRequestOperationCompleted);
    this.InvokeAsync("ImportRequest", new object[1]
    {
      (object) RequestXML
    }, this.ImportRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnImportRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ImportRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ImportRequestCompletedEventHandler requestCompletedEvent = this.ImportRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new ImportRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://legacy.majesticservice.com/ExpertInspectWS/ValidateRequest", RequestNamespace = "http://legacy.majesticservice.com/ExpertInspectWS", ResponseNamespace = "http://legacy.majesticservice.com/ExpertInspectWS", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string ValidateRequest(string RequestXML)
  {
    return Conversions.ToString(this.Invoke(nameof (ValidateRequest), new object[1]
    {
      (object) RequestXML
    })[0]);
  }

  public IAsyncResult BeginValidateRequest(
    string RequestXML,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ValidateRequest", new object[1]
    {
      (object) RequestXML
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndValidateRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void ValidateRequestAsync(string RequestXML)
  {
    this.ValidateRequestAsync(RequestXML, (object) null);
  }

  public void ValidateRequestAsync(string RequestXML, object userState)
  {
    if (this.ValidateRequestOperationCompleted == null)
      this.ValidateRequestOperationCompleted = new SendOrPostCallback(this.OnValidateRequestOperationCompleted);
    this.InvokeAsync("ValidateRequest", new object[1]
    {
      (object) RequestXML
    }, this.ValidateRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnValidateRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ValidateRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ValidateRequestCompletedEventHandler requestCompletedEvent = this.ValidateRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new ValidateRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://legacy.majesticservice.com/ExpertInspectWS/GetInspectionRequest", RequestNamespace = "http://legacy.majesticservice.com/ExpertInspectWS", ResponseNamespace = "http://legacy.majesticservice.com/ExpertInspectWS", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(DataType = "base64Binary")]
  public byte[] GetInspectionRequest(
    string AuthAgencyID,
    string AuthAgencyLogin,
    string AuthAgencyPassword,
    long RID)
  {
    return (byte[]) this.Invoke(nameof (GetInspectionRequest), new object[4]
    {
      (object) AuthAgencyID,
      (object) AuthAgencyLogin,
      (object) AuthAgencyPassword,
      (object) RID
    })[0];
  }

  public IAsyncResult BeginGetInspectionRequest(
    string AuthAgencyID,
    string AuthAgencyLogin,
    string AuthAgencyPassword,
    long RID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetInspectionRequest", new object[4]
    {
      (object) AuthAgencyID,
      (object) AuthAgencyLogin,
      (object) AuthAgencyPassword,
      (object) RID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public byte[] EndGetInspectionRequest(IAsyncResult asyncResult)
  {
    return (byte[]) this.EndInvoke(asyncResult)[0];
  }

  public void GetInspectionRequestAsync(
    string AuthAgencyID,
    string AuthAgencyLogin,
    string AuthAgencyPassword,
    long RID)
  {
    this.GetInspectionRequestAsync(AuthAgencyID, AuthAgencyLogin, AuthAgencyPassword, RID, (object) null);
  }

  public void GetInspectionRequestAsync(
    string AuthAgencyID,
    string AuthAgencyLogin,
    string AuthAgencyPassword,
    long RID,
    object userState)
  {
    if (this.GetInspectionRequestOperationCompleted == null)
      this.GetInspectionRequestOperationCompleted = new SendOrPostCallback(this.OnGetInspectionRequestOperationCompleted);
    this.InvokeAsync("GetInspectionRequest", new object[4]
    {
      (object) AuthAgencyID,
      (object) AuthAgencyLogin,
      (object) AuthAgencyPassword,
      (object) RID
    }, this.GetInspectionRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetInspectionRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetInspectionRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetInspectionRequestCompletedEventHandler requestCompletedEvent = this.GetInspectionRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new GetInspectionRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

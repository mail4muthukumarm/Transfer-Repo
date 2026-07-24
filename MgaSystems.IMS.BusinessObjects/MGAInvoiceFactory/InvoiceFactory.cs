// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.MGAInvoiceFactory.InvoiceFactory
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

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
namespace MGASystems.BusinessObjects.MGAInvoiceFactory;

[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "InvoiceFactorySoap", Namespace = "http://tempuri.org/Invoicing/InvoiceFactory")]
[XmlInclude(typeof (object[]))]
public class InvoiceFactory : SoapHttpClientProtocol
{
  private TokenHeader tokenHeaderValueField;
  private SendOrPostCallback GenerateInvoiceOperationCompleted;
  private SendOrPostCallback GenerateInvoiceAsPDFOperationCompleted;
  private SendOrPostCallback AddPolicyPaymentOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public InvoiceFactory()
  {
    this.Url = "https://webservices.mgasystems.com/ims_development/InvoiceFactory.asmx";
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

  public event GenerateInvoiceCompletedEventHandler GenerateInvoiceCompleted;

  public event GenerateInvoiceAsPDFCompletedEventHandler GenerateInvoiceAsPDFCompleted;

  public event AddPolicyPaymentCompletedEventHandler AddPolicyPaymentCompleted;

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/Invoicing/InvoiceFactory/GenerateInvoice", RequestNamespace = "http://tempuri.org/Invoicing/InvoiceFactory", ResponseNamespace = "http://tempuri.org/Invoicing/InvoiceFactory", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(DataType = "base64Binary")]
  public byte[] GenerateInvoice(int invoiceNumber, object[] args)
  {
    return (byte[]) this.Invoke(nameof (GenerateInvoice), new object[2]
    {
      (object) invoiceNumber,
      (object) args
    })[0];
  }

  public IAsyncResult BeginGenerateInvoice(
    int invoiceNumber,
    object[] args,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GenerateInvoice", new object[2]
    {
      (object) invoiceNumber,
      (object) args
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public byte[] EndGenerateInvoice(IAsyncResult asyncResult)
  {
    return (byte[]) this.EndInvoke(asyncResult)[0];
  }

  public void GenerateInvoiceAsync(int invoiceNumber, object[] args)
  {
    this.GenerateInvoiceAsync(invoiceNumber, args, (object) null);
  }

  public void GenerateInvoiceAsync(int invoiceNumber, object[] args, object userState)
  {
    if (this.GenerateInvoiceOperationCompleted == null)
      this.GenerateInvoiceOperationCompleted = new SendOrPostCallback(this.OnGenerateInvoiceOperationCompleted);
    this.InvokeAsync("GenerateInvoice", new object[2]
    {
      (object) invoiceNumber,
      (object) args
    }, this.GenerateInvoiceOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGenerateInvoiceOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GenerateInvoiceCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GenerateInvoiceCompletedEventHandler invoiceCompletedEvent = this.GenerateInvoiceCompletedEvent;
    if (invoiceCompletedEvent == null)
      return;
    invoiceCompletedEvent((object) this, new GenerateInvoiceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/Invoicing/InvoiceFactory/GenerateInvoiceAsPDF", RequestNamespace = "http://tempuri.org/Invoicing/InvoiceFactory", ResponseNamespace = "http://tempuri.org/Invoicing/InvoiceFactory", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(DataType = "base64Binary")]
  public byte[] GenerateInvoiceAsPDF(int invoiceNumber, object[] args)
  {
    return (byte[]) this.Invoke(nameof (GenerateInvoiceAsPDF), new object[2]
    {
      (object) invoiceNumber,
      (object) args
    })[0];
  }

  public IAsyncResult BeginGenerateInvoiceAsPDF(
    int invoiceNumber,
    object[] args,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GenerateInvoiceAsPDF", new object[2]
    {
      (object) invoiceNumber,
      (object) args
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public byte[] EndGenerateInvoiceAsPDF(IAsyncResult asyncResult)
  {
    return (byte[]) this.EndInvoke(asyncResult)[0];
  }

  public void GenerateInvoiceAsPDFAsync(int invoiceNumber, object[] args)
  {
    this.GenerateInvoiceAsPDFAsync(invoiceNumber, args, (object) null);
  }

  public void GenerateInvoiceAsPDFAsync(int invoiceNumber, object[] args, object userState)
  {
    if (this.GenerateInvoiceAsPDFOperationCompleted == null)
      this.GenerateInvoiceAsPDFOperationCompleted = new SendOrPostCallback(this.OnGenerateInvoiceAsPDFOperationCompleted);
    this.InvokeAsync("GenerateInvoiceAsPDF", new object[2]
    {
      (object) invoiceNumber,
      (object) args
    }, this.GenerateInvoiceAsPDFOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGenerateInvoiceAsPDFOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GenerateInvoiceAsPDFCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GenerateInvoiceAsPDFCompletedEventHandler pdfCompletedEvent = this.GenerateInvoiceAsPDFCompletedEvent;
    if (pdfCompletedEvent == null)
      return;
    pdfCompletedEvent((object) this, new GenerateInvoiceAsPDFCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("TokenHeaderValue")]
  [SoapDocumentMethod("http://tempuri.org/Invoicing/InvoiceFactory/AddPolicyPayment", RequestNamespace = "http://tempuri.org/Invoicing/InvoiceFactory", ResponseNamespace = "http://tempuri.org/Invoicing/InvoiceFactory", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool AddPolicyPayment(
    int InvoiceNum,
    Decimal PaymentAmount,
    string CheckNumber,
    string Comments)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (AddPolicyPayment), new object[4]
    {
      (object) InvoiceNum,
      (object) PaymentAmount,
      (object) CheckNumber,
      (object) Comments
    })[0]);
  }

  public IAsyncResult BeginAddPolicyPayment(
    int InvoiceNum,
    Decimal PaymentAmount,
    string CheckNumber,
    string Comments,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("AddPolicyPayment", new object[4]
    {
      (object) InvoiceNum,
      (object) PaymentAmount,
      (object) CheckNumber,
      (object) Comments
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndAddPolicyPayment(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void AddPolicyPaymentAsync(
    int InvoiceNum,
    Decimal PaymentAmount,
    string CheckNumber,
    string Comments)
  {
    this.AddPolicyPaymentAsync(InvoiceNum, PaymentAmount, CheckNumber, Comments, (object) null);
  }

  public void AddPolicyPaymentAsync(
    int InvoiceNum,
    Decimal PaymentAmount,
    string CheckNumber,
    string Comments,
    object userState)
  {
    if (this.AddPolicyPaymentOperationCompleted == null)
      this.AddPolicyPaymentOperationCompleted = new SendOrPostCallback(this.OnAddPolicyPaymentOperationCompleted);
    this.InvokeAsync("AddPolicyPayment", new object[4]
    {
      (object) InvoiceNum,
      (object) PaymentAmount,
      (object) CheckNumber,
      (object) Comments
    }, this.AddPolicyPaymentOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnAddPolicyPaymentOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.AddPolicyPaymentCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    AddPolicyPaymentCompletedEventHandler paymentCompletedEvent = this.AddPolicyPaymentCompletedEvent;
    if (paymentCompletedEvent == null)
      return;
    paymentCompletedEvent((object) this, new AddPolicyPaymentCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.MVRRequestT
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.iix.com/mvr")]
[Serializable]
public class MVRRequestT
{
  private string requestIDField;
  private string accountField;
  private string billCodeField;
  private string userBatchCodeField;
  private string requestorInitField;
  private string orderPurposeField;
  private string userRefNoField;
  private string quotebackField;
  private string dLStateField;
  private MVRRequestTReportType reportTypeField;
  private string dLNumberField;
  private string dOBField;
  private string lastNameField;
  private string nameSuffixField;
  private string firstNameField;
  private string middleNameField;
  private string genderField;
  private string sSNField;

  public string RequestID
  {
    get => this.requestIDField;
    set => this.requestIDField = value;
  }

  public string Account
  {
    get => this.accountField;
    set => this.accountField = value;
  }

  public string BillCode
  {
    get => this.billCodeField;
    set => this.billCodeField = value;
  }

  public string UserBatchCode
  {
    get => this.userBatchCodeField;
    set => this.userBatchCodeField = value;
  }

  public string RequestorInit
  {
    get => this.requestorInitField;
    set => this.requestorInitField = value;
  }

  public string OrderPurpose
  {
    get => this.orderPurposeField;
    set => this.orderPurposeField = value;
  }

  public string UserRefNo
  {
    get => this.userRefNoField;
    set => this.userRefNoField = value;
  }

  public string Quoteback
  {
    get => this.quotebackField;
    set => this.quotebackField = value;
  }

  public string DLState
  {
    get => this.dLStateField;
    set => this.dLStateField = value;
  }

  public MVRRequestTReportType ReportType
  {
    get => this.reportTypeField;
    set => this.reportTypeField = value;
  }

  public string DLNumber
  {
    get => this.dLNumberField;
    set => this.dLNumberField = value;
  }

  public string DOB
  {
    get => this.dOBField;
    set => this.dOBField = value;
  }

  public string LastName
  {
    get => this.lastNameField;
    set => this.lastNameField = value;
  }

  public string NameSuffix
  {
    get => this.nameSuffixField;
    set => this.nameSuffixField = value;
  }

  public string FirstName
  {
    get => this.firstNameField;
    set => this.firstNameField = value;
  }

  public string MiddleName
  {
    get => this.middleNameField;
    set => this.middleNameField = value;
  }

  public string Gender
  {
    get => this.genderField;
    set => this.genderField = value;
  }

  public string SSN
  {
    get => this.sSNField;
    set => this.sSNField = value;
  }
}

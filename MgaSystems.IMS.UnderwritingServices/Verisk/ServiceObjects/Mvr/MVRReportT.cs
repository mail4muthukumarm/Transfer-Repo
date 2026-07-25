// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.MVRReportT
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
public class MVRReportT
{
  private string reportIDField;
  private string dLStateField;
  private string reportSequenceNumberField;
  private string driverNameField;
  private string driverStreetAddrField;
  private string mVRStatusField;
  private string violationCodingField;
  private string violationCodeTotalField;
  private string mVRFormatField;
  private string mVRReportDateField;
  private string driverCityStateZipField;
  private string dLNumberField;
  private string clientCodeField;
  private string archiveFlagField;
  private string sSNField;
  private string dPPAFlagField;
  private string dMVAccountNumberField;
  private string dOBField;
  private string genderField;
  private string heightField;
  private string weightField;
  private string eyeColorField;
  private string hairColorField;
  private string licClassField;
  private string licStatusField;
  private string dateIssuedField;
  private string dateExpiresField;
  private string restrictionsField;
  private List<string> miscDetailField;
  private List<MVRReportTViolationsViolation> violationsField;

  public string ReportID
  {
    get => this.reportIDField;
    set => this.reportIDField = value;
  }

  public string DLState
  {
    get => this.dLStateField;
    set => this.dLStateField = value;
  }

  public string ReportSequenceNumber
  {
    get => this.reportSequenceNumberField;
    set => this.reportSequenceNumberField = value;
  }

  public string DriverName
  {
    get => this.driverNameField;
    set => this.driverNameField = value;
  }

  public string DriverStreetAddr
  {
    get => this.driverStreetAddrField;
    set => this.driverStreetAddrField = value;
  }

  public string MVRStatus
  {
    get => this.mVRStatusField;
    set => this.mVRStatusField = value;
  }

  public string ViolationCoding
  {
    get => this.violationCodingField;
    set => this.violationCodingField = value;
  }

  public string ViolationCodeTotal
  {
    get => this.violationCodeTotalField;
    set => this.violationCodeTotalField = value;
  }

  public string MVRFormat
  {
    get => this.mVRFormatField;
    set => this.mVRFormatField = value;
  }

  public string MVRReportDate
  {
    get => this.mVRReportDateField;
    set => this.mVRReportDateField = value;
  }

  public string DriverCityStateZip
  {
    get => this.driverCityStateZipField;
    set => this.driverCityStateZipField = value;
  }

  public string DLNumber
  {
    get => this.dLNumberField;
    set => this.dLNumberField = value;
  }

  public string ClientCode
  {
    get => this.clientCodeField;
    set => this.clientCodeField = value;
  }

  public string ArchiveFlag
  {
    get => this.archiveFlagField;
    set => this.archiveFlagField = value;
  }

  public string SSN
  {
    get => this.sSNField;
    set => this.sSNField = value;
  }

  public string DPPAFlag
  {
    get => this.dPPAFlagField;
    set => this.dPPAFlagField = value;
  }

  public string DMVAccountNumber
  {
    get => this.dMVAccountNumberField;
    set => this.dMVAccountNumberField = value;
  }

  public string DOB
  {
    get => this.dOBField;
    set => this.dOBField = value;
  }

  public string Gender
  {
    get => this.genderField;
    set => this.genderField = value;
  }

  public string Height
  {
    get => this.heightField;
    set => this.heightField = value;
  }

  public string Weight
  {
    get => this.weightField;
    set => this.weightField = value;
  }

  public string EyeColor
  {
    get => this.eyeColorField;
    set => this.eyeColorField = value;
  }

  public string HairColor
  {
    get => this.hairColorField;
    set => this.hairColorField = value;
  }

  public string LicClass
  {
    get => this.licClassField;
    set => this.licClassField = value;
  }

  public string LicStatus
  {
    get => this.licStatusField;
    set => this.licStatusField = value;
  }

  public string DateIssued
  {
    get => this.dateIssuedField;
    set => this.dateIssuedField = value;
  }

  public string DateExpires
  {
    get => this.dateExpiresField;
    set => this.dateExpiresField = value;
  }

  public string Restrictions
  {
    get => this.restrictionsField;
    set => this.restrictionsField = value;
  }

  [XmlArrayItem("Detail", typeof (string), IsNullable = false)]
  public List<string> MiscDetail
  {
    get => this.miscDetailField;
    set => this.miscDetailField = value;
  }

  [XmlArrayItem("Violation", typeof (MVRReportTViolationsViolation), IsNullable = false)]
  public List<MVRReportTViolationsViolation> Violations
  {
    get => this.violationsField;
    set => this.violationsField = value;
  }
}

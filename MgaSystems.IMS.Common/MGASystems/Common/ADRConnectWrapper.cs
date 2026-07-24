// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ADRConnectWrapper
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.AdrDemo;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class ADRConnectWrapper : IDisposable, IAdrWrapper
{
  private string _UserName;
  private string _Password;
  private string _accountID;
  private string _encrptedPassword;
  private string _encrptedDeviceID;
  private string _serviceURL;
  private string _xmlResult;
  private string _htmlResult;
  private int _daysLeft;
  private string _product;
  private readonly int _driverID;
  private static object _usingLicenseValidationLookup = (object) null;
  private bool disposedValue;

  public static bool ImplementsLicenseLookup
  {
    get
    {
      if (ADRConnectWrapper._usingLicenseValidationLookup == null)
        ADRConnectWrapper._usingLicenseValidationLookup = (object) (bool) (!SystemSettings.KeyExists("ADR.IncludeLicenseValidationLookup") ? 0 : (SystemSettings.GetBoolSetting("ADR.IncludeLicenseValidationLookup") ? 1 : 0));
      return (bool) ADRConnectWrapper._usingLicenseValidationLookup;
    }
  }

  public string HtmlResult => this._htmlResult;

  public string XmlResult => this._xmlResult;

  public int DaysLeft => this._daysLeft;

  public string Product
  {
    get => this._product;
    set => this._product = value;
  }

  public ADRConnectWrapper()
  {
    this._UserName = string.Empty;
    this._Password = string.Empty;
    this._accountID = string.Empty;
    this._encrptedPassword = string.Empty;
    this._encrptedDeviceID = string.Empty;
    this._serviceURL = string.Empty;
    this._xmlResult = string.Empty;
    this._htmlResult = string.Empty;
    this._daysLeft = -1;
    this._product = string.Empty;
    this._driverID = -1;
    this.GetCredentials();
  }

  public ADRConnectWrapper(int driverID)
  {
    this._UserName = string.Empty;
    this._Password = string.Empty;
    this._accountID = string.Empty;
    this._encrptedPassword = string.Empty;
    this._encrptedDeviceID = string.Empty;
    this._serviceURL = string.Empty;
    this._xmlResult = string.Empty;
    this._htmlResult = string.Empty;
    this._daysLeft = -1;
    this._product = string.Empty;
    this._driverID = -1;
    this._driverID = driverID;
    this.GetCredentials();
  }

  private void GetCredentials()
  {
    if (SystemSettings.KeyExists("ADRUserName"))
      this._UserName = SystemSettings.GetStringSetting("ADRUserName");
    if (SystemSettings.KeyExists("ADRPassword"))
      this._Password = SystemSettings.GetStringSetting("ADRPassword");
    if (SystemSettings.KeyExists("ADRAccountID"))
      this._accountID = SystemSettings.GetStringSetting("ADRAccountID");
    if (SystemSettings.KeyExists("ADR_URL"))
      this._serviceURL = SystemSettings.GetStringSetting("ADR_URL");
    ADRFormatCredentials objectEx = (ADRFormatCredentials) ObjectFactory.Instance.CreateObjectEX(typeof (ADRFormatCredentials), (object) this._Password);
    this._encrptedPassword = objectEx.EncryptedPassword();
    this._encrptedDeviceID = objectEx.EncryptedDeviceID();
  }

  public bool IsValidCredentials
  {
    get
    {
      return !this._UserName.Equals(string.Empty) && !this._Password.Equals(string.Empty) && !this._accountID.Equals(string.Empty);
    }
  }

  public string ProcessDriverInformation(DriverRecord arrDrivers)
  {
    string str1;
    if (!this.IsValidCredentials)
    {
      str1 = string.Empty;
    }
    else
    {
      string str2 = string.Empty;
      MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.InteractiveResponseEntity interactiveResponseEntity = (MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.InteractiveResponseEntity) null;
      try
      {
        using (AdrConnectWebServiceClient webServiceClient = new AdrConnectWebServiceClient("BasicHttpBinding_IAdrConnectWebService"))
        {
          string inCommunications = this.InCommunicationString(arrDrivers);
          MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity communicationOrders = this.GetCommunicationOrders(arrDrivers);
          interactiveResponseEntity = webServiceClient.OrderInteractive(inCommunications, communicationOrders);
          webServiceClient.Close();
        }
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        string message = ex2.Message;
        if (!string.IsNullOrEmpty(ex2.InnerException.ToString()))
          message = ex2.InnerException.ToString();
        int num = (int) MessageBox.Show("ADR service experiences the following error: \n\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ErrorHandler.SilentHandleError(ex2);
        throw;
      }
      if (interactiveResponseEntity != null && interactiveResponseEntity.Report.Formats.Length > 0)
      {
        str2 = interactiveResponseEntity.Report.Formats[0].Data;
        this._htmlResult = interactiveResponseEntity.Report.Formats[0].Data;
        this._xmlResult = interactiveResponseEntity.Report.Formats[1].Data;
        if (interactiveResponseEntity.CallValidation != null && interactiveResponseEntity.CallValidation != null)
          this._daysLeft = interactiveResponseEntity.CallValidation.DaysLeft;
        if (this._driverID != -1)
        {
          string xString = ADRConnectWrapper.EscapeString(this.XmlResult);
          try
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update tblDriverInfo set DriverXML = @xml, MVRDate = @MVRDate where DriverID = @DriverID", new object[6]
            {
              (object) "@xml",
              (object) xString,
              (object) "@MVRDate",
              (object) CurrentUser.ServerTime,
              (object) "@DriverID",
              (object) this._driverID
            });
          }
          catch (Exception ex3)
          {
            ProjectData.SetProjectError(ex3);
            Exception ex4 = ex3;
            this.LogSavingException();
            ErrorHandler.SilentHandleError(ex4);
            ProjectData.ClearProjectError();
          }
          this.SaveDriverRequestsDataPoints(xString);
        }
      }
      else if (interactiveResponseEntity != null && interactiveResponseEntity.CallValidation != null)
      {
        this._daysLeft = interactiveResponseEntity.CallValidation.DaysLeft;
        string str3 = string.Empty;
        if (this._daysLeft != -1)
          str3 = $"Days left to password change - {this._daysLeft.ToString()}.";
        int num = (int) MessageBox.Show($"{str3}\n\nADR service returns the following error message - \n\n{interactiveResponseEntity.CallValidation.ErrorDescription}", "Service Error Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      str1 = str2;
    }
    return str1;
  }

  public static string EscapeString(string xmlString)
  {
    string str = xmlString.Replace("]]>", string.Empty).Replace("<![CDATA[", string.Empty).Replace("&", "&amp;").Replace("\\", "& quot;").Replace("'", "&apos;");
    string[] strArray = new string[26]
    {
      "§",
      "†",
      "∟",
      "¦",
      "[",
      "]",
      "à",
      "â",
      "ê",
      "ĝ",
      "î",
      "Ô",
      "û",
      "¬",
      "\u001C",
      "\u0019",
      "⊣",
      "°",
      "µ",
      "¿",
      "À",
      "Â",
      "Ç",
      "Ê",
      "Î",
      "Û"
    };
    int index = 0;
    while (index < strArray.Length)
    {
      string oldValue = strArray[index];
      str = str.Replace(oldValue, string.Empty);
      checked { ++index; }
    }
    return str;
  }

  public string SendOvernightOrders(DriverRecord arrDrivers)
  {
    string str1;
    if (!this.IsValidCredentials)
    {
      str1 = string.Empty;
    }
    else
    {
      string str2 = string.Empty;
      MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.SendOrdersResponseEntity ordersResponseEntity = (MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.SendOrdersResponseEntity) null;
      try
      {
        using (AdrConnectWebServiceClient webServiceClient = new AdrConnectWebServiceClient("BasicHttpBinding_IAdrConnectWebService"))
        {
          string inCommunication = this.InCommunicationString(arrDrivers);
          MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity[] communicationOrders = this.GetOvernightCommunicationOrders(arrDrivers);
          ordersResponseEntity = webServiceClient.SendOrders(inCommunication, communicationOrders);
          webServiceClient.Close();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string message = exception.Message;
        if (!string.IsNullOrEmpty(exception.InnerException.ToString()))
          message = exception.InnerException.ToString();
        if (ordersResponseEntity != null && ordersResponseEntity.CallValidation != null)
          this._daysLeft = ordersResponseEntity.CallValidation.DaysLeft;
        string str3 = string.Empty;
        if (this._daysLeft != -1)
          str3 = $"Days left to password change - {this._daysLeft.ToString()}.";
        int num = (int) MessageBox.Show($"{str3}\n\nADR service experiences the following error:  \n\n{message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        throw;
      }
      if (ordersResponseEntity != null & ordersResponseEntity.OrderSummary.Length > 0)
      {
        str2 = ordersResponseEntity.OrderSummary[0].Result;
        if (ordersResponseEntity != null && ordersResponseEntity.CallValidation != null)
          this._daysLeft = ordersResponseEntity.CallValidation.DaysLeft;
      }
      else if (ordersResponseEntity != null && ordersResponseEntity.CallValidation != null)
      {
        this._daysLeft = ordersResponseEntity.CallValidation.DaysLeft;
        string str4 = string.Empty;
        if (this._daysLeft != -1)
          str4 = $"Days left to password change - {this._daysLeft.ToString()}.";
        int num = (int) MessageBox.Show($"{str4}\n\nADR service returns the following error message - \n\n{ordersResponseEntity.CallValidation.ErrorDescription}", "Service Error Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      str1 = str2;
    }
    return str1;
  }

  public string[] ReceiveOvernightOrders()
  {
    List<string> stringList = new List<string>();
    string[] array;
    if (!this.IsValidCredentials)
    {
      int num = (int) MessageBox.Show("ADR credentials are not valid.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      array = stringList.ToArray();
    }
    else
    {
      MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.ReceiveRecordsResponseEntity recordsResponseEntity = (MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.ReceiveRecordsResponseEntity) null;
      try
      {
        using (AdrConnectWebServiceClient webServiceClient = new AdrConnectWebServiceClient("BasicHttpBinding_IAdrConnectWebService"))
        {
          string inCommunications = this.InCommunicationString((DriverRecord) null);
          recordsResponseEntity = webServiceClient.ReceiveRecords(inCommunications);
          webServiceClient.Close();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string message = exception.Message;
        if (!string.IsNullOrEmpty(exception.InnerException.ToString()))
          message = exception.InnerException.ToString();
        int num = (int) MessageBox.Show("ADR service experiences the following error: \n\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        throw;
      }
      if (recordsResponseEntity != null & recordsResponseEntity.Reports.Length > 0)
      {
        MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.RecordEntity[] reports = recordsResponseEntity.Reports;
        int index = 0;
        while (index < reports.Length)
        {
          MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.RecordEntity recordEntity = reports[index];
          stringList.Add(recordEntity.Formats[0].Data);
          checked { ++index; }
        }
      }
      array = stringList.ToArray();
    }
    return array;
  }

  private string InCommunicationString(DriverRecord arrDrivers)
  {
    StringBuilder stringBuilder = new StringBuilder();
    string str1 = "\"";
    string str2 = "<?xml version=\"1.0\"?>";
    stringBuilder.AppendLine(str2);
    string str3 = "<Communications>";
    stringBuilder.AppendLine(str3);
    if (arrDrivers != null && arrDrivers.ProductID != null && arrDrivers.ProductID != DBNull.Value && arrDrivers.ProductID.ToString().Equals("LX"))
    {
      string str4 = "<Host>Online</Host>";
      stringBuilder.AppendLine(str4);
    }
    string str5 = $"<Account>{this._accountID}</Account>";
    stringBuilder.AppendLine(str5);
    string str6 = $"<UserID>{this._UserName}</UserID>";
    stringBuilder.AppendLine(str6);
    if (arrDrivers != null && arrDrivers.ProductID != null && arrDrivers.ProductID != DBNull.Value && !this.Product.Equals("LX"))
    {
      string str7 = $"<Password format={str1}encrypted{str1}>{this._encrptedPassword}</Password>";
      stringBuilder.AppendLine(str7);
    }
    else
    {
      string str8 = $"<Password>{this._Password}</Password>";
      stringBuilder.AppendLine(str8);
    }
    string str9 = $"<DeviceID format={str1}encoded{str1}>{this._encrptedDeviceID}</DeviceID>";
    stringBuilder.AppendLine(str9);
    string str10 = "<ReportTypes>";
    stringBuilder.AppendLine(str10);
    string str11 = "<Type>HTML</Type>";
    stringBuilder.AppendLine(str11);
    if (arrDrivers != null && arrDrivers.ProductID.ToString().Equals("LX"))
    {
      string str12 = "<Type>XML2.03</Type>";
      stringBuilder.AppendLine(str12);
    }
    else
    {
      string str13 = "<Type>XML2.00</Type>";
      stringBuilder.AppendLine(str13);
    }
    string str14 = "</ReportTypes>";
    stringBuilder.AppendLine(str14);
    string str15 = "</Communications>";
    stringBuilder.AppendLine(str15);
    return stringBuilder.ToString();
  }

  private MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity[] GetOvernightCommunicationOrders(
    DriverRecord arrDriver)
  {
    return new MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity[1]
    {
      new MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity()
      {
        OrderXml = this.GetDriverOrder(arrDriver)
      }
    };
  }

  private MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity GetCommunicationOrders(
    DriverRecord arrDriver)
  {
    return new MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.OrderEntity()
    {
      OrderXml = this.GetDriverOrder(arrDriver)
    };
  }

  private string GetDriverOrder(DriverRecord dr)
  {
    StringBuilder stringBuilder = new StringBuilder();
    string str1 = "<?xml version=\"1.0\"?>";
    stringBuilder.AppendLine(str1);
    string str2 = "<Order>";
    stringBuilder.AppendLine(str2);
    string str3 = $"<Account>{this._accountID}</Account>";
    stringBuilder.AppendLine(str3);
    string str4 = $"<Billing>{dr.Billing}</Billing>";
    stringBuilder.AppendLine(str4);
    string str5 = "<Handling>OL</Handling>";
    if (dr.DriverState.Equals((object) "HI"))
      str5 = "<Handling>AO</Handling>";
    stringBuilder.AppendLine(str5);
    string str6 = "<State>";
    stringBuilder.AppendLine(str6);
    string str7 = dr.DateOfBirth == null ? "<Abbrev></Abbrev>" : $"<Abbrev>{dr.DriverState.ToString()}</Abbrev>";
    stringBuilder.AppendLine(str7);
    string str8 = "<Full></Full>";
    stringBuilder.AppendLine(str8);
    string str9 = "</State>";
    stringBuilder.AppendLine(str9);
    string str10 = $"<ProductID>{dr.ProductID.ToString()}</ProductID>";
    stringBuilder.AppendLine(str10);
    string str11 = $"<Purpose>{dr.Purpose.ToString()}</Purpose>";
    stringBuilder.AppendLine(str11);
    string str12 = string.IsNullOrEmpty(dr.Reference) ? (dr.Misc == null ? $"<Misc>{this.RemoveSpecialChars(dr.InsuredName)}</Misc>" : $"<Misc>{dr.Misc.ToString()}</Misc>") : $"<Misc>{dr.Reference}</Misc>";
    stringBuilder.AppendLine(str12);
    string str13 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(dr.SubType)) ? $"<Subtype>{dr.SubType.ToString()}</Subtype>" : "<Subtype>ST</Subtype>";
    stringBuilder.AppendLine(str13);
    if (dr.ProductID.Equals((object) "LX") && !string.IsNullOrEmpty(dr.HintMvrInsuranceOption))
    {
      string str14 = $"<HintMvrInsuranceOption>{dr.HintMvrInsuranceOption}</HintMvrInsuranceOption>";
      stringBuilder.AppendLine(str14);
    }
    if (dr.ProductID.Equals((object) "LX"))
    {
      string str15 = "<HintVertical>Insurance</HintVertical>";
      stringBuilder.AppendLine(str15);
    }
    if (ADRConnectWrapper.ImplementsLicenseLookup && dr.LicenseValidationLookup)
    {
      string str16 = "<LicenseValidationLookupFlag>Y</LicenseValidationLookupFlag>";
      stringBuilder.AppendLine(str16);
      string str17 = "<DocumentType>License</DocumentType>";
      stringBuilder.AppendLine(str17);
    }
    string str18 = $"<License>{dr.License}</License>";
    stringBuilder.AppendLine(str18);
    string str19 = $"<FirstName>{this.RemoveSpecialChars(dr.FirstName)}</FirstName>";
    stringBuilder.AppendLine(str19);
    string str20 = $"<MiddleName>{this.RemoveSpecialChars(dr.MiddleName)}</MiddleName>";
    stringBuilder.AppendLine(str20);
    string str21 = $"<LastName>{this.RemoveSpecialChars(dr.LastName)}</LastName>";
    stringBuilder.AppendLine(str21);
    string str22 = $"<Suffix>{this.RemoveSpecialChars(dr.Suffix)}</Suffix>";
    stringBuilder.AppendLine(str22);
    string str23 = "<DOB>";
    stringBuilder.AppendLine(str23);
    string str24;
    if (dr.DateOfBirth != null)
    {
      string str25 = $"<Year>{Conversions.ToString(Conversions.ToDate(dr.DateOfBirth).Year)}</Year>";
      stringBuilder.AppendLine(str25);
      string str26 = $"<Month>{Conversions.ToString(Conversions.ToDate(dr.DateOfBirth).Month)}</Month>";
      stringBuilder.AppendLine(str26);
      str24 = $"<Day>{Conversions.ToString(Conversions.ToDate(dr.DateOfBirth).Day)}</Day>";
    }
    else
    {
      string str27 = "<Year></Year>";
      stringBuilder.AppendLine(str27);
      string str28 = "<Month></Month>";
      stringBuilder.AppendLine(str28);
      str24 = "<Day></Day>";
    }
    stringBuilder.AppendLine(str24);
    string str29 = "</DOB>";
    stringBuilder.AppendLine(str29);
    string str30 = "</Order>";
    stringBuilder.AppendLine(str30);
    if (this._driverID != -1)
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update tblDriverInfo set RequestXml = @RequestXml where DriverID = @DriverID", new object[4]
        {
          (object) "@RequestXml",
          (object) stringBuilder.ToString(),
          (object) "@DriverID",
          (object) this._driverID
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentHandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
    return stringBuilder.ToString();
  }

  protected virtual void Dispose(bool disposing)
  {
    if (!this.disposedValue)
    {
      int num = disposing ? 1 : 0;
    }
    this.disposedValue = true;
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  private string RemoveSpecialChars(string str)
  {
    string str1;
    if (Utility.IsNull((object) str))
      str1 = string.Empty;
    else if (str.Length == 0)
    {
      str1 = str;
    }
    else
    {
      string[] source = new string[11]
      {
        "<",
        ">",
        "&",
        "'",
        "\"",
        "!",
        "@",
        "#",
        "$",
        "%",
        "^"
      };
      string empty = string.Empty;
      char[] charArray = str.ToCharArray();
      int index = 0;
      while (index < charArray.Length)
      {
        char ch = charArray[index];
        if (!((IEnumerable<string>) source).Contains<string>(Conversions.ToString(ch)))
          empty += Conversions.ToString(ch);
        checked { ++index; }
      }
      str1 = empty;
    }
    return str1;
  }

  public bool IsDemoService()
  {
    return SystemSettings.KeyExists("ADRUseDemoService") && SystemSettings.GetBoolSetting("ADRUseDemoService");
  }

  private MGASystems.Common.AdrDemo.OrderEntity GetDemoCommunicationOrders(DriverRecord arrDriver)
  {
    return new MGASystems.Common.AdrDemo.OrderEntity()
    {
      OrderXml = this.GetDriverOrder(arrDriver)
    };
  }

  public string ProcessDemoInformation(DriverRecord arrDrivers)
  {
    string str1;
    if (!this.IsValidCredentials)
    {
      str1 = string.Empty;
    }
    else
    {
      string str2 = string.Empty;
      MGASystems.Common.AdrDemo.InteractiveResponseEntity interactiveResponseEntity = (MGASystems.Common.AdrDemo.InteractiveResponseEntity) null;
      try
      {
        using (BasicHttpBinding_IAdrConnectWebService connectWebService = new BasicHttpBinding_IAdrConnectWebService())
        {
          string inCommunications = this.InCommunicationString(arrDrivers);
          MGASystems.Common.AdrDemo.OrderEntity communicationOrders = this.GetDemoCommunicationOrders(arrDrivers);
          interactiveResponseEntity = connectWebService.OrderInteractive(inCommunications, communicationOrders);
        }
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        string message = ex2.Message;
        if (!string.IsNullOrEmpty(ex2.InnerException.ToString()))
          message = ex2.InnerException.ToString();
        int num = (int) MessageBox.Show("ADR -Demo- service experiences the following error: \n\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ErrorHandler.SilentHandleError(ex2);
        throw;
      }
      if (interactiveResponseEntity != null && interactiveResponseEntity.Report.Formats.Length > 0)
      {
        str2 = interactiveResponseEntity.Report.Formats[0].Data;
        this._htmlResult = interactiveResponseEntity.Report.Formats[0].Data;
        this._xmlResult = interactiveResponseEntity.Report.Formats[1].Data;
        if (interactiveResponseEntity.CallValidation != null && interactiveResponseEntity.CallValidation != null)
          this._daysLeft = interactiveResponseEntity.CallValidation.DaysLeft;
        if (this._driverID != -1)
        {
          string xString = ADRConnectWrapper.EscapeString(this.XmlResult);
          try
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update tblDriverInfo set DriverXML = @xml, MVRDate = @MVRDate where DriverID = @DriverID", new object[6]
            {
              (object) "@xml",
              (object) xString,
              (object) "@MVRDate",
              (object) CurrentUser.ServerTime,
              (object) "@DriverID",
              (object) this._driverID
            });
          }
          catch (Exception ex3)
          {
            ProjectData.SetProjectError(ex3);
            Exception ex4 = ex3;
            this.LogSavingException();
            ErrorHandler.SilentHandleError(ex4);
            ProjectData.ClearProjectError();
          }
          this.SaveDriverRequestsDataPoints(xString);
        }
      }
      else if (interactiveResponseEntity != null && interactiveResponseEntity.CallValidation != null)
      {
        this._daysLeft = interactiveResponseEntity.CallValidation.DaysLeft;
        string str3 = string.Empty;
        if (this._daysLeft != -1)
          str3 = $"Days left to password change - {this._daysLeft.ToString()}.";
        int num = (int) MessageBox.Show($"{str3}\n\nADR service returns the following error message - \n\n{interactiveResponseEntity.CallValidation.ErrorDescription}", "Service Error Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      str1 = str2;
    }
    return str1;
  }

  private void SaveDriverRequestsDataPoints(string xString)
  {
    object obj1 = (object) DBNull.Value;
    object obj2 = (object) DBNull.Value;
    object obj3 = (object) DBNull.Value;
    if (xString.Contains("<Result>") && xString.Contains("</Result>"))
    {
      string tagsValueString1 = XMLFunctions.GetTagsValueString(xString, "<Result>", "</Result>");
      if (tagsValueString1.Length > 0)
      {
        string tagsValueString2 = XMLFunctions.GetTagsValueString(tagsValueString1, "<IsClear>", "</IsClear>");
        if (tagsValueString2.Length > 0)
          obj1 = (object) tagsValueString2;
        string tagsValueString3 = XMLFunctions.GetTagsValueString(tagsValueString1, "<Valid>", "</Valid>");
        if (tagsValueString3.Length > 0)
          obj2 = (object) tagsValueString3;
      }
    }
    if (xString.Contains("<OrderDate>") && xString.Contains("</OrderDate>"))
    {
      string tagsValueString4 = XMLFunctions.GetTagsValueString(xString, "<OrderDate>", "</OrderDate>");
      if (tagsValueString4.Length > 0)
      {
        string tagsValueString5 = XMLFunctions.GetTagsValueString(tagsValueString4, "<Year>", "</Year>");
        string tagsValueString6 = XMLFunctions.GetTagsValueString(tagsValueString4, "<Month>", "</Month>");
        string tagsValueString7 = XMLFunctions.GetTagsValueString(tagsValueString4, "<Day>", "</Day>");
        obj3 = (object) new DateTime(Conversions.ToInteger(tagsValueString5), Conversions.ToInteger(tagsValueString6), Conversions.ToInteger(tagsValueString7));
      }
    }
    DefaultDatabase.ExecuteNonQuery("spSaveDriverDataPoints", new object[8]
    {
      (object) "@DriverID",
      (object) this._driverID,
      (object) "@OrderDate",
      obj3,
      (object) "@Valid",
      obj2,
      (object) "@IsClear",
      obj1
    });
  }

  private void LogSavingException()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update tblDriverInfo set MVRDate = @MVRDate where DriverID = @DriverID", new object[4]
    {
      (object) "@MVRDate",
      (object) CurrentUser.ServerTime,
      (object) "@DriverID",
      (object) this._driverID
    });
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ControlNo, FirstName, LastName FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this._driverID
    });
    if (row == null)
      return;
    string str1 = string.Empty;
    string str2 = string.Empty;
    if (!row.IsNull("FirstName"))
      str1 = row.Field<string>("FirstName");
    if (!row.IsNull("LastName"))
      str2 = row.Field<string>("LastName");
    if (row.IsNull("ControlNo"))
      return;
    Guid identifier = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo =@CN ORDER BY QuoteID DESC", new object[2]
    {
      (object) "@CN",
      (object) row.Field<int>("ControlNo")
    });
    CurrentUser.Instance.LogAction($"Saving of the XML for driver {str1} {str2} fails.", identifier);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ixWrapper
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.iixService;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class ixWrapper : IDisposable
{
  private string _userName;
  private string _pw;
  private string _xmlResult;
  private readonly int _driverID;
  private string _accountID;
  private string _url;
  private string _billingCode;
  private string _errorMessage;
  private bool _validRequest;
  private int _acceptID;
  private string _requestData;
  private string _responseData;
  private string _requestType;
  private string _pdfResult;
  private readonly string _driverFirstName;
  private readonly string _driverLastName;
  private readonly Guid _quoteGuid;
  private bool disposedValue;

  public ixWrapper(int driverID)
  {
    this._userName = string.Empty;
    this._pw = string.Empty;
    this._xmlResult = string.Empty;
    this._accountID = string.Empty;
    this._url = string.Empty;
    this._billingCode = string.Empty;
    this._errorMessage = string.Empty;
    this._acceptID = int.MinValue;
    this._requestData = string.Empty;
    this._responseData = string.Empty;
    this._pdfResult = string.Empty;
    this._driverFirstName = string.Empty;
    this._driverLastName = string.Empty;
    this._quoteGuid = Guid.Empty;
    this._driverID = driverID;
    this.Initialize();
    if (!this.ValidCredentails)
      throw new InvalidOperationException("IIX Service is missing credentials - Username, Password, URL and Bill Code required.");
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT FirstName, LastName, ControlNo FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this._driverID
    });
    if (row == null)
      return;
    if (!row.IsNull("FirstName"))
      this._driverFirstName = row.Field<string>("FirstName");
    if (!row.IsNull("LastName"))
      this._driverLastName = row.Field<string>("LastName");
    if (row.IsNull("ControlNo"))
      return;
    this._quoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @CN ORDER BY QuoteID DESC", new object[2]
    {
      (object) "@CN",
      (object) row.Field<int>("ControlNo")
    });
  }

  public string XmlResult => this._xmlResult;

  public string PDFResult => this._pdfResult;

  public string ErrorMessage => this._errorMessage;

  public bool ValidRequest => this._validRequest;

  public int AcceptID => this._acceptID;

  public string RequestData => this._requestData;

  public string ResponseData => this._responseData;

  public string RequestType
  {
    get => this._requestType;
    set => this._requestType = value;
  }

  private bool ValidCredentails
  {
    get
    {
      return !this._userName.Equals(string.Empty) && !this._pw.Equals(string.Empty) && !this._url.Equals(string.Empty) && !this._billingCode.Equals(string.Empty);
    }
  }

  private void Initialize()
  {
    if (SystemSettings.KeyExists("IIXUserName"))
      this._userName = SystemSettings.GetStringSetting("IIXUserName");
    if (SystemSettings.KeyExists("IIXPassword"))
      this._pw = SystemSettings.GetStringSetting("IIXPassword");
    if (SystemSettings.KeyExists("IIXAccountID"))
      this._accountID = SystemSettings.GetStringSetting("IIXAccountID");
    if (SystemSettings.KeyExists("IIXurl"))
      this._url = SystemSettings.GetStringSetting("IIXurl");
    if (!SystemSettings.KeyExists("IIXBillingCode"))
      return;
    this._billingCode = SystemSettings.GetStringSetting("IIXBillingCode");
  }

  public bool ProcessXmlRequest() => this.ProcessRequest(ixWrapper.ReportFormat.XML);

  private bool IsErrorMessage(string str) => str.ToUpper().StartsWith("ERROR:");

  private bool ProcessRequest(ixWrapper.ReportFormat responseFormat)
  {
    bool flag = false;
    this._requestData = this.AssembleRequestString();
    this._validRequest = false;
    this._errorMessage = string.Empty;
    this._acceptID = int.MinValue;
    this._responseData = string.Empty;
    using (auth auth = new auth())
    {
      auth.Url = this._url;
      auth.Credentials = (ICredentials) new NetworkCredential(this._userName, this._pw);
      this._responseData = auth.sendRequest2(this._requestData);
      if (this.IsValidResponse(this._responseData, ref this._acceptID))
      {
        string msgString = this.ConstructRequest(this._acceptID);
        if (responseFormat == ixWrapper.ReportFormat.Both)
        {
          int num1 = 0;
          do
          {
            this._errorMessage = string.Empty;
            string xmlResponse2 = auth.getXmlResponse2(msgString);
            if (this.IsErrorMessage(xmlResponse2))
            {
              this._validRequest = false;
              this._errorMessage = xmlResponse2;
            }
            else
            {
              this._validRequest = true;
              this._xmlResult = xmlResponse2;
            }
            if (!this._validRequest && !this._validRequest && (xmlResponse2.ToUpper().Contains("RESPONSE NOT YET AVAILABLE") || this._errorMessage.ToUpper().Contains("RESPONSE NOT YET AVAILABLE")))
            {
              this.LogNoResponse();
              flag = true;
              Thread.Sleep(3000);
              ++num1;
            }
            else
              break;
          }
          while (num1 <= 2);
          int num2 = 0;
          do
          {
            this._errorMessage = string.Empty;
            string pdfResponse2 = auth.getPdfResponse2(msgString);
            if (this.IsErrorMessage(pdfResponse2))
            {
              this._validRequest = false;
              this._errorMessage = pdfResponse2;
            }
            else
            {
              this._validRequest = true;
              this._pdfResult = pdfResponse2;
            }
            if (!this._validRequest)
            {
              if (!this._validRequest)
              {
                if (!pdfResponse2.ToUpper().Contains("RESPONSE NOT YET AVAILABLE"))
                {
                  if (!this._errorMessage.ToUpper().Contains("RESPONSE NOT YET AVAILABLE"))
                    break;
                }
                this.LogNoResponse();
                flag = true;
                Thread.Sleep(3000);
                ++num2;
              }
              else
                break;
            }
            else
              break;
          }
          while (num2 <= 2);
        }
        else
        {
          int num = 0;
          do
          {
            this._errorMessage = string.Empty;
            string str = responseFormat != ixWrapper.ReportFormat.XML ? auth.getPdfResponse2(msgString) : auth.getXmlResponse2(msgString);
            if (this.IsErrorMessage(str))
            {
              this._errorMessage = str;
              this._validRequest = false;
            }
            else
            {
              this._validRequest = true;
              if (responseFormat == ixWrapper.ReportFormat.XML)
                this._xmlResult = str;
              else
                this._pdfResult = str;
            }
            if (!this._validRequest)
            {
              if (!this._validRequest)
              {
                if (!str.ToUpper().Contains("RESPONSE NOT YET AVAILABLE"))
                {
                  if (!this._errorMessage.ToUpper().Contains("RESPONSE NOT YET AVAILABLE"))
                    break;
                }
                this.LogNoResponse();
                flag = true;
                Thread.Sleep(3000);
                ++num;
              }
              else
                break;
            }
            else
              break;
          }
          while (num <= 2);
        }
      }
    }
    if (this._validRequest)
      CurrentUser.Instance.LogAction($"Verisk Driver Record - Driver {this._driverFirstName} {this._driverLastName} request was successful", this._quoteGuid);
    if (flag)
      Application.DoEvents();
    return this._validRequest;
  }

  public bool ProcessBothRequests() => this.ProcessRequest(ixWrapper.ReportFormat.Both);

  public bool ProcessPdfRequest() => this.ProcessRequest(ixWrapper.ReportFormat.PDF);

  private bool IsValidResponse(string response, ref int acceptID)
  {
    bool flag = false;
    acceptID = int.MinValue;
    if (response.ToUpper().Contains("ACCEPT:"))
    {
      flag = true;
      acceptID = Convert.ToInt32(response.Substring(response.ToUpper().IndexOf("ACCEPT:") + "ACCEPT:".Length, 9));
    }
    return flag;
  }

  private string GetDriverDataPoint(string columnName)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, $"SELECT {columnName} FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this._driverID
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? string.Empty : objectValue.ToString();
  }

  private string AssembleRequestString()
  {
    string str1 = "00" + ixWrapper.Padding(this._userName, 3) + ixWrapper.Padding(this._pw, 20) + ixWrapper.Padding(this._accountID, 6) + ixWrapper.Padding(this._billingCode, 3) + "MVR" + "I" + this.GetDriverDataPoint("StateID") + "000" + "000000" + ixWrapper.Padding(this.GetDriverDataPoint("LicenseNumber").Replace(" ", "").Replace("-", string.Empty).ToUpper(), 19) + ixWrapper.Padding(this.GetDriverDataPoint("LastName"), 20) + ixWrapper.GenerateSpaceString(3) + ixWrapper.Padding(this.GetDriverDataPoint("FirstName"), 15) + ixWrapper.GenerateSpaceString(15);
    string str2 = this.GetDriverDataPoint("DOB");
    if (!string.IsNullOrEmpty(str2))
      str2 = $"{Conversions.ToDate(str2).ToString("MM")}{Conversions.ToDate(str2).ToString("dd")}{Conversions.ToDate(str2).ToString("yyyy")}";
    else
      str1 += ixWrapper.GenerateSpaceString(8);
    return str1 + str2 + ixWrapper.GenerateSpaceString(1) + ixWrapper.GenerateSpaceString(8) + ixWrapper.GenerateSpaceString(40) + (this.RequestType.Equals("&") ? " " : this.RequestType) + "V20" + ixWrapper.GenerateSpaceString(1) + ixWrapper.GenerateSpaceString(9) + ixWrapper.GenerateSpaceString(30);
  }

  private static string Padding(string str, int numberChars) => str.PadRight(numberChars, ' ');

  private static string GenerateSpaceString(int len)
  {
    string empty = string.Empty;
    int num = len - 1;
    for (int index = 0; index <= num; ++index)
      empty += " ";
    return empty;
  }

  private string ConstructRequest(int acceptID)
  {
    return "00" + ixWrapper.Padding(this._userName, 3) + ixWrapper.Padding(this._pw, 20) + ixWrapper.Padding(this._accountID, 6) + ixWrapper.Padding(this._billingCode, 3) + "MVR" + acceptID.ToString();
  }

  private void LogNoResponse()
  {
    CurrentUser.Instance.LogAction($"Verisk Driver Record - Driver {this._driverFirstName} {this._driverLastName} has no response available", this._quoteGuid);
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  protected virtual void Dispose(bool disposing)
  {
    if (!this.disposedValue)
    {
      int num = disposing ? 1 : 0;
    }
    this.disposedValue = true;
  }

  public enum ReportFormat
  {
    XML = 1,
    PDF = 2,
    Both = 3,
  }

  public enum FieldLength
  {
    Gender = 1,
    OrderPurpose = 1,
    RFlag = 1,
    RequestType = 1,
    RequestVersion = 2,
    State = 2,
    BillCode = 3,
    FormatID = 3,
    JulianDate = 3,
    Product = 3,
    Suffix = 3,
    UserName = 3,
    Account = 6,
    RecSeqNo = 6,
    ClientCode = 8,
    DateOfBirth = 8,
    SSN = 9,
    FirstName = 15, // 0x0000000F
    MiddleName = 15, // 0x0000000F
    DLNumber = 19, // 0x00000013
    LastName = 20, // 0x00000014
    UserPassword = 20, // 0x00000014
    Extension = 30, // 0x0000001E
    QuoteBack = 40, // 0x00000028
  }
}

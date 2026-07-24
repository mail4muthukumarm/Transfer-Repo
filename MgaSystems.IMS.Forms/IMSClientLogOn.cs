// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.IMSClientLogOn
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Forms;

[StandardModule]
public sealed class IMSClientLogOn
{
  public const int DefaultServerPort = 9213;
  public const int DefaultConnectionTimeOut = 30000;
  private const int MAXMESSAGELENGTH = 8192 /*0x2000*/;
  private static string mLogonHost = string.Empty;
  private static int mPortNum = 9213;
  private static int mConnectTimeOut = 30000;
  private static string mDBConnection = string.Empty;
  private static string mDomainName;
  private static string mLogonServiceUrl;
  private static bool mUseLogonService;
  private static string mDataAccessUrl;

  public static string DatabaseConnection
  {
    get => IMSClientLogOn.mDBConnection;
    set => IMSClientLogOn.mDBConnection = value;
  }

  public static string LogOnDomainName
  {
    get => IMSClientLogOn.mDomainName;
    set => IMSClientLogOn.mDomainName = value;
  }

  public static int ServerPort
  {
    get => IMSClientLogOn.mPortNum;
    set
    {
      IMSClientLogOn.mPortNum = IMSClientLogOn.mPortNum >= 0 && IMSClientLogOn.mPortNum <= (int) ushort.MaxValue ? value : throw new ArgumentOutOfRangeException(nameof (PortNum), $"The port number is out of range.  The valid range is:  {Conversions.ToString(0)}-{Conversions.ToString((int) ushort.MaxValue)}");
    }
  }

  public static string LogOnServer
  {
    get => IMSClientLogOn.mLogonHost;
    set => IMSClientLogOn.mLogonHost = value;
  }

  public static string LogOnServiceUrl
  {
    get => IMSClientLogOn.mLogonServiceUrl;
    set => IMSClientLogOn.mLogonServiceUrl = value;
  }

  public static bool UseLogOnService
  {
    get => IMSClientLogOn.mUseLogonService;
    set => IMSClientLogOn.mUseLogonService = value;
  }

  public static int ConnectionTimeOut
  {
    get => IMSClientLogOn.mConnectTimeOut;
    set => IMSClientLogOn.mConnectTimeOut = value;
  }

  public static IMSClientLogOn.LogonReturn NewLogonUser(string userName, string password)
  {
    Guid guid = new Guid(ConfigurationManager.AppSettings["UpdatePackageKey"]);
    Encryption encryption = new Encryption();
    IMSClientLogOn.LogonReturn logonReturn;
    try
    {
      HttpClient httpClient = new HttpClient();
      string logOnServiceUrl = IMSClientLogOn.LogOnServiceUrl;
      string result = new LogonClient(httpClient)
      {
        BaseUrl = logOnServiceUrl
      }.TokenAsync(guid, userName, encryption.EncryptTripleDes(password)).Result;
      httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result);
      DefaultDatabase.AuthenticationToken = result;
      IMSClientLogOn.mDBConnection = new LogonClient(httpClient)
      {
        BaseUrl = logOnServiceUrl
      }.ConnectionstringAsync().Result;
      logonReturn = new IMSClientLogOn.LogonReturn();
      logonReturn.LogonStatus = IMSClientLogOn.LogonStatus.Ok;
      logonReturn.LogonMessage = IMSClientLogOn.mDBConnection;
    }
    catch (ApiException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ApiException apiException = ex;
      logonReturn = new IMSClientLogOn.LogonReturn();
      logonReturn.LogonStatus = IMSClientLogOn.LogonStatus.HostError;
      logonReturn.LogonMessage = ((Exception) apiException).Message;
      ProjectData.ClearProjectError();
    }
    return logonReturn;
  }

  public static IMSClientLogOn.LogonReturn LogonUser(
    string userName,
    string password,
    string logonXMLVersion)
  {
    IMSClientLogOn.LogonReturn logonReturn1 = new IMSClientLogOn.LogonReturn();
    TcpClient tcpClient = new TcpClient();
    MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
    Decoder decoder = Encoding.UTF8.GetDecoder();
    byte[] hash1 = cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(password));
    byte[] hash2 = cryptoServiceProvider.ComputeHash(hash1);
    string text = Operators.CompareString(logonXMLVersion, "1.0", false) != 0 ? IMSClientLogOn.EncryptValue(password) : Convert.ToBase64String(hash2);
    IMSClientLogOn.LogonReturn logonReturn2;
    try
    {
      tcpClient.Connect(IMSClientLogOn.mLogonHost, IMSClientLogOn.mPortNum);
      tcpClient.ReceiveTimeout = IMSClientLogOn.mConnectTimeOut;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      logonReturn1.LogonMessage = "Unable to connect to IMS Logon service due to the following error:\r\n\r\n" + exception.Message;
      logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.LocalError;
      logonReturn2 = logonReturn1;
      ProjectData.ClearProjectError();
      goto label_17;
    }
    NetworkStream stream;
    try
    {
      stream = tcpClient.GetStream();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      tcpClient.Close();
      logonReturn1.LogonMessage = "Unable to connect to IMS Logon service due to the following error:\r\n\r\n" + exception.Message;
      logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.LocalError;
      logonReturn2 = logonReturn1;
      ProjectData.ClearProjectError();
      goto label_17;
    }
    XmlTextWriter xmlTextWriter1 = new XmlTextWriter((Stream) stream, Encoding.UTF8);
    XmlTextWriter xmlTextWriter2 = xmlTextWriter1;
    xmlTextWriter2.Formatting = Formatting.Indented;
    xmlTextWriter2.WriteStartDocument();
    xmlTextWriter2.WriteStartElement("IMSAUTHENTICATION");
    xmlTextWriter2.WriteAttributeString("VERSION", logonXMLVersion);
    xmlTextWriter2.WriteStartElement("AUTHDOMAIN");
    xmlTextWriter2.WriteString(IMSClientLogOn.mDomainName);
    xmlTextWriter2.WriteEndElement();
    xmlTextWriter2.WriteStartElement("USERNAME");
    xmlTextWriter2.WriteString(userName);
    xmlTextWriter2.WriteEndElement();
    xmlTextWriter2.WriteStartElement("USERDATA");
    xmlTextWriter2.WriteString(text);
    xmlTextWriter2.WriteEndElement();
    xmlTextWriter2.WriteEndElement();
    try
    {
      xmlTextWriter2.Flush();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      stream.Close();
      tcpClient.Close();
      logonReturn1.LogonMessage = "Unable to communicate with the IMS Logon service due to the following error:\r\n\r\n" + exception.Message;
      logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.LocalError;
      logonReturn2 = logonReturn1;
      ProjectData.ClearProjectError();
      goto label_17;
    }
    string str = string.Empty;
    byte[] numArray = new byte[8192 /*0x2000*/];
    char[] chars = new char[8192 /*0x2000*/];
    try
    {
      int num;
      for (; !str.EndsWith("</IMSAUTHENTICATION>"); str = new string(chars, 0, num))
      {
        if (str.Length * 2 < 8192 /*0x2000*/)
        {
          int byteCount = stream.Read(numArray, 0, 8192 /*0x2000*/);
          num += decoder.GetChars(numArray, 0, byteCount, chars, num);
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      logonReturn1.LogonMessage = "Unable to connect to IMS Logon service due to the following error:\r\n\r\n" + exception.Message;
      stream.Close();
      tcpClient.Close();
      logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.LocalError;
      logonReturn2 = logonReturn1;
      ProjectData.ClearProjectError();
      goto label_17;
    }
    string InXML = str.Substring(1);
    string empty = string.Empty;
    IMSClientLogOn.LogonReturn logonReturn3 = IMSClientLogOn.UnpackResponse(InXML, ref empty);
    if (logonReturn3.LogonStatus == IMSClientLogOn.LogonStatus.Ok)
    {
      logonReturn3.LogonStatus = Operators.CompareString(logonXMLVersion, "1.0", false) != 0 ? IMSClientLogOn.DecryptUserData(empty, userName, IMSClientLogOn.EncryptValue(password)) : IMSClientLogOn.DecryptUserData(empty, userName, password);
      CurrentUser.Instance.WebServicesLogonUrl = ConfigurationManager.AppSettings.Get("WebServicesLogonUrl");
      CurrentUser.Instance.WebServicesInvoicingUrl = ConfigurationManager.AppSettings.Get("WebServicesInvoicingUrl");
      CurrentUser.Instance.WebServicesDocumentsUrl = ConfigurationManager.AppSettings.Get("WebServicesDocumentsUrl");
      MGASystems.BusinessObjects.Common.UserName = userName;
      MGASystems.BusinessObjects.Common.UserPassword = password;
    }
    xmlTextWriter1.Close();
    stream.Close();
    tcpClient.Close();
    cryptoServiceProvider.Clear();
    logonReturn2 = logonReturn3;
label_17:
    return logonReturn2;
  }

  private static IMSClientLogOn.LogonReturn UnpackResponse(string InXML, ref string outUserData)
  {
    XmlDocument xmlDocument = new XmlDocument();
    IMSClientLogOn.LogonReturn logonReturn1 = new IMSClientLogOn.LogonReturn();
    string innerText1;
    string innerText2;
    IMSClientLogOn.LogonReturn logonReturn2;
    try
    {
      xmlDocument.LoadXml(InXML);
      XmlElement documentElement = xmlDocument.DocumentElement;
      innerText1 = documentElement["STATUS"].InnerText;
      innerText2 = documentElement["USERDATA"].InnerText;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      logonReturn1.LogonMessage = "Login failed.  The server returned an unrecognized message.\r\n\r\nPlease check and verify your IP settings for the IMS Logon Server.";
      logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.InvalidProtocol;
      logonReturn2 = logonReturn1;
      ProjectData.ClearProjectError();
      goto label_22;
    }
    outUserData = innerText2;
    string upper = innerText1.ToUpper();
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(upper))
    {
      case 330202278:
        if (Operators.CompareString(upper, "INTERNALERROR", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.HostError;
          logonReturn1.LogonMessage = "Unable to complete the logon.  The logon server is either busy or offline.\r\n\r\nPlease try again.";
          break;
        }
        goto default;
      case 1308291032:
        if (Operators.CompareString(upper, "ACCESSDENIED", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.AccessDenied;
          logonReturn1.LogonMessage = "Logon access has been denied by the logon server.\r\n\r\nPlease notify your system administrator.";
          break;
        }
        goto default;
      case 1843204028:
        if (Operators.CompareString(upper, "INVALIDDOMAIN", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.InvalidDomain;
          logonReturn1.LogonMessage = "The log on server could not log you on because the domain name is invalid.";
          break;
        }
        goto default;
      case 1855456409:
        if (Operators.CompareString(upper, "INVALIDPASSWORD", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.InvalidPassword;
          logonReturn1.LogonMessage = "The system could not log you on.  Please check your password.";
          break;
        }
        goto default;
      case 1959149006:
        if (Operators.CompareString(upper, "LOCALERROR", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.LocalError;
          break;
        }
        goto default;
      case 2246359087:
        if (Operators.CompareString(upper, "OK", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.Ok;
          break;
        }
        goto default;
      case 3591137892:
        if (Operators.CompareString(upper, "INVALIDPROTOCOL", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.InvalidProtocol;
          logonReturn1.LogonMessage = "Logon failed.  The server returned an invalid protocol message.\r\n\r\nIf this message persists contact your system administrator.";
          break;
        }
        goto default;
      case 4221507192:
        if (Operators.CompareString(upper, "INVALIDUSERNAME", false) == 0)
        {
          logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.InvalidUserName;
          logonReturn1.LogonMessage = "The system could not log you on.  Please check your username.";
          break;
        }
        goto default;
      default:
        logonReturn1.LogonStatus = IMSClientLogOn.LogonStatus.HostError;
        logonReturn1.LogonMessage = $"Log on unsuccessful.  The server returned the following response - {innerText1}\r\n\r\nPlease notify your system administrator.";
        break;
    }
    logonReturn2 = logonReturn1;
label_22:
    return logonReturn2;
  }

  private static IMSClientLogOn.LogonStatus DecryptUserData(
    string userData,
    string userName,
    string password)
  {
    TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
    MD5CryptoServiceProvider cryptoServiceProvider2 = new MD5CryptoServiceProvider();
    byte[] hash1 = cryptoServiceProvider2.ComputeHash(Encoding.UTF8.GetBytes(password));
    byte[] hash2 = cryptoServiceProvider2.ComputeHash(Encoding.UTF8.GetBytes(userName));
    cryptoServiceProvider1.Mode = CipherMode.CBC;
    IMSClientLogOn.LogonStatus logonStatus;
    using (ICryptoTransform decryptor = cryptoServiceProvider1.CreateDecryptor(hash1, hash2))
    {
      try
      {
        byte[] inputBuffer = Convert.FromBase64String(userData);
        IMSClientLogOn.mDBConnection = new string(Encoding.UTF8.GetChars(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length)));
        logonStatus = IMSClientLogOn.LogonStatus.Ok;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        logonStatus = IMSClientLogOn.LogonStatus.LocalError;
        ProjectData.ClearProjectError();
      }
    }
    cryptoServiceProvider1.Clear();
    cryptoServiceProvider2.Clear();
    return logonStatus;
  }

  private static string EncryptValue(string val) => new Encryption().EncryptTripleDes(val);

  public struct LogonReturn
  {
    public IMSClientLogOn.LogonStatus LogonStatus;
    public string LogonMessage;
  }

  public enum LogonStatus
  {
    Ok,
    InvalidUserName,
    InvalidPassword,
    AccessDenied,
    HostError,
    InvalidProtocol,
    LocalError,
    InvalidDomain,
  }
}

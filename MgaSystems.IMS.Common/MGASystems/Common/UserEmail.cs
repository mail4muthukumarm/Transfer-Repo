// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UserEmail
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Email;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

#nullable disable
namespace MGASystems.Common;

public class UserEmail
{
  public const string Setting_UseSystemEmail = "UserEmail.UseSystemEmail";
  public const string Setting_SystemConfig = "UserEmail.SystemConfiguration";
  private readonly int _userID;
  private Guid _userGuid;
  private string _displayName;
  private string _emailAddress;
  private string _emailUsername;
  private string _emailPassword;
  private string _emailServer;
  private string _emailDomain;
  private bool _useExchangeWebServices;
  private string _azureTenantID;
  private string _azureClientID;
  private string _azureSecret;
  private bool _successfullyLoaded;
  private SendHandler _sendMethod;

  public int UserID => this._userID;

  public Guid UserGUID => this._userGuid;

  public string DisplayName => this._displayName;

  public string Address => this._emailAddress;

  public string Username => this._emailUsername;

  public string Password => this._emailPassword;

  public string Server => this._emailServer;

  public string Domain => this._emailDomain;

  public bool UseOutlookWS => this._useExchangeWebServices;

  public string AzureTenantID => this._azureTenantID;

  public string AzureClientID => this._azureClientID;

  internal string AzureSecret => this._azureSecret;

  public bool InitializedSuccessfully => this._successfullyLoaded;

  public bool ValidSettings
  {
    get
    {
      if (!this.InitializedSuccessfully)
        return false;
      if (!string.IsNullOrEmpty(this.Address) && !string.IsNullOrEmpty(this.Server) && !string.IsNullOrEmpty(this.Username) && !string.IsNullOrEmpty(this.Password))
        return true;
      return !string.IsNullOrEmpty(this.AzureTenantID) && !string.IsNullOrEmpty(this.AzureClientID);
    }
  }

  public UserEmail(int userID)
  {
    this._successfullyLoaded = false;
    this._userID = userID != -1 ? userID : throw new ArgumentException("Cannot instantiate UserEmail object with -1 UserID", nameof (userID));
    this.LoadUser(this._userID);
  }

  public UserEmail(Guid userGuid)
  {
    this._successfullyLoaded = false;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.spEmail_GetUser", new object[2]
    {
      (object) "@userGuid",
      (object) userGuid
    });
    this._userID = (int) dataRow.Field<short>(nameof (UserID));
    this._successfullyLoaded = this.LoadData(dataRow);
  }

  public UserEmail(CurrentUser user)
    : this(user.UserID)
  {
  }

  public UserEmail(
    string emailServer,
    string emailUsername,
    string emailPassword,
    string emailAddress,
    string emailDomain,
    bool useOutlookWebServices)
    : this(emailServer, emailUsername, emailPassword, emailAddress, emailDomain, useOutlookWebServices, (string) null, (string) null, (string) null)
  {
  }

  public UserEmail(
    string emailAddress,
    string azureTenant,
    string azureClient,
    string azureSecret)
    : this((string) null, (string) null, (string) null, emailAddress, (string) null, false, azureTenant, azureClient, azureSecret)
  {
  }

  public UserEmail(
    string emailServer,
    string emailUsername,
    string emailPassword,
    string emailAddress,
    string emailDomain,
    bool useOutlookWebServices,
    string azureTenant,
    string azureClient,
    string azureSecret)
  {
    this._successfullyLoaded = false;
    this._emailServer = emailServer;
    this._emailUsername = emailUsername;
    this._emailPassword = emailPassword;
    this._emailAddress = emailAddress;
    this._emailDomain = emailDomain;
    this._useExchangeWebServices = useOutlookWebServices;
    this._azureTenantID = azureTenant;
    this._azureClientID = azureClient;
    this._azureSecret = azureSecret;
    this._sendMethod = string.IsNullOrEmpty(this._azureClientID) || string.IsNullOrEmpty(azureTenant) ? (string.IsNullOrEmpty(this._emailDomain) ? SMTP.Instance : Exchange.Instance) : Graph.Instance;
    this._successfullyLoaded = true;
  }

  public UserEmail(DataRow dr)
  {
    this._successfullyLoaded = false;
    this._successfullyLoaded = this.LoadData(dr, true);
  }

  private bool LoadData(DataRow drow, bool throwError = false)
  {
    bool flag;
    try
    {
      this._userGuid = ExtensionsMethods.FieldOrDefault<Guid>(drow, "UserGUID", Guid.Empty);
      this._displayName = drow.Field<string>("DisplayName");
      this._emailAddress = drow.Field<string>("EmailAddress");
      this._emailUsername = drow.Field<string>("MailUserName");
      this._emailPassword = drow.Field<string>("MailPassword");
      this._emailServer = drow.Field<string>("MailServerAddress");
      this._emailDomain = drow.Field<string>("ExchangeServerDomain");
      this._azureTenantID = drow.Field<string>("AzureTenantID");
      this._azureClientID = drow.Field<string>("AzureClientID");
      this._azureSecret = ExtensionsMethods.FieldOrDefault<string>(drow, "AzureSecret", (string) null);
      this._useExchangeWebServices = drow.Field<bool>("UseOutlookWebServices");
      this._sendMethod = string.IsNullOrEmpty(this._azureTenantID) ? (string.IsNullOrEmpty(this._emailDomain) ? SMTP.Instance : Exchange.Instance) : Graph.Instance;
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (throwError)
        throw;
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  private bool LoadUser(int userID)
  {
    DataTable source = DefaultDatabase.ExecuteDataTable("dbo.spEmail_GetUser", new object[2]
    {
      (object) "@UserID",
      (object) userID
    });
    if (source.Rows.Count == 0 && userID == 0 && SystemSettings.KeyExists("UserEmail.UseSystemEmail") && SystemSettings.GetBoolSetting("UserEmail.UseSystemEmail") && SystemSettings.KeyExists("UserEmail.SystemConfiguration"))
    {
      using (StringReader input = new StringReader(new Encryption().DecryptTripleDes(SystemSettings.GetStringSetting("UserEmail.SystemConfiguration"))))
      {
        using (XmlReader reader = XmlReader.Create((TextReader) input))
        {
          int num = (int) source.ReadXml(reader);
        }
      }
    }
    this._successfullyLoaded = this.LoadData(source.AsEnumerable().FirstOrDefault<DataRow>());
    return this._successfullyLoaded;
  }

  public bool Refresh()
  {
    if (this._userID == -1)
      throw new InvalidOperationException("Manually configured UserEmail object cannot be refreshed.");
    return this.LoadUser(this.UserID);
  }

  public bool SendMail(
    string emailFrom,
    string emailTo,
    string emailSubject,
    string emailBody,
    IEnumerable<string> fileAttachments = null,
    OutlookSendType sendOutlook = OutlookSendType.None)
  {
    MessageObject message = new MessageObject();
    message.FromAddress = emailFrom;
    message.ToAddress = emailTo;
    message.Subject = emailSubject;
    message.TextBody = emailBody;
    message.SendOutlook = sendOutlook;
    if (fileAttachments == null)
      fileAttachments = Enumerable.Empty<string>();
    message.FileAttachments.UnionWith(fileAttachments);
    return this.SendMail(message);
  }

  public bool SendMail(MessageObject message)
  {
    bool flag = false;
    if (message.SendOutlook != OutlookSendType.None && CurrentUser.UsingOutlook)
      flag = Outlook.Send(message);
    return flag || this._sendMethod.Send(this, message);
  }

  public async Task<bool> SendMailAsync(MessageObject message)
  {
    bool flag1 = false;
    if (message.SendOutlook != OutlookSendType.None && CurrentUser.UsingOutlook)
      flag1 = Outlook.Send(message);
    bool flag2;
    if (flag1)
      flag2 = true;
    else
      flag2 = await this._sendMethod.SendAsync(this, message);
    return flag2;
  }
}

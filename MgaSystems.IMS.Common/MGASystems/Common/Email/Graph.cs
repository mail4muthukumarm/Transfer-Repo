// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.Graph
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Email.GraphModel;
using MGASystems.Common.ErrorHandling;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Email;

[StandardModule]
public sealed class Graph
{
  public static readonly SendHandler Instance = new SendHandler(new Func<UserEmail, MessageObject, bool>(Graph.Send), new Func<UserEmail, MessageObject, Task<bool>>(Graph.SendAsync));
  private static readonly ConcurrentDictionary<(string ClientID, string TenantID, string ClientSecret), IClientApplicationBase> _cachedClients = new ConcurrentDictionary<(string, string, string), IClientApplicationBase>();

  private static IPublicClientApplication RetrievePublicClient(UserEmail user)
  {
    IClientApplicationBase iclientApplicationBase = (IClientApplicationBase) null;
    if (!string.IsNullOrEmpty(user.AzureClientID) && !string.IsNullOrEmpty(user.AzureTenantID))
    {
      ConcurrentDictionary<(string, string, string), IClientApplicationBase> cachedClients = Graph._cachedClients;
      (string, string, string) key = (user.AzureClientID, user.AzureTenantID, (string) null);
      Func<(string, string, string), IClientApplicationBase> valueFactory;
      // ISSUE: reference to a compiler-generated field
      if (Graph._Closure\u0024__.\u0024I3\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        valueFactory = Graph._Closure\u0024__.\u0024I3\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Graph._Closure\u0024__.\u0024I3\u002D0 = valueFactory = (Func<(string, string, string), IClientApplicationBase>) ([SpecialName] (svals) => (IClientApplicationBase) ((AbstractApplicationBuilder<PublicClientApplicationBuilder>) PublicClientApplicationBuilder.Create(svals.ClientID)).WithAuthority((AzureCloudInstance) 1, svals.TenantID, true).WithDefaultRedirectUri().Build());
      }
      iclientApplicationBase = cachedClients.GetOrAdd(key, valueFactory);
    }
    return iclientApplicationBase as IPublicClientApplication;
  }

  private static IConfidentialClientApplication RetrieveConfidentialClient(UserEmail user)
  {
    IClientApplicationBase iclientApplicationBase = (IClientApplicationBase) null;
    if (!string.IsNullOrEmpty(user.AzureClientID) && !string.IsNullOrEmpty(user.AzureTenantID) && !string.IsNullOrEmpty(user.AzureSecret))
    {
      ConcurrentDictionary<(string, string, string), IClientApplicationBase> cachedClients = Graph._cachedClients;
      (string, string, string) key = (user.AzureClientID, user.AzureTenantID, user.AzureSecret);
      Func<(string, string, string), IClientApplicationBase> valueFactory;
      // ISSUE: reference to a compiler-generated field
      if (Graph._Closure\u0024__.\u0024I4\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        valueFactory = Graph._Closure\u0024__.\u0024I4\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Graph._Closure\u0024__.\u0024I4\u002D0 = valueFactory = (Func<(string, string, string), IClientApplicationBase>) ([SpecialName] (svals) => (IClientApplicationBase) ((AbstractApplicationBuilder<ConfidentialClientApplicationBuilder>) ConfidentialClientApplicationBuilder.Create(svals.ClientID)).WithAuthority((AzureCloudInstance) 1, svals.TenantID, true).WithClientSecret(svals.ClientSecret).Build());
      }
      iclientApplicationBase = cachedClients.GetOrAdd(key, valueFactory);
    }
    return iclientApplicationBase as IConfidentialClientApplication;
  }

  public static bool Send(UserEmail user, MessageObject message)
  {
    Task<bool> task1 = Graph.SendAsync(user, message);
    Task task2 = Task.Delay(TimeSpan.FromMinutes(2.0));
    bool flag;
    while (!task1.IsCompleted)
    {
      if (task2.IsCompleted)
      {
        flag = false;
        goto label_7;
      }
      task1.Wait(TimeSpan.FromSeconds(1.0));
      if (Application.MessageLoop)
        Application.DoEvents();
    }
    flag = task1.Result;
label_7:
    return flag;
  }

  public static async Task<bool> SendAsync(UserEmail user, MessageObject message)
  {
    Logging.WriteLogWithObjects(nameof (Graph), "Send", "Parameters", user, message, true);
    Logging.WriteLog(nameof (Graph), "Send", "Invoking", true);
    if (string.IsNullOrEmpty(user.AzureClientID))
    {
      if (Settings.SuppressExceptions)
        return false;
      throw new InvalidOperationException("No Azure Client Settings Available for user " + (user.DisplayName ?? user.Address));
    }
    if (string.IsNullOrEmpty(user.AzureTenantID))
    {
      if (Settings.SuppressExceptions)
        return false;
      throw new InvalidOperationException("No Azure Tenant Settings Available for user " + (user.DisplayName ?? user.Address));
    }
    Logging.WriteLog(nameof (Graph), "Send.Authenticate", "Authenticating");
    AuthenticationResult authenticationResult = (AuthenticationResult) null;
    bool flag;
    if (string.IsNullOrEmpty(user.AzureSecret))
    {
      Logging.WriteLog(nameof (Graph), "Send.Authenticate", $"Obtaining OAuth Token via {"IPublicClientApplication"}", true);
      IPublicClientApplication clientApplication = Graph.RetrievePublicClient(user);
      try
      {
        IEnumerable<IAccount> iaccounts = await ((IClientApplicationBase) clientApplication).GetAccountsAsync(user.Address).ConfigureAwait(false);
        authenticationResult = await ((AbstractAcquireTokenParameterBuilder<AcquireTokenSilentParameterBuilder>) ((IClientApplicationBase) clientApplication).AcquireTokenSilent((IEnumerable<string>) new string[1]
        {
          "Mail.Send"
        }, user.Address)).ExecuteAsync().ConfigureAwait(false);
      }
      catch (MsalUiRequiredException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        Logging.WriteLog(nameof (Graph), "Send.Authenticate", "Requires UI, checking for additional consent.", true);
        ProjectData.ClearProjectError();
      }
      if (authenticationResult == null)
      {
        try
        {
          Logging.WriteLog(nameof (Graph), "Send.Authenticate", "Incremental consent.", true);
          authenticationResult = await ((AbstractAcquireTokenParameterBuilder<AcquireTokenInteractiveParameterBuilder>) clientApplication.AcquireTokenInteractive((IEnumerable<string>) new string[1]
          {
            "Mail.Send"
          }).WithParentActivityOrWindow((IWin32Window) MDIControls.Instance.MDIParent)).ExecuteAsync().ConfigureAwait(false);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception innerException = ex;
          if (!Settings.SuppressExceptions)
            throw new InvalidOperationException("Failed to authenticate Graph API", innerException);
          flag = false;
          ProjectData.ClearProjectError();
          return flag;
        }
      }
    }
    else
    {
      Logging.WriteLog(nameof (Graph), "Send.Authenticate", $"Obtaining OAuth Token via {"IConfidentialClientApplication"}", true);
      IConfidentialClientApplication clientApplication = Graph.RetrieveConfidentialClient(user);
      try
      {
        authenticationResult = await ((AbstractAcquireTokenParameterBuilder<AcquireTokenForClientParameterBuilder>) clientApplication.AcquireTokenForClient((IEnumerable<string>) new string[1]
        {
          "https://graph.microsoft.com/.default"
        })).ExecuteAsync().ConfigureAwait(false);
      }
      catch (MsalClientException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MsalClientException innerException = ex;
        Logging.WriteLog(nameof (Graph), "Send.Authenticate", "Authentication failed, no UI.", true);
        if (!Settings.SuppressExceptions)
          throw new InvalidOperationException("Unable to acquire token for Graph email using ClientSecret/BlackBox.", (Exception) innerException);
        flag = false;
        ProjectData.ClearProjectError();
        return flag;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception innerException = ex;
        if (!Settings.SuppressExceptions)
          throw new InvalidOperationException("[ConfidentialClient] Failed to authenticate Graph API", innerException);
        flag = false;
        ProjectData.ClearProjectError();
        return flag;
      }
    }
    if (authenticationResult == null)
      return false;
    Logging.WriteLog(nameof (Graph), "Send.Authenticate", "Authenticated");
    MGASystems.Common.Email.GraphModel.Message message1 = new MGASystems.Common.Email.GraphModel.Message();
    try
    {
      Logging.WriteLog(nameof (Graph), "Send.Setup", "BeginSetup", true);
      MGASystems.Common.Email.GraphModel.Message message2 = message1;
      message2.From = new Recipient()
      {
        EmailAddress = new EmailAddress()
        {
          Address = string.IsNullOrEmpty(message.FromAddress) ? user.Address : message.FromAddress
        }
      };
      MGASystems.Common.Email.GraphModel.Message message3 = message2;
      IEnumerable<string> source1 = message.Recipients.DefaultIfEmpty<string>(user.Address);
      Func<string, Recipient> selector1;
      // ISSUE: reference to a compiler-generated field
      if (Graph._Closure\u0024__.\u0024I6\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector1 = Graph._Closure\u0024__.\u0024I6\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Graph._Closure\u0024__.\u0024I6\u002D0 = selector1 = (Func<string, Recipient>) ([SpecialName] (addr) => new Recipient()
        {
          EmailAddress = new EmailAddress()
          {
            Address = addr
          }
        });
      }
      List<Recipient> list1 = source1.Select<string, Recipient>(selector1).ToList<Recipient>();
      message3.ToRecipients = (IEnumerable<Recipient>) list1;
      MGASystems.Common.Email.GraphModel.Message message4 = message2;
      HashSet<string> ccRecipients = message.CCRecipients;
      Func<string, Recipient> selector2;
      // ISSUE: reference to a compiler-generated field
      if (Graph._Closure\u0024__.\u0024I6\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector2 = Graph._Closure\u0024__.\u0024I6\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Graph._Closure\u0024__.\u0024I6\u002D1 = selector2 = (Func<string, Recipient>) ([SpecialName] (addr) => new Recipient()
        {
          EmailAddress = new EmailAddress()
          {
            Address = addr
          }
        });
      }
      List<Recipient> list2 = ccRecipients.Select<string, Recipient>(selector2).ToList<Recipient>();
      message4.CcRecipients = (IEnumerable<Recipient>) list2;
      MGASystems.Common.Email.GraphModel.Message message5 = message2;
      HashSet<string> bccRecipients = message.BCCRecipients;
      Func<string, Recipient> selector3;
      // ISSUE: reference to a compiler-generated field
      if (Graph._Closure\u0024__.\u0024I6\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector3 = Graph._Closure\u0024__.\u0024I6\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Graph._Closure\u0024__.\u0024I6\u002D2 = selector3 = (Func<string, Recipient>) ([SpecialName] (addr) => new Recipient()
        {
          EmailAddress = new EmailAddress()
          {
            Address = addr
          }
        });
      }
      List<Recipient> list3 = bccRecipients.Select<string, Recipient>(selector3).ToList<Recipient>();
      message5.BccRecipients = (IEnumerable<Recipient>) list3;
      message2.Attachments = (IMessageAttachmentsCollectionPage) new MessageAttachmentsCollectionPage();
      message2.Subject = message.Subject;
      message2.Body = new ItemBody()
      {
        Content = message.TextBody,
        ContentType = new BodyType?(BodyType.Text)
      };
      if (!string.IsNullOrEmpty(message.HTMLBody) || !string.IsNullOrEmpty(message.ImageBody))
      {
        string str1 = message.HTMLBody;
        if (string.IsNullOrEmpty(str1))
          str1 = "<img src=\"cid:ImageEmailBody\">";
        if (!string.IsNullOrEmpty(message.ImageBody))
        {
          IMessageAttachmentsCollectionPage attachments = message2.Attachments;
          FileAttachment fileAttachment = new FileAttachment();
          fileAttachment.ODataType = "#microsoft.graph.fileAttachment";
          fileAttachment.ContentId = "ImageEmailBody";
          fileAttachment.ContentType = MessageObject.FindMimeType(message.ImageBody, "image/jpeg");
          fileAttachment.Name = "ImageBody";
          fileAttachment.ContentBytes = File.ReadAllBytes(message.ImageBody);
          fileAttachment.IsInline = new bool?(true);
          attachments.Add((Attachment) fileAttachment);
        }
        if (message.InlineImages && str1.ContainsNoCase("<img "))
        {
          string text = str1;
          try
          {
            XDocument xdocument = XDocument.Parse(text);
            int num = 0;
            try
            {
              IEnumerable<XElement> source2 = xdocument.Descendants();
              Func<XElement, bool> predicate1;
              // ISSUE: reference to a compiler-generated field
              if (Graph._Closure\u0024__.\u0024I6\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate1 = Graph._Closure\u0024__.\u0024I6\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                Graph._Closure\u0024__.\u0024I6\u002D3 = predicate1 = (Func<XElement, bool>) ([SpecialName] (elem) => elem.Name.LocalName.EqualsNoCase("img"));
              }
              foreach (XElement xelement in source2.Where<XElement>(predicate1))
              {
                IEnumerable<XAttribute> source3 = xelement.Attributes();
                Func<XAttribute, bool> predicate2;
                // ISSUE: reference to a compiler-generated field
                if (Graph._Closure\u0024__.\u0024I6\u002D4 != null)
                {
                  // ISSUE: reference to a compiler-generated field
                  predicate2 = Graph._Closure\u0024__.\u0024I6\u002D4;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  Graph._Closure\u0024__.\u0024I6\u002D4 = predicate2 = (Func<XAttribute, bool>) ([SpecialName] (attr) => attr.Name.LocalName.EqualsNoCase("src"));
                }
                XAttribute xattribute = source3.FirstOrDefault<XAttribute>(predicate2);
                if (xattribute != null && !xattribute.Value.StartsWith("http", StringComparison.OrdinalIgnoreCase) && !xattribute.Value.StartsWith("cid", StringComparison.OrdinalIgnoreCase))
                {
                  string str2 = $"embed{num:00}";
                  IMessageAttachmentsCollectionPage attachments = message2.Attachments;
                  FileAttachment fileAttachment = new FileAttachment();
                  fileAttachment.ODataType = "#microsoft.graph.fileAttachment";
                  fileAttachment.ContentId = str2;
                  fileAttachment.ContentType = MessageObject.FindMimeType(xattribute.Value);
                  fileAttachment.Name = "ImageBody";
                  fileAttachment.ContentBytes = File.ReadAllBytes(xattribute.Value);
                  fileAttachment.IsInline = new bool?(true);
                  attachments.Add((Attachment) fileAttachment);
                  text = text.Replace(xattribute.Value, $"cid:{str2}");
                  ++num;
                }
              }
            }
            finally
            {
              IEnumerator<XElement> enumerator;
              enumerator?.Dispose();
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ErrorHandler.SilentLogError(ex);
            ProjectData.ClearProjectError();
          }
          str1 = text;
        }
        message2.Body.Content = str1;
        message2.Body.ContentType = new BodyType?(BodyType.Html);
      }
      try
      {
        foreach (string fileAttachment1 in message.FileAttachments)
        {
          IMessageAttachmentsCollectionPage attachments = message2.Attachments;
          FileAttachment fileAttachment2 = new FileAttachment();
          fileAttachment2.ODataType = "#microsoft.graph.fileAttachment";
          fileAttachment2.ContentId = Path.GetFileNameWithoutExtension(fileAttachment1);
          fileAttachment2.Name = Path.GetFileName(fileAttachment1);
          fileAttachment2.ContentBytes = File.ReadAllBytes(fileAttachment1);
          attachments.Add((Attachment) fileAttachment2);
        }
      }
      finally
      {
        HashSet<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Logging.WriteLog(nameof (Graph), "Send.Setup Failed (Exception)", ex.Message);
      if (Settings.SuppressExceptions)
      {
        flag = false;
        ProjectData.ClearProjectError();
        return flag;
      }
      throw;
    }
    Logging.WriteLog(nameof (Graph), "Send.Setup", "EndSetup", true);
    try
    {
      string str = JsonConvert.SerializeObject((object) new MessageRequestBody()
      {
        Message = message1
      });
      Logging.WriteLog(nameof (Graph), "Send.Message", str, true);
      using (HttpClient httpClient = new HttpClient())
      {
        Logging.WriteLog(nameof (Graph), "Send", "Sending through Graph");
        httpClient.DefaultRequestHeaders.Add("Authorization", authenticationResult.CreateAuthorizationHeader());
        using (StringContent content = new StringContent(str, Encoding.UTF8, "application/json"))
        {
          HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("https://graph.microsoft.com/v1.0/" + (authenticationResult.Account != null ? "me" : $"users/{user.Address}") + "/sendMail", (HttpContent) content).ConfigureAwait(false);
          if (!httpResponseMessage.IsSuccessStatusCode)
            throw new Exception(await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
        }
      }
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      Logging.WriteLog(nameof (Graph), "Send Failed (Exception)", ex2.Message);
      ErrorHandler.SilentLogError(ex2);
      if (Settings.SuppressExceptions)
      {
        flag = false;
        ProjectData.ClearProjectError();
        return flag;
      }
      throw;
    }
    return true;
  }
}

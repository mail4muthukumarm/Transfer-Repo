// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.Exchange
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.AsposeFacade.Email.Exchange;
using MGASystems.AsposeFacade.Email.Mail;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data.DataEncryption;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Email;

[StandardModule]
public sealed class Exchange
{
  public static readonly SendHandler Instance = new SendHandler(new Func<UserEmail, MessageObject, bool>(MGASystems.Common.Email.Exchange.Send), (Func<UserEmail, MessageObject, Task<bool>>) null);

  public static bool Send(UserEmail user, MessageObject message)
  {
    Logging.WriteLogWithObjects(nameof (Exchange), nameof (Send), "Parameters", user, message, true);
    Logging.WriteLog(nameof (Exchange), nameof (Send), "Invoking", true);
    bool flag;
    if (string.IsNullOrEmpty(user.Server))
    {
      if (!Settings.SuppressExceptions)
        throw new InvalidOperationException("No Exchange Mail Server Settings Available for user " + (user.DisplayName ?? user.Address));
      flag = false;
    }
    else if (string.IsNullOrEmpty(user.Username))
    {
      if (!Settings.SuppressExceptions)
        throw new InvalidOperationException("No Exchange Mail Server UserName Settings Available for user " + (user.DisplayName ?? user.Address));
      flag = false;
    }
    else if (string.IsNullOrEmpty(user.Password))
    {
      if (!Settings.SuppressExceptions)
        throw new InvalidOperationException("No Exchange Mail Server Password Settings Available for user " + (user.DisplayName ?? user.Address));
      flag = false;
    }
    else
    {
      string str1 = ((TripleDesEncrypter) new CoffeeTripleDesEncrypter()).Decrypt(user.Password);
      using (MailMessage mailMessage1 = new MailMessage())
      {
        try
        {
          Logging.WriteLog(nameof (Exchange), nameof (Send), "BeginSetup", true);
          MailMessage mailMessage2 = mailMessage1;
          mailMessage2.From = MailAddress.op_Implicit(string.IsNullOrEmpty(message.FromAddress) ? user.Address : message.FromAddress);
          try
          {
            foreach (string str2 in message.Recipients.DefaultIfEmpty<string>(user.Address))
              mailMessage2.To.Add(MailAddress.op_Implicit(str2));
          }
          finally
          {
            IEnumerator<string> enumerator;
            enumerator?.Dispose();
          }
          try
          {
            foreach (string ccRecipient in message.CCRecipients)
              mailMessage2.CC.Add(new MailAddress(ccRecipient));
          }
          finally
          {
            HashSet<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            foreach (string bccRecipient in message.BCCRecipients)
              mailMessage2.Bcc.Add(new MailAddress(bccRecipient));
          }
          finally
          {
            HashSet<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          mailMessage2.Subject = message.Subject;
          if (!string.IsNullOrEmpty(message.TextBody))
            mailMessage2.Body = message.TextBody;
          if (!string.IsNullOrEmpty(message.HTMLBody) || !string.IsNullOrEmpty(message.ImageBody))
          {
            string str3 = string.IsNullOrEmpty(message.HTMLBody) ? "<img src=\"cid:ImageEmailBody\">" : message.HTMLBody;
            if (!string.IsNullOrEmpty(message.ImageBody))
            {
              LinkedResource linkedResource = new LinkedResource(message.ImageBody)
              {
                ContentId = "ImageEmailBody"
              };
              if (str3.ContainsNoCase("cid:ImageEmailBody"))
              {
                mailMessage2.LinkedResources.Add(linkedResource);
              }
              else
              {
                AlternateView alternateViewFromString = AlternateView.CreateAlternateViewFromString("<img src=\"cid:ImageEmailBody\">");
                alternateViewFromString.LinkedResources.Add(linkedResource);
                mailMessage2.AlternateViews.Add(alternateViewFromString);
              }
            }
            if (message.InlineImages && str3.ContainsNoCase("<img "))
            {
              string text = str3;
              try
              {
                XDocument xdocument = XDocument.Parse(text);
                int num = 0;
                try
                {
                  IEnumerable<XElement> source1 = xdocument.Descendants();
                  Func<XElement, bool> predicate1;
                  // ISSUE: reference to a compiler-generated field
                  if (MGASystems.Common.Email.Exchange._Closure\u0024__.\u0024I2\u002D0 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    predicate1 = MGASystems.Common.Email.Exchange._Closure\u0024__.\u0024I2\u002D0;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    MGASystems.Common.Email.Exchange._Closure\u0024__.\u0024I2\u002D0 = predicate1 = (Func<XElement, bool>) ([SpecialName] (elem) => elem.Name.LocalName.EqualsNoCase("img"));
                  }
                  foreach (XElement xelement in source1.Where<XElement>(predicate1))
                  {
                    IEnumerable<XAttribute> source2 = xelement.Attributes();
                    Func<XAttribute, bool> predicate2;
                    // ISSUE: reference to a compiler-generated field
                    if (MGASystems.Common.Email.Exchange._Closure\u0024__.\u0024I2\u002D1 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      predicate2 = MGASystems.Common.Email.Exchange._Closure\u0024__.\u0024I2\u002D1;
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      MGASystems.Common.Email.Exchange._Closure\u0024__.\u0024I2\u002D1 = predicate2 = (Func<XAttribute, bool>) ([SpecialName] (attr) => attr.Name.LocalName.EqualsNoCase("src"));
                    }
                    XAttribute xattribute = source2.FirstOrDefault<XAttribute>(predicate2);
                    if (xattribute != null && !xattribute.Value.StartsWith("http", StringComparison.OrdinalIgnoreCase) && !xattribute.Value.StartsWith("cid", StringComparison.OrdinalIgnoreCase))
                    {
                      string str4 = $"embed{num:00}";
                      mailMessage2.LinkedResources.Add(new LinkedResource(xattribute.Value)
                      {
                        ContentId = str4
                      });
                      text = text.Replace(xattribute.Value, $"cid:{str4}");
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
              str3 = text;
            }
            mailMessage2.HtmlBody = str3;
          }
          try
          {
            foreach (string fileAttachment in message.FileAttachments)
            {
              Attachment attachment = new Attachment(fileAttachment);
              mailMessage2.Attachments.Add(attachment);
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
          Logging.WriteLog(nameof (Exchange), "Send.Setup Failed (Exception)", ex.Message);
          if (Settings.SuppressExceptions)
          {
            flag = false;
            ProjectData.ClearProjectError();
            goto label_84;
          }
          throw;
        }
        Logging.WriteLog(nameof (Exchange), nameof (Send), "EndSetup", true);
        if (user.UseOutlookWS)
        {
          Logging.WriteLog(nameof (Exchange), nameof (Send), "user.UseOutlookWS = true");
          ExchangeWebServiceClient webServiceClient = (ExchangeWebServiceClient) null;
          try
          {
            webServiceClient = !string.IsNullOrEmpty(user.Domain) ? new ExchangeWebServiceClient(user.Server, user.Username, str1, user.Domain) : new ExchangeWebServiceClient(user.Server, user.Username, str1);
            webServiceClient.Send(mailMessage1);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Logging.WriteLog(nameof (Exchange), "Send Failed (Exception)", ex.Message);
            if (Settings.SuppressExceptions)
            {
              flag = false;
              ProjectData.ClearProjectError();
              goto label_84;
            }
            throw;
          }
          finally
          {
            webServiceClient?.Dispose();
          }
        }
        else
        {
          Logging.WriteLog(nameof (Exchange), nameof (Send), "user.UseOutlookWS = false");
          ExchangeClient exchangeClient = (ExchangeClient) null;
          try
          {
            exchangeClient = !string.IsNullOrEmpty(user.Domain) ? new ExchangeClient(user.Server, user.Username, str1, user.Domain) : new ExchangeClient(user.Server, user.Username, str1);
            exchangeClient.Send(mailMessage1);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Logging.WriteLog(nameof (Exchange), "Send Failed (Exception)", ex.Message);
            if (Settings.SuppressExceptions)
            {
              flag = false;
              ProjectData.ClearProjectError();
              goto label_84;
            }
            throw;
          }
          finally
          {
            exchangeClient?.Dispose();
          }
        }
      }
      Logging.WriteLog(nameof (Exchange), nameof (Send), "Invoked", true);
      flag = true;
    }
label_84:
    return flag;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UsingExchange
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.AsposeFacade.Email.Exchange;
using MGASystems.AsposeFacade.Email.Mail;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
[Obsolete("Use CurrentUser.Instance.Email or MGASystems.Common.UserEmail instead.")]
public sealed class UsingExchange
{
  private static bool _isImageBody;
  private static LinkedResourceCollection _linkedResourceCollection;

  public static bool IsImageBody
  {
    get => UsingExchange._isImageBody;
    set => UsingExchange._isImageBody = value;
  }

  private static LinkedResourceCollection LinkedResourceCollection
  {
    get => UsingExchange._linkedResourceCollection;
    set => UsingExchange._linkedResourceCollection = value;
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body)
  {
    return UsingExchange.SendMailUsingExchange(emailTo, emailFrom, subject, body, (string) null);
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string domain)
  {
    return UsingExchange.SendMailUsingExchange(emailTo, emailFrom, subject, body, domain, (List<string>) null);
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string domain,
    List<string> attachments)
  {
    return UsingExchange.SendMailUsingExchange(emailTo, emailFrom, subject, body, domain, attachments, (List<string>) null);
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string domain,
    List<string> attachments,
    List<string> ccList)
  {
    return UsingExchange.SendMailUsingExchange(emailTo, emailFrom, subject, body, domain, attachments, ccList, (List<string>) null);
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string domain,
    List<string> attachments,
    List<string> ccList,
    List<string> bccList)
  {
    return UsingExchange.SendMailUsingExchange(emailTo, emailFrom, subject, body, domain, attachments, ccList, bccList, string.Empty, string.Empty, string.Empty);
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string domain,
    List<string> attachments,
    List<string> ccList,
    List<string> bccList,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword)
  {
    return UsingExchange.SendMailUsingExchange(emailTo, emailFrom, subject, body, domain, attachments, ccList, bccList, mailServer, mailServerUsername, mailServerPassword, false);
  }

  public static bool SendMailUsingExchange(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string domain,
    List<string> attachments,
    List<string> ccList,
    List<string> bccList,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword,
    bool IsImageBody)
  {
    UsingExchange.WriteLogWithArgs("SendMail", "Invoking", (object) nameof (emailTo), (object) emailTo, (object) nameof (emailFrom), (object) emailFrom, (object) nameof (subject), (object) subject, (object) nameof (body), (object) body, (object) nameof (domain), (object) domain, (object) nameof (attachments), (object) attachments, (object) nameof (ccList), (object) ccList, (object) nameof (bccList), (object) bccList, (object) nameof (mailServer), (object) mailServer, (object) nameof (mailServerUsername), (object) mailServerUsername, (object) nameof (mailServerPassword), (object) mailServerPassword, (object) nameof (IsImageBody), (object) IsImageBody);
    string displayNameLastFirst = CurrentUser.Instance.DisplayNameLastFirst;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT MailServerAddress, MailUserName, MailPassword, EmailAddress, ExchangeServerDomain, UseOutlookWebServices FROM tblUsers WHERE UserID = @UserID", new object[2]
    {
      (object) "@UserID",
      (object) CurrentUser.Instance.UserID
    });
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    string empty5 = string.Empty;
    if (dataRow["MailServerAddress"] != null && dataRow["MailServerAddress"] != DBNull.Value)
      empty1 = dataRow["MailServerAddress"].ToString();
    if (dataRow["MailUserName"] != null && dataRow["MailUserName"] != DBNull.Value)
      empty2 = dataRow["MailUserName"].ToString();
    if (dataRow["MailPassword"] != null && dataRow["MailPassword"] != DBNull.Value)
      empty3 = dataRow["MailPassword"].ToString();
    if (dataRow["EmailAddress"] != null && dataRow["EmailAddress"] != DBNull.Value)
      empty4 = dataRow["EmailAddress"].ToString();
    if (dataRow["ExchangeServerDomain"] != null && dataRow["ExchangeServerDomain"] != DBNull.Value)
      empty5 = dataRow["ExchangeServerDomain"].ToString();
    bool flag = (bool) dataRow["UseOutlookWebServices"];
    if (string.IsNullOrEmpty(mailServer))
      mailServer = empty1;
    if (string.IsNullOrEmpty(mailServerUsername))
      mailServerUsername = empty2;
    if (string.IsNullOrEmpty(mailServerPassword))
      mailServerPassword = empty3;
    if (string.IsNullOrEmpty(domain))
      domain = empty5;
    if (string.IsNullOrEmpty(mailServer))
      throw new InvalidOperationException("No Exchange Mail Server Settings Available for user " + displayNameLastFirst);
    if (string.IsNullOrEmpty(mailServerUsername))
      throw new InvalidOperationException("No Exchange Mail Server UserName Settings Available for user " + displayNameLastFirst);
    mailServerPassword = !string.IsNullOrEmpty(mailServerPassword) ? new Encryption().DecryptTripleDes(mailServerPassword) : throw new InvalidOperationException("No Exchange Mail Server Password Settings Available for user " + displayNameLastFirst);
    if (string.IsNullOrEmpty(emailFrom))
      emailFrom = empty4;
    using (MailMessage mailMessage1 = new MailMessage())
    {
      MailMessage mailMessage2 = mailMessage1;
      mailMessage2.From = MailAddress.op_Implicit(emailFrom);
      mailMessage2.To = MailAddressCollection.op_Implicit(emailTo);
      mailMessage2.Subject = subject;
      mailMessage2.Body = !IsImageBody ? body : string.Empty;
      if (attachments != null)
      {
        try
        {
          foreach (string attachment1 in attachments)
          {
            Attachment attachment2 = new Attachment(attachment1);
            mailMessage2.Attachments.Add(attachment2);
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      if (ccList != null)
      {
        try
        {
          foreach (string cc in ccList)
            mailMessage2.CC.Add(new MailAddress(cc));
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      if (bccList != null)
      {
        try
        {
          foreach (string bcc in bccList)
            mailMessage2.Bcc.Add(new MailAddress(bcc));
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      if (IsImageBody)
      {
        LinkedResource linkedResource = new LinkedResource(body);
        linkedResource.ContentId = "ImageEmailBody";
        mailMessage1.HtmlBody = "<img src=cid:ImageEmailBody>";
        AlternateView alternateViewFromString = AlternateView.CreateAlternateViewFromString("<img src=cid:ImageEmailBody>");
        alternateViewFromString.LinkedResources.Add(linkedResource);
        mailMessage1.LinkedResources.Add(linkedResource);
        mailMessage1.AlternateViews.Add(alternateViewFromString);
      }
      if (flag)
      {
        UsingExchange.WriteLog(nameof (SendMailUsingExchange), "useOutlookWebServices = true");
        ExchangeWebServiceClient webServiceClient = (ExchangeWebServiceClient) null;
        try
        {
          webServiceClient = string.IsNullOrEmpty(domain) ? new ExchangeWebServiceClient(mailServer, mailServerUsername, mailServerPassword) : new ExchangeWebServiceClient(mailServer, mailServerUsername, mailServerPassword, domain);
          webServiceClient.Send(mailMessage1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          UsingExchange.WriteLog("SendMailUsingExchange Failed (Exception)", ex.Message);
          throw;
        }
        finally
        {
          webServiceClient?.Dispose();
        }
      }
      else
      {
        UsingExchange.WriteLog(nameof (SendMailUsingExchange), "useOutlookWebServices = false");
        ExchangeClient exchangeClient = (ExchangeClient) null;
        try
        {
          exchangeClient = string.IsNullOrEmpty(domain) ? new ExchangeClient(mailServer, mailServerUsername, mailServerPassword) : new ExchangeClient(mailServer, mailServerUsername, mailServerPassword, domain);
          exchangeClient.Send(mailMessage1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          UsingExchange.WriteLog("SendMailUsingExchange Failed (Exception)", ex.Message);
          throw;
        }
        finally
        {
          exchangeClient?.Dispose();
        }
      }
    }
    UsingExchange.WriteLog(nameof (SendMailUsingExchange), "Invoked");
    return true;
  }

  private static string WriteLogWithArgs(string method, string message, params object[] args)
  {
    return args != null ? ActionLog.Write("SendEmail", method, $"{message} {ActionLog.ToArgString(args)}") : ActionLog.Write("SendEmail", method, message);
  }

  private static string WriteLog(string method, string message, bool optional = false)
  {
    return ActionLog.Write("SendEmail", method, message, optional);
  }
}

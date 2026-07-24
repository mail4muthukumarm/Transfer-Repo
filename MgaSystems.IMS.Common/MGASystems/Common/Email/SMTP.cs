// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.SMTP
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Data.DataEncryption;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Email;

[StandardModule]
public sealed class SMTP
{
  public static readonly SendHandler Instance = new SendHandler(new Func<UserEmail, MessageObject, bool>(SMTP.Send), (Func<UserEmail, MessageObject, Task<bool>>) null);

  public static bool Send(UserEmail user, MessageObject message)
  {
    Logging.WriteLogWithObjects(nameof (SMTP), nameof (Send), "Parameters", user, message, true);
    Logging.WriteLog(nameof (SMTP), nameof (Send), "Invoking", true);
    bool flag;
    if (message.Recipients.Count == 0)
    {
      if (!Settings.SuppressExceptions)
        throw new Exception("Must specify at least one recipient.");
      flag = false;
    }
    else
    {
      MailMessage message1 = new MailMessage();
      try
      {
        Logging.WriteLog(nameof (SMTP), nameof (Send), "BeginSetup", true);
        MailMessage mailMessage = message1;
        try
        {
          foreach (string recipient in message.Recipients)
            mailMessage.To.Add(recipient);
        }
        finally
        {
          HashSet<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        try
        {
          foreach (string ccRecipient in message.CCRecipients)
            mailMessage.CC.Add(ccRecipient);
        }
        finally
        {
          HashSet<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        try
        {
          foreach (string bccRecipient in message.BCCRecipients)
            mailMessage.Bcc.Add(bccRecipient);
        }
        finally
        {
          HashSet<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        mailMessage.From = new MailAddress(string.IsNullOrEmpty(message.FromAddress) ? user.Address : message.FromAddress);
        mailMessage.Subject = message.Subject;
        mailMessage.Body = message.TextBody;
        if (message.SetFromAddressAsSentOnBehalfOfName)
          mailMessage.Sender = new MailAddress(string.IsNullOrEmpty(message.FromAddress) ? user.Address : message.FromAddress);
        if (!string.IsNullOrEmpty(message.HTMLBody) || !string.IsNullOrEmpty(message.ImageBody))
        {
          List<LinkedResource> linkedResourceList1 = new List<LinkedResource>();
          string content = message.HTMLBody;
          if (string.IsNullOrEmpty(content))
            content = "<img src=\"cid:ImageEmailBody\">";
          if (!string.IsNullOrEmpty(message.ImageBody))
          {
            List<LinkedResource> linkedResourceList2 = linkedResourceList1;
            LinkedResource linkedResource = new LinkedResource(message.ImageBody);
            linkedResource.ContentId = "ImageEmailBody";
            linkedResourceList2.Add(linkedResource);
          }
          if (message.InlineImages)
          {
            string text = content;
            try
            {
              XDocument xdocument = XDocument.Parse(text);
              int num = 0;
              try
              {
                IEnumerable<XElement> source1 = xdocument.Descendants();
                Func<XElement, bool> predicate1;
                // ISSUE: reference to a compiler-generated field
                if (SMTP._Closure\u0024__.\u0024I2\u002D0 != null)
                {
                  // ISSUE: reference to a compiler-generated field
                  predicate1 = SMTP._Closure\u0024__.\u0024I2\u002D0;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  SMTP._Closure\u0024__.\u0024I2\u002D0 = predicate1 = (Func<XElement, bool>) ([SpecialName] (elem) => elem.Name.LocalName.EqualsNoCase("img"));
                }
                foreach (XElement xelement in source1.Where<XElement>(predicate1))
                {
                  IEnumerable<XAttribute> source2 = xelement.Attributes();
                  Func<XAttribute, bool> predicate2;
                  // ISSUE: reference to a compiler-generated field
                  if (SMTP._Closure\u0024__.\u0024I2\u002D1 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    predicate2 = SMTP._Closure\u0024__.\u0024I2\u002D1;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    SMTP._Closure\u0024__.\u0024I2\u002D1 = predicate2 = (Func<XAttribute, bool>) ([SpecialName] (attr) => attr.Name.LocalName.EqualsNoCase("src"));
                  }
                  XAttribute xattribute = source2.FirstOrDefault<XAttribute>(predicate2);
                  if (xattribute != null && !xattribute.Value.StartsWith("http", StringComparison.OrdinalIgnoreCase) && !xattribute.Value.StartsWith("cid", StringComparison.OrdinalIgnoreCase))
                  {
                    string mimeType = MessageObject.FindMimeType(xattribute.Value);
                    string str = $"embed{num:00}";
                    List<LinkedResource> linkedResourceList3 = linkedResourceList1;
                    LinkedResource linkedResource = new LinkedResource(xattribute.Value);
                    linkedResource.ContentId = str;
                    linkedResource.ContentType = new ContentType(mimeType);
                    linkedResourceList3.Add(linkedResource);
                    text = text.Replace(xattribute.Value, $"cid:{str}");
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
            content = text;
          }
          AlternateView alternateViewFromString = AlternateView.CreateAlternateViewFromString(content, Encoding.UTF8, "text/html");
          try
          {
            foreach (LinkedResource linkedResource in linkedResourceList1)
              alternateViewFromString.LinkedResources.Add(linkedResource);
          }
          finally
          {
            List<LinkedResource>.Enumerator enumerator;
            enumerator.Dispose();
          }
          message1.AlternateViews.Add(alternateViewFromString);
        }
        try
        {
          foreach (string fileAttachment in message.FileAttachments)
            message1.Attachments.Add(new Attachment(fileAttachment));
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
        Logging.WriteLog(nameof (SMTP), "Send.Setup Failed (Exception)", ex.Message);
        if (Settings.SuppressExceptions)
        {
          flag = false;
          ProjectData.ClearProjectError();
          goto label_86;
        }
        throw;
      }
      Logging.WriteLog(nameof (SMTP), nameof (Send), "EndSetup", true);
      Logging.WriteLog(nameof (SMTP), nameof (Send), "BeginPrepareClient", true);
      SmtpClient smtpClient;
      try
      {
        Uri uri = user.Server.IndexOf("://") != -1 ? new Uri(user.Server) : new Uri("smtp://" + user.Server);
        if (!uri.IsDefaultPort)
        {
          Logging.WriteLog(nameof (SMTP), nameof (Send), "PrepareClient: Using port " + Conversions.ToString(uri.Port), true);
          smtpClient = new SmtpClient(uri.GetComponents(UriComponents.PathAndQuery | UriComponents.Host, UriFormat.UriEscaped).TrimEnd('/'), uri.Port);
          if (uri.Port != 465 && uri.Port != 587)
          {
            if (uri.Port != 2525)
              goto label_65;
          }
          Logging.WriteLog(nameof (SMTP), nameof (Send), "PrepareClient: Using SSL", true);
          smtpClient.EnableSsl = true;
        }
        else
          smtpClient = new SmtpClient(user.Server);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Logging.WriteLog(nameof (SMTP), "Send.PrepareClient (Exception)", ex.Message);
        smtpClient = new SmtpClient(user.Server);
        ProjectData.ClearProjectError();
      }
label_65:
      if (!string.IsNullOrEmpty(user.Username))
      {
        if (!string.IsNullOrEmpty(user.Password))
        {
          try
          {
            CoffeeTripleDesEncrypter tripleDesEncrypter = new CoffeeTripleDesEncrypter();
            smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(user.Username, ((TripleDesEncrypter) tripleDesEncrypter).Decrypt(user.Password));
            goto label_70;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Logging.WriteLog(nameof (SMTP), "Send.PrepareClient Authentication failed (exception).", $"Error {ex.Message}. Using default credentials.");
            smtpClient.UseDefaultCredentials = true;
            ProjectData.ClearProjectError();
            goto label_70;
          }
        }
      }
      smtpClient.UseDefaultCredentials = true;
label_70:
      Logging.WriteLog(nameof (SMTP), nameof (Send), "EndPrepareClient", true);
      Logging.WriteLog(nameof (SMTP), nameof (Send), "SendMail");
      try
      {
        smtpClient.Send(message1);
      }
      catch (SmtpException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SmtpException ex2 = ex1;
        Logging.WriteLog(nameof (SMTP), "Send Failed (Exception)", ex2.Message);
        ErrorHandler.SilentHandleError((Exception) ex2);
        if (!Settings.SuppressDialogs)
        {
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.AppendFormat("Unable to send email(s) to {0} due to the following exceptions:\n", (object) string.Join(", ", (IEnumerable<string>) message.Recipients));
          for (Exception exception = (Exception) ex2; exception != null; exception = exception.InnerException)
            stringBuilder.AppendLine($"--{ex2.Message}\n");
          stringBuilder.Append("Please contact technical support.");
          int num = (int) MessageBox.Show(stringBuilder.ToString(), "Unable To Send Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        if (Settings.SuppressExceptions)
        {
          flag = false;
          ProjectData.ClearProjectError();
          goto label_86;
        }
        throw;
      }
      finally
      {
        message1?.Dispose();
        smtpClient?.Dispose();
      }
      Logging.WriteLog(nameof (SMTP), nameof (Send), "Invoked", true);
      flag = true;
    }
label_86:
    return flag;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SMTP_Email
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Email;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
[Obsolete("Use CurrentUser.Instance.Email or MGASystems.Common.UserEmail instead.")]
public sealed class SMTP_Email
{
  private const string SETTING_FORCEOUTLOOKHTML = "Email.SmtpOutlook.Default.ForceHtml";

  static SMTP_Email() => SMTP_Email.SuppressDialog = false;

  public static bool SuppressDialog { get; set; }

  public static bool SendMailEx(
    string emailTo,
    string subject,
    string body,
    bool promptifCredentialsMissing)
  {
    return SMTP_Email.SendMailEx(emailTo, subject, body, (Attachment[]) null, promptifCredentialsMissing);
  }

  [Obsolete("No longer to be used. Need indication of success/failure, so use SendMailEx instead.")]
  public static void SendMail(
    string emailTo,
    string subject,
    string body,
    bool promptifCredentialsMissing)
  {
    SMTP_Email.SendMail(emailTo, subject, body, (Attachment[]) null, promptifCredentialsMissing);
  }

  [Obsolete("No longer to be used. Need indication of success/failure, so use SendMailEx instead.")]
  public static void SendMail(
    string emailTo,
    string subject,
    string body,
    Attachment[] attachments,
    bool promptifCredentialsMissing)
  {
    if (!SMTP_Email.ValidateUser(promptifCredentialsMissing, emailTo))
      return;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
    {
      (object) "@UserID",
      (object) CurrentUser.Instance.UserID
    });
    Encryption encryption = new Encryption();
    string mailServer = (string) dataRow[0];
    string mailServerUsername = (string) dataRow[1];
    string base64Text = (string) dataRow[2];
    string mailServerPassword = encryption.DecryptTripleDes(base64Text);
    string emailFrom = (string) dataRow[3];
    SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments);
  }

  public static bool SendMailEx(
    string emailTo,
    string subject,
    string body,
    Attachment[] attachments,
    bool promptifCredentialsMissing)
  {
    bool flag;
    if (!SMTP_Email.ValidateUser(promptifCredentialsMissing, emailTo))
    {
      flag = false;
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
      {
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
      Encryption encryption = new Encryption();
      string mailServer = (string) dataRow[0];
      string mailServerUsername = (string) dataRow[1];
      string base64Text = (string) dataRow[2];
      string mailServerPassword = encryption.DecryptTripleDes(base64Text);
      string emailFrom = (string) dataRow[3];
      flag = SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments);
    }
    return flag;
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    Attachment[] attachments,
    bool promptifCredentialsMissing)
  {
    bool flag;
    if (!SMTP_Email.ValidateUser(promptifCredentialsMissing, emailTo))
    {
      flag = false;
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
      {
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
      Encryption encryption = new Encryption();
      string mailServer = (string) dataRow[0];
      string mailServerUsername = (string) dataRow[1];
      string base64Text = (string) dataRow[2];
      string mailServerPassword = encryption.DecryptTripleDes(base64Text);
      flag = SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments);
    }
    return flag;
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    List<string> ccList,
    string subject,
    string body,
    Attachment[] attachments,
    bool promptifCredentialsMissing)
  {
    bool flag;
    if (!SMTP_Email.ValidateUser(promptifCredentialsMissing, emailTo))
    {
      flag = false;
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
      {
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
      Encryption encryption = new Encryption();
      string mailServer = (string) dataRow[0];
      string mailServerUsername = (string) dataRow[1];
      string base64Text = (string) dataRow[2];
      string mailServerPassword = encryption.DecryptTripleDes(base64Text);
      flag = SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments, ccList);
    }
    return flag;
  }

  public static void SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword)
  {
    SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, (Attachment[]) null);
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword,
    Attachment[] attachments)
  {
    return SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments, (List<string>) null);
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword,
    Attachment[] attachments,
    List<string> ccList)
  {
    return SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments, ccList, (List<string>) null);
  }

  public static bool SendMail(
    List<string> bccList,
    string emailTo,
    string emailFrom,
    List<string> ccList,
    string subject,
    string body,
    Attachment[] attachments,
    bool promptifCredentialsMissing)
  {
    bool flag;
    if (!SMTP_Email.ValidateUser(promptifCredentialsMissing, emailTo))
    {
      flag = false;
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
      {
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
      Encryption encryption = new Encryption();
      string mailServer = (string) dataRow[0];
      string mailServerUsername = (string) dataRow[1];
      string base64Text = (string) dataRow[2];
      string mailServerPassword = encryption.DecryptTripleDes(base64Text);
      flag = SMTP_Email.SendMail(emailTo, emailFrom, subject, body, mailServer, mailServerUsername, mailServerPassword, attachments, ccList, bccList);
    }
    return flag;
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    bool IsBodyHTML,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword,
    Attachment[] attachments,
    List<string> ccList,
    List<string> bccList)
  {
    SMTP_Email.WriteLogWithArgs(nameof (SendMail), "Invoking", (object) nameof (emailTo), (object) emailTo, (object) nameof (emailFrom), (object) emailFrom, (object) nameof (subject), (object) subject, (object) nameof (body), (object) body, (object) nameof (mailServer), (object) mailServer, (object) nameof (mailServerUsername), (object) mailServerUsername, (object) nameof (mailServerPassword), (object) mailServerPassword, (object) nameof (attachments), (object) attachments, (object) nameof (ccList), (object) ccList, (object) nameof (bccList), (object) bccList);
    bool flag;
    if (string.IsNullOrEmpty(emailTo))
    {
      flag = false;
    }
    else
    {
      MailMessage message = new MailMessage(emailFrom, emailTo);
      MailMessage mailMessage = message;
      mailMessage.IsBodyHtml = IsBodyHTML;
      mailMessage.Subject = subject;
      mailMessage.Body = body;
      if (ccList != null)
      {
        int num = ccList.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!string.IsNullOrEmpty(ccList[index]))
            mailMessage.CC.Add(ccList[index]);
        }
      }
      if (bccList != null)
      {
        int num = bccList.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!string.IsNullOrEmpty(bccList[index]))
            mailMessage.Bcc.Add(bccList[index]);
        }
      }
      if (attachments != null)
      {
        Attachment[] attachmentArray = attachments;
        int index = 0;
        while (index < attachmentArray.Length)
        {
          Attachment attachment = attachmentArray[index];
          message.Attachments.Add(attachment);
          checked { ++index; }
        }
      }
      NetworkCredential networkCredential = (NetworkCredential) null;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServerPassword, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServerUsername, string.Empty, false) != 0)
        networkCredential = new NetworkCredential(mailServerUsername, mailServerPassword);
      SmtpClient smtpClient = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServer, string.Empty, false) == 0 ? new SmtpClient("localhost") : new SmtpClient(mailServer);
      if (networkCredential != null)
        smtpClient.Credentials = (ICredentialsByHost) networkCredential;
      else
        smtpClient.UseDefaultCredentials = true;
      try
      {
        smtpClient.Send(message);
      }
      catch (SmtpException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SmtpException ex2 = ex1;
        SMTP_Email.WriteLog("SendMail Failed (SmtpException)", ex2.Message);
        SMTP_Email.HandleEmailError(ex2, emailTo);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_27;
      }
      SMTP_Email.WriteLog(nameof (SendMail), "Invoked");
      flag = true;
    }
label_27:
    return flag;
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword,
    Attachment[] attachments,
    List<string> ccList,
    List<string> bccList)
  {
    SMTP_Email.WriteLogWithArgs(nameof (SendMail), "Invoking", (object) nameof (emailTo), (object) emailTo, (object) nameof (emailFrom), (object) emailFrom, (object) nameof (subject), (object) subject, (object) nameof (body), (object) body, (object) nameof (mailServer), (object) mailServer, (object) nameof (mailServerUsername), (object) mailServerUsername, (object) nameof (mailServerPassword), (object) mailServerPassword, (object) nameof (attachments), (object) attachments, (object) nameof (ccList), (object) ccList, (object) nameof (bccList), (object) bccList);
    bool flag;
    if (string.IsNullOrEmpty(emailTo))
    {
      flag = false;
    }
    else
    {
      MailMessage message = new MailMessage(emailFrom, emailTo);
      MailMessage mailMessage = message;
      mailMessage.Subject = subject;
      mailMessage.Body = body;
      if (ccList != null)
      {
        int num = ccList.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!string.IsNullOrEmpty(ccList[index]))
            mailMessage.CC.Add(ccList[index]);
        }
      }
      if (bccList != null)
      {
        int num = bccList.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!string.IsNullOrEmpty(bccList[index]))
            mailMessage.Bcc.Add(bccList[index]);
        }
      }
      if (attachments != null)
      {
        Attachment[] attachmentArray = attachments;
        int index = 0;
        while (index < attachmentArray.Length)
        {
          Attachment attachment = attachmentArray[index];
          message.Attachments.Add(attachment);
          checked { ++index; }
        }
      }
      NetworkCredential networkCredential = (NetworkCredential) null;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServerPassword, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServerUsername, string.Empty, false) != 0)
        networkCredential = new NetworkCredential(mailServerUsername, mailServerPassword);
      SmtpClient smtpClient = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServer, string.Empty, false) == 0 ? new SmtpClient("localhost") : new SmtpClient(mailServer);
      if (networkCredential != null)
        smtpClient.Credentials = (ICredentialsByHost) networkCredential;
      else
        smtpClient.UseDefaultCredentials = true;
      try
      {
        smtpClient.Send(message);
      }
      catch (SmtpException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SmtpException ex2 = ex1;
        SMTP_Email.WriteLog("SendMail Failed (SmtpException)", ex2.Message);
        SMTP_Email.HandleEmailError(ex2, emailTo);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_27;
      }
      SMTP_Email.WriteLog(nameof (SendMail), "Invoked");
      flag = true;
    }
label_27:
    return flag;
  }

  public static bool SendMail(
    string emailTo,
    string emailFrom,
    string subject,
    string body,
    string mailServer,
    string mailServerUsername,
    string mailServerPassword,
    Attachment[] attachments,
    List<string> ccList,
    List<string> bccList,
    bool IsImageBody)
  {
    SMTP_Email.WriteLogWithArgs(nameof (SendMail), "Invoking", (object) nameof (emailTo), (object) emailTo, (object) nameof (emailFrom), (object) emailFrom, (object) nameof (subject), (object) subject, (object) nameof (body), (object) body, (object) nameof (mailServer), (object) mailServer, (object) nameof (mailServerUsername), (object) mailServerUsername, (object) nameof (mailServerPassword), (object) mailServerPassword, (object) nameof (attachments), (object) attachments, (object) nameof (ccList), (object) ccList, (object) nameof (bccList), (object) bccList, (object) nameof (IsImageBody), (object) IsImageBody);
    bool flag;
    if (string.IsNullOrEmpty(emailTo))
    {
      flag = false;
    }
    else
    {
      MailMessage message = new MailMessage(emailFrom, emailTo);
      MailMessage mailMessage = message;
      mailMessage.Subject = subject;
      mailMessage.Body = body;
      if (ccList != null)
      {
        int num = ccList.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!string.IsNullOrEmpty(ccList[index]))
            mailMessage.CC.Add(ccList[index]);
        }
      }
      if (bccList != null)
      {
        int num = bccList.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!string.IsNullOrEmpty(bccList[index]))
            mailMessage.Bcc.Add(bccList[index]);
        }
      }
      if (attachments != null)
      {
        Attachment[] attachmentArray = attachments;
        int index = 0;
        while (index < attachmentArray.Length)
        {
          Attachment attachment = attachmentArray[index];
          message.Attachments.Add(attachment);
          checked { ++index; }
        }
      }
      if (IsImageBody)
      {
        message.IsBodyHtml = true;
        LinkedResource linkedResource = new LinkedResource(body);
        linkedResource.ContentId = "ImageEmailBody";
        AlternateView alternateViewFromString = AlternateView.CreateAlternateViewFromString("<img src=cid:ImageEmailBody>", (Encoding) null, "text/html");
        alternateViewFromString.LinkedResources.Add(linkedResource);
        message.AlternateViews.Add(alternateViewFromString);
      }
      NetworkCredential networkCredential = (NetworkCredential) null;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServerPassword, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServerUsername, string.Empty, false) != 0)
        networkCredential = new NetworkCredential(mailServerUsername, mailServerPassword);
      SmtpClient smtpClient = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(mailServer, string.Empty, false) == 0 ? new SmtpClient("localhost") : new SmtpClient(mailServer);
      if (networkCredential != null)
        smtpClient.Credentials = (ICredentialsByHost) networkCredential;
      else
        smtpClient.UseDefaultCredentials = true;
      try
      {
        smtpClient.Send(message);
      }
      catch (SmtpException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SmtpException ex2 = ex1;
        SMTP_Email.WriteLog("SendMail Failed (SmtpException)", ex2.Message);
        SMTP_Email.HandleEmailError(ex2, emailTo);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_29;
      }
      SMTP_Email.WriteLog(nameof (SendMail), "Invoked");
      flag = true;
    }
label_29:
    return flag;
  }

  private static string WriteLogWithArgs(string method, string message, params object[] args)
  {
    return args != null ? ActionLog.Write(nameof (SMTP_Email), method, $"{message} {ActionLog.ToArgString(args)}") : ActionLog.Write(nameof (SMTP_Email), method, message);
  }

  private static string WriteLog(string method, string message, bool optional = false)
  {
    return ActionLog.Write(nameof (SMTP_Email), method, message, optional);
  }

  private static void HandleEmailError(SmtpException ex, string emailTo)
  {
    Exception exception = (Exception) ex;
    string str = $"An email could not be sent to {emailTo} due to the following reason:";
    ErrorHandler.SilentHandleError((Exception) ex);
    if (exception.InnerException != null)
      str += "\n\n";
    for (; exception != null; exception = exception.InnerException)
      str += exception.Message.ToString();
    string text = str + "\n\nPlease contact technical support.";
    if (SMTP_Email.SuppressDialog)
      ExceptionDispatchInfo.Capture((Exception) ex).Throw();
    int num = (int) MessageBox.Show(text, "Unable To Send Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  public static bool SendUsingOutlook(
    List<string> attachmentPaths,
    List<string> recipients,
    string subject,
    string body,
    List<string> ccList,
    SMTP_Email.ShowOrSend showOrSend)
  {
    return SMTP_Email.SendUsingOutlook((Hashtable) null, attachmentPaths, recipients, subject, body, ccList, SMTP_Email.ShowOrSend.Show, false);
  }

  public static bool SendUsingOutlook(
    List<string> attachmentPaths,
    List<string> recipients,
    string subject,
    string body,
    List<string> ccList,
    SMTP_Email.ShowOrSend showOrSend,
    bool promptIfCredentialsMissing,
    bool sendAsHtml = false)
  {
    return SMTP_Email.SendUsingOutlook((Hashtable) null, attachmentPaths, recipients, subject, body, ccList, showOrSend, promptIfCredentialsMissing, sendAsHtml);
  }

  public static bool SendUsingOutlook(
    Hashtable userProperties,
    List<string> attachmentPaths,
    List<string> recipients,
    string subject,
    string body,
    List<string> ccList,
    SMTP_Email.ShowOrSend showOrSend)
  {
    return SMTP_Email.SendUsingOutlook(userProperties, attachmentPaths, recipients, subject, body, ccList, SMTP_Email.ShowOrSend.Show, false);
  }

  public static bool SendUsingOutlook(
    Hashtable userProperties,
    List<string> attachmentPaths,
    List<string> recipients,
    string subject,
    string body,
    List<string> ccList,
    SMTP_Email.ShowOrSend showOrSend,
    bool promptIfCredentialsMissing,
    bool sendAsHtml = false)
  {
    return SMTP_Email.SendUsingOutlook(userProperties, attachmentPaths, recipients, subject, body, ccList, (List<string>) null, showOrSend, false, sendAsHtml);
  }

  public static bool SendUsingOutlook(
    Hashtable userProperties,
    List<string> attachmentPaths,
    List<string> recipients,
    string subject,
    string body,
    List<string> ccList,
    List<string> bcList,
    SMTP_Email.ShowOrSend showOrSend,
    bool promptIfCredentialsMissing,
    bool sendAsHtml = false)
  {
    MessageObject message = new MessageObject();
    message.Recipients.UnionWith((IEnumerable<string>) recipients ?? Enumerable.Empty<string>());
    message.CCRecipients.UnionWith((IEnumerable<string>) ccList ?? Enumerable.Empty<string>());
    message.BCCRecipients.UnionWith((IEnumerable<string>) bcList ?? Enumerable.Empty<string>());
    message.Subject = subject;
    if (sendAsHtml || !SystemSettings.KeyExists("Email.SmtpOutlook.Default.ForceHtml") || SystemSettings.GetBoolSetting("Email.SmtpOutlook.Default.ForceHtml"))
      message.HTMLBody = body;
    else
      message.TextBody = body;
    message.SendOutlook = showOrSend == SMTP_Email.ShowOrSend.Send ? OutlookSendType.Send : OutlookSendType.Show;
    if (userProperties != null)
    {
      foreach (object userProperty in userProperties)
      {
        DictionaryEntry dictionaryEntry = userProperty != null ? (DictionaryEntry) userProperty : new DictionaryEntry();
        message.UserProperties.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key), RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
      }
    }
    message.FileAttachments.UnionWith((IEnumerable<string>) attachmentPaths ?? Enumerable.Empty<string>());
    return Outlook.Send(message);
  }

  private static void PromptUserForEmailSettings()
  {
    FormSettings.ShowFormDialog(typeof (frmEmailInfo), (object) CurrentUser.Instance.UserGUID);
  }

  private static bool ValidateUser(bool promptifCredentialsMissing, string emailTo)
  {
    bool flag;
    if (!CurrentUser.Instance.HasValidMailSettings)
    {
      if (SMTP_Email.SuppressDialog)
      {
        flag = false;
        goto label_10;
      }
      if (!promptifCredentialsMissing)
      {
        int num = (int) MessageBox.Show($"An email could not be sent to {emailTo}.\n\nYou need to set up valid email information for your user account and retry this operation.", "Unable To Send Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        goto label_10;
      }
      if (MDIControls.Instance.MDIParent.InvokeRequired)
        MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(SMTP_Email.PromptUserForEmailSettings));
      if (!CurrentUser.Instance.HasValidMailSettings)
      {
        int num = (int) MessageBox.Show($"An email could not be sent to {emailTo}.\n\nYou do not have valid email information set up for your user account.", "Unable To Send Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        goto label_10;
      }
    }
    flag = true;
label_10:
    return flag;
  }

  public enum ShowOrSend
  {
    Show = 1,
    Send = 2,
  }

  public enum HtmlOrText
  {
    Html = 1,
    Text = 2,
  }
}

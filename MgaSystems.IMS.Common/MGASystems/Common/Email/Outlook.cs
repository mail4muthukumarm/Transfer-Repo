// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.Outlook
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.ErrorHandling;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Email;

[StandardModule]
public sealed class Outlook
{
  private const string PR_ATTACH_MIME_TAG = "http://schemas.microsoft.com/mapi/proptag/0x370E001E";
  private const string PR_ATTACH_CONTENT_ID = "http://schemas.microsoft.com/mapi/proptag/0x3712001E";

  public static bool Send(MessageObject message)
  {
    bool trackSentEmailOverride = SystemSettings.KeyExists("Outlook.TrackSentEmails") && SystemSettings.GetBoolSetting("Outlook.TrackSentEmails");
    return MGASystems.Common.Email.Outlook.Send(message, trackSentEmailOverride);
  }

  public static bool Send(MessageObject message, bool trackSentEmailOverride)
  {
    Logging.WriteLogWithObjects(nameof (Outlook), nameof (Send), "Parameters", (UserEmail) null, message, true);
    Logging.WriteLog(nameof (Outlook), nameof (Send), "Invoking", true);
    bool flag1;
    if (!CurrentUser.UsingOutlook)
    {
      if (!Settings.SuppressExceptions)
        throw new InvalidOperationException("Check CurrentUser.UsingOutlook prior to calling SendUsingOutlook");
      flag1 = false;
    }
    else
    {
      Logging.WriteLog(nameof (Outlook), nameof (Send), "BeginApplicationCreate", true);
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Outlook.Application instance;
      try
      {
        instance = (Microsoft.Office.Interop.Outlook.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
      }
      catch (COMException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        COMException comException = ex;
        if (!Settings.SuppressDialogs)
        {
          int num = (int) MessageBox.Show("The IMS was unable to create a Microsoft Outlook email.\\n\\nPlease ensure Microsoft Outlook is properly installed on this machine.\n\n" + comException.Message, "Unable to Create Outlook Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_65;
      }
      // ISSUE: variable of a compiler-generated type
      MailItem mailItem;
      try
      {
        // ISSUE: reference to a compiler-generated method
        mailItem = (MailItem) instance.CreateItem(OlItemType.olMailItem);
      }
      catch (COMException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        COMException comException = ex;
        if (!Settings.SuppressDialogs)
        {
          int num = (int) MessageBox.Show("The IMS was unable to create an email message:\n\n" + comException.Message, "Unable to Create Email", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_65;
      }
      Logging.WriteLog(nameof (Outlook), nameof (Send), "EndApplicationCreate", true);
      bool flag2 = false;
      if (mailItem != null)
      {
        try
        {
          Logging.WriteLog(nameof (Outlook), nameof (Send), "BeginSetup", true);
          mailItem.To = string.Join(";", (IEnumerable<string>) message.Recipients);
          mailItem.CC = string.Join(";", (IEnumerable<string>) message.CCRecipients);
          mailItem.BCC = string.Join(";", (IEnumerable<string>) message.BCCRecipients);
          if (message.SetFromAddressAsSentOnBehalfOfName)
            mailItem.SentOnBehalfOfName = message.FromAddress;
          mailItem.Subject = message.Subject;
          // ISSUE: variable of a compiler-generated type
          Inspector getInspector = mailItem.GetInspector;
          if (!string.IsNullOrEmpty(message.HTMLBody) || !string.IsNullOrEmpty(message.ImageBody))
          {
            string str1 = message.HTMLBody;
            if (!string.IsNullOrEmpty(message.ImageBody))
            {
              if (string.IsNullOrEmpty(str1))
                str1 = "<img src=\"cid:ImageEmailBody\" />";
              // ISSUE: reference to a compiler-generated method
              // ISSUE: variable of a compiler-generated type
              Attachment attachment = mailItem.Attachments.Add((object) message.ImageBody, (object) OlAttachmentType.olEmbeddeditem, (object) 0, (object) Path.GetFileName(message.ImageBody));
              // ISSUE: reference to a compiler-generated method
              attachment.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x370E001E", (object) MessageObject.FindMimeType(message.ImageBody, "image/jpeg"));
              // ISSUE: reference to a compiler-generated method
              attachment.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x3712001E", (object) "ImageEmailBody");
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
                  IEnumerable<XElement> source1 = xdocument.Descendants();
                  Func<XElement, bool> predicate1;
                  // ISSUE: reference to a compiler-generated field
                  if (MGASystems.Common.Email.Outlook._Closure\u0024__.\u0024I3\u002D0 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    predicate1 = MGASystems.Common.Email.Outlook._Closure\u0024__.\u0024I3\u002D0;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    MGASystems.Common.Email.Outlook._Closure\u0024__.\u0024I3\u002D0 = predicate1 = (Func<XElement, bool>) ([SpecialName] (elem) => elem.Name.LocalName.EqualsNoCase("img"));
                  }
                  foreach (XElement xelement in source1.Where<XElement>(predicate1))
                  {
                    IEnumerable<XAttribute> source2 = xelement.Attributes();
                    Func<XAttribute, bool> predicate2;
                    // ISSUE: reference to a compiler-generated field
                    if (MGASystems.Common.Email.Outlook._Closure\u0024__.\u0024I3\u002D1 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      predicate2 = MGASystems.Common.Email.Outlook._Closure\u0024__.\u0024I3\u002D1;
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      MGASystems.Common.Email.Outlook._Closure\u0024__.\u0024I3\u002D1 = predicate2 = (Func<XAttribute, bool>) ([SpecialName] (attr) => attr.Name.LocalName.EqualsNoCase("src"));
                    }
                    XAttribute xattribute = source2.FirstOrDefault<XAttribute>(predicate2);
                    if (xattribute != null && !xattribute.Value.StartsWith("http", StringComparison.OrdinalIgnoreCase) && !xattribute.Value.StartsWith("cid", StringComparison.OrdinalIgnoreCase))
                    {
                      string str2 = $"embed{num:00}";
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: variable of a compiler-generated type
                      Attachment attachment = mailItem.Attachments.Add((object) xattribute.Value, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
                      // ISSUE: reference to a compiler-generated method
                      attachment.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x370E001E", (object) MessageObject.FindMimeType(xattribute.Value));
                      // ISSUE: reference to a compiler-generated method
                      attachment.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x3712001E", (object) str2);
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
            mailItem.HTMLBody = str1 + mailItem.HTMLBody;
          }
          else if (!string.IsNullOrEmpty(message.TextBody))
            mailItem.Body = message.TextBody + mailItem.Body;
          try
          {
            foreach (string fileAttachment in message.FileAttachments)
            {
              if (!string.IsNullOrEmpty(fileAttachment))
              {
                // ISSUE: reference to a compiler-generated method
                mailItem.Attachments.Add((object) fileAttachment, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
              }
            }
          }
          finally
          {
            HashSet<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            if (trackSentEmailOverride)
            {
              Logging.WriteLog(nameof (Outlook), nameof (Send), "BeginTrackSentEmail", true);
              foreach (object userProperty in message.UserProperties)
              {
                DictionaryEntry dictionaryEntry = userProperty != null ? (DictionaryEntry) userProperty : new DictionaryEntry();
                if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dictionaryEntry.Value)))
                {
                  int result;
                  if (!int.TryParse(dictionaryEntry.Value.ToString(), out result))
                    throw new InvalidOperationException();
                  OutlookTracker.SetMailItemUserPropertyValue((object) mailItem, (string) dictionaryEntry.Key, result);
                }
                else
                  OutlookTracker.SetMailItemUserPropertyValue((object) mailItem, (string) dictionaryEntry.Key, (string) dictionaryEntry.Value);
              }
              Logging.WriteLog(nameof (Outlook), nameof (Send), "EndTrackSentEmail", true);
              OutlookTracker.TrackSentEmail(mailItem);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ErrorHandler.SilentHandleError(ex);
            ProjectData.ClearProjectError();
          }
          Logging.WriteLog(nameof (Outlook), nameof (Send), "EndSetup", true);
          Logging.WriteLog(nameof (Outlook), nameof (Send), $"OutlookSendType.{message.SendOutlook}");
          if (message.SendOutlook == OutlookSendType.Show)
          {
            // ISSUE: reference to a compiler-generated method
            mailItem.Display();
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            mailItem.GetInspector.Close(OlInspectorClose.olSave);
            // ISSUE: reference to a compiler-generated method
            mailItem.Send();
          }
          flag2 = true;
        }
        catch (COMException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          Logging.WriteLog(nameof (Outlook), "Send Failed (Exception)", $"COMException: {ex.Message}");
          flag1 = false;
          ProjectData.ClearProjectError();
          goto label_65;
        }
      }
      Logging.WriteLog(nameof (Outlook), nameof (Send), "Invoked", true);
      flag1 = flag2;
    }
label_65:
    return flag1;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OutlookTracker
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.BroadcastMessaging;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class OutlookTracker
{
  private const string ProcessedEmailPropertyName = "MGASystems.IMS.Email.Processed";
  private static Application outlook;
  private static Items sentItems;

  internal static void TrackSentEmail(MailItem mailItem)
  {
    OutlookTracker.ConnectToOutlook();
    OutlookTracker.SetMailItemUserPropertyValue((object) mailItem, "MGASystems.IMS.Email.Processed", false);
  }

  private static void ConnectToOutlook()
  {
    if (OutlookTracker.outlook != null)
      return;
    OutlookTracker.outlook = (Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
    // ISSUE: method pointer
    // ISSUE: object of a compiler-generated type is created
    new ComAwareEventInfo(typeof (ApplicationEvents_11_Event), "Quit").AddEventHandler((object) OutlookTracker.outlook, (Delegate) new ApplicationEvents_11_QuitEventHandler((object) null, (UIntPtr) __methodptr(OutlookApplication_Quit)));
    // ISSUE: reference to a compiler-generated method
    OutlookTracker.sentItems = OutlookTracker.outlook.Session.GetDefaultFolder(OlDefaultFolders.olFolderSentMail).Items;
    // ISSUE: method pointer
    // ISSUE: object of a compiler-generated type is created
    new ComAwareEventInfo(typeof (ItemsEvents_Event), "ItemAdd").AddEventHandler((object) OutlookTracker.sentItems, (Delegate) new ItemsEvents_ItemAddEventHandler((object) null, (UIntPtr) __methodptr(SentItems_ItemAdd)));
  }

  public static bool TryGetMailItemUserPropertyValue<T>(
    object mailItemObject,
    string propertyName,
    ref T propertyValue)
  {
    bool userPropertyValue;
    if (mailItemObject is MailItem mailItem)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      UserProperty userProperty = mailItem.UserProperties.Find(propertyName, RuntimeHelpers.GetObjectValue((object) Missing.Value));
      if (userProperty != null)
      {
        propertyValue = userProperty.Value != null ? (T) userProperty.Value : default (T);
        userPropertyValue = true;
        goto label_4;
      }
    }
    userPropertyValue = false;
label_4:
    return userPropertyValue;
  }

  public static void SetMailItemUserPropertyValue(
    object mailItemObject,
    string propertyName,
    int propertyValue)
  {
    OutlookTracker.GetMailItemUserProperty((MailItem) mailItemObject, propertyName, OlUserPropertyType.olInteger).Value = (object) propertyValue;
  }

  public static void SetMailItemUserPropertyValue(
    object mailItemObject,
    string propertyName,
    bool propertyValue)
  {
    OutlookTracker.GetMailItemUserProperty((MailItem) mailItemObject, propertyName, OlUserPropertyType.olYesNo).Value = (object) propertyValue;
  }

  public static void SetMailItemUserPropertyValue(
    object mailItemObject,
    string propertyName,
    string propertyValue)
  {
    OutlookTracker.GetMailItemUserProperty((MailItem) mailItemObject, propertyName, OlUserPropertyType.olText).Value = (object) propertyValue;
  }

  private static UserProperty GetMailItemUserProperty(
    MailItem mailItem,
    string propertyName,
    OlUserPropertyType userPropertyType)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: variable of a compiler-generated type
    UserProperty itemUserProperty = mailItem.UserProperties.Find(propertyName, RuntimeHelpers.GetObjectValue((object) Missing.Value)) ?? mailItem.UserProperties.Add(propertyName, userPropertyType, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
    return itemUserProperty;
  }

  private static void OutlookApplication_Quit()
  {
    // ISSUE: method pointer
    // ISSUE: object of a compiler-generated type is created
    new ComAwareEventInfo(typeof (ItemsEvents_Event), "ItemAdd").RemoveEventHandler((object) OutlookTracker.sentItems, (Delegate) new ItemsEvents_ItemAddEventHandler((object) null, (UIntPtr) __methodptr(SentItems_ItemAdd)));
    OutlookTracker.sentItems = (Items) null;
    // ISSUE: method pointer
    // ISSUE: object of a compiler-generated type is created
    new ComAwareEventInfo(typeof (ApplicationEvents_11_Event), "Quit").RemoveEventHandler((object) OutlookTracker.outlook, (Delegate) new ApplicationEvents_11_QuitEventHandler((object) null, (UIntPtr) __methodptr(OutlookApplication_Quit)));
    OutlookTracker.outlook = (Application) null;
  }

  private static void SentItems_ItemAdd(object Item)
  {
    // ISSUE: variable of a compiler-generated type
    MailItem mailItem = Item as MailItem;
    bool propertyValue = false;
    if (mailItem == null || !mailItem.Sent || !OutlookTracker.TryGetMailItemUserPropertyValue<bool>((object) mailItem, "MGASystems.IMS.Email.Processed", ref propertyValue) || propertyValue)
      return;
    OutlookTracker.SendOutlookEmailSentMessage(mailItem);
  }

  private static void SendOutlookEmailSentMessage(MailItem mailItem)
  {
    if (mailItem == null || !mailItem.Sent)
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.OutlookEmailSent, (object) mailItem);
  }
}
